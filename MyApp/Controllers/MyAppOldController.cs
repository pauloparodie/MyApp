using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;


namespace MyApp.Controllers
{
    public class MyAppOldController : Controller
    {
        [Route("PessoasOld")]
        public async Task<ActionResult> ListPessoas()
        {
            /*ModelEntities db = new ModelEntities();

            List<ViewModel.PessoaViewModel> pessoasVM = (await (db.Pessoas.ToListAsync<ServiceLayer.DomainModel.Pessoa>())).
                Select(x => new ViewModel.PessoaViewModel
                {
                    Name = x.name,
                    Cod = x.cod,
                    Age = x.age,
                    Pais = x.pais,
                    PhotoName=x.photo_name,
                    Animals = x.animals.ToList().Select(y => new ViewModel.AnimalViewModel { Cod = y.cod, Name = y.name, Raca = y.raca }).ToList()
                }).ToList();

            */
            /*DBCodeFirst.ModelCFEntities ctx = new ModelCFEntities();
            List<Author> authors = ctx.Authors.ToList();
            List<Book> books = ctx.Books.ToList();*/

            //List<proc1_Result> res = db.proc1(4).ToList()<proc1_Result>();

            //return View(pessoasVM);
            return Content("PessoasOld");
        }


        [Route("PessoaOld/{id:int:min(1)?}")]
        public async Task<ActionResult> PessoaDetail(int id = 0)
        {
            /*ModelEntities db = new ModelEntities();
            ViewModel.PessoaViewModel pessoaVM = null;

            if (id > 0)
            {
                ServiceLayer.DomainModel.Pessoa pessoaDb = (await db.Pessoas.FirstOrDefaultAsync(x => x.cod == id));

                pessoaVM = new ViewModel.PessoaViewModel
                {
                    Cod = pessoaDb.cod,
                    Age = pessoaDb.age,
                    Name = pessoaDb.name,
                    Pais = pessoaDb.pais,
                    PhotoName = pessoaDb.photo_name
                };
            }

            return View(pessoaVM);*/

            return Content("PessoaOldGet");

        }

        [Route("PessoaOld/")]
        [HttpPost]
        public async Task<ActionResult> PessoaDetail([Bind(Exclude = "PhotoName")] ViewModel.PessoaViewModel pessoaVM)
        {
            /*ModelEntities db = new ModelEntities();
            ServiceLayer.DomainModel.Pessoa pessoaDb = null;

            if (pessoaVM.Cod > 0)
            {
                pessoaDb = (await db.Pessoas.FirstOrDefaultAsync(x => x.cod == pessoaVM.Cod));                
            }
            else
            {
                pessoaDb = new ServiceLayer.DomainModel.Pessoa();
            }
            pessoaDb.age = pessoaVM.Age;
            pessoaDb.name = pessoaVM.Name;
            pessoaDb.pais = pessoaVM.Pais;
            if (((pessoaVM.Photo?.ContentLength)??0) > 0)
            {
                pessoaDb.photo_name = pessoaVM.Photo.FileName;
            }
            if (pessoaDb.cod == 0)
            {
                db.Pessoas.Add(pessoaDb);
            }

            await db.SaveChangesAsync();

            return RedirectToAction("ListPessoas");*/
            return Content("PessoaOldPost");
        }

    }
}