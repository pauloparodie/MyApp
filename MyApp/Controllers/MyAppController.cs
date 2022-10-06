using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Threading.Tasks;
using MyApp.Filters;
using MyApp.BusinessLayer;
using MyApp.BusinessContract;
using MyApp.ViewModel;
using MyApp.DomainModel.Entities;


namespace MyApp.Controllers
{
    public class MyAppController : Controller
    {
        IBusinessManager _businessManager;

        public MyAppController(IBusinessManager businessManager)
        {
            _businessManager = businessManager;
        }


        [Route("Index")]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }


        [Route("Pessoas")]
        [AuthenticatedFilter]
        //[OutputCache(Duration =20)]
        public async Task<ActionResult> ListPessoas()
        {
            List<PessoaViewModel> pessoasVM = (List<PessoaViewModel>)
                AutoMapperHelper.MapStatic(await _businessManager.GetPessoasAsync(), typeof(List<PessoaViewModel>));

            return View("ListPessoas", pessoasVM);
        }


        [Route("Pessoa/{id:int:min(1)?}")]
        [AuthenticatedFilter]
        public async Task<ActionResult> PessoaDetail(int id = 0)
        {
            PessoaViewModel pessoaVM = null;

            if (id > 0)
            {
                pessoaVM = (PessoaViewModel)AutoMapperHelper.MapStatic(await _businessManager.GetPessoaAsync(id), typeof(PessoaViewModel));
                if (pessoaVM == null)
                {
                    ModelState.AddModelError("ErrInvalidCod", "Person not found");
                    //return View("PessoaDetail", pessoaVM);
                    //return HttpNotFound("Person not found");
                    /*ViewBag.ErrorMsg = "Person not found";
                    return View("MyError");*/
                    throw new Exception("person not found");
                }
            }

            return View("PessoaDetail", pessoaVM);
        }

        [Route("Pessoa/")]
        [HttpPost]
        [AuthenticatedFilter]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> PessoaDetail(PessoaViewModel pessoaVM)
        {
            if (!ModelState.IsValid)
            {
                return View("PessoaDetail", pessoaVM);
            }

            Pessoa pessoaDb = null;

            if (pessoaVM.Cod > 0)
            {
                pessoaDb = await _businessManager.GetPessoaAsync(pessoaVM.Cod);
                if (pessoaDb == null)
                {
                    ModelState.AddModelError("ErrInvalidCod", "Person not found");
                    //return View("PessoaDetail", pessoaVM);
                    return HttpNotFound("Person not found");
                }
            }
            else if (pessoaVM.Cod == 0)
            {
                pessoaDb = new Pessoa();
            }
            else
            {
                throw new Exception("Invalid person cod");
            }

            pessoaDb.Age = pessoaVM.Age;
            pessoaDb.Name = pessoaVM.Name;
            pessoaDb.Pais = pessoaVM.Pais;
            if (((pessoaVM.Photo?.ContentLength) ?? 0) > 0)
            {
                pessoaDb.PhotoName = pessoaVM.Photo.FileName;
            }
            if (pessoaDb.Cod == 0)
            {
                await _businessManager.CreatePessoaAsync(pessoaDb);
            }
            else
            {
                await _businessManager.EditPessoaAsync(pessoaDb);
            }

            return RedirectToAction("ListPessoas");
        }

        [Route("Pessoa/Delete/{id:int:min(1)}")]
        [AuthenticatedFilter]
        public async Task<ActionResult> PessoaDelete(int id)
        {
            try
            {
                await _businessManager.DeletePessoaAsync(id);
            }
            catch (Exception ex)
            {
                return View("MyError", ex);
            }

            return RedirectToAction("ListPessoas");
        }


        private bool disposedValue = false; // To detect redundant calls
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _businessManager.Dispose();
                }
                disposedValue = true;
            }
        }
    }
}