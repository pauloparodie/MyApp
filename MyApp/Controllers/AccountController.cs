using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.ViewModel;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using MyApp.IdentityProvider;
using MyApp.ViewModel.Identity;
using System.Security.Claims;
using MyApp.IdentityProvider.Model;
using System.Threading.Tasks;



namespace MyApp.Controllers
{
    public class AccountController : Controller
    {
        IdentityManager _identityManager;

        public AccountController()
        {
            _identityManager = new IdentityManager();
        }

        [Route("Register")]
        public ActionResult Register()
        {
            return View();
        }


        [Route("Register")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            ApplicationUser applicationUser = (ApplicationUser)AutoMapperHelper.MapStatic(registerVM, typeof(ApplicationUser));
            try
            {
                ClaimsIdentity userIdentity = await _identityManager.CreateUserAsync(applicationUser);
                if (userIdentity != null)
                {
                    Owin.OwinManager.SignInUser(userIdentity, HttpContext.GetOwinContext());
                    return RedirectToAction("ListPessoas", "MyApp");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("ErrCreateUser", ex.Message ?? "Error creating user");

            }

            return View(registerVM);
        }


        [Route("Login")]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }


        [Route("Login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
            {

                return View(loginVM);
            }

            ClaimsIdentity userIdentity = await _identityManager.FindUserAsync(loginVM.Username, loginVM.Password);
            if (userIdentity != null)
            {
                Owin.OwinManager.SignInUser(userIdentity, HttpContext.GetOwinContext());
                return RedirectToAction("ListPessoas", "MyApp");
            }

            ModelState.AddModelError("ErrInvalidLogin", "Invalid username or password");
            return View(loginVM);
        }

        [Route("Logout")]
        public ActionResult Logout()
        {
            Owin.OwinManager.SignOutUser(HttpContext.GetOwinContext());

            return RedirectToAction("ListPessoas", "MyApp");
        }


        private bool disposedValue = false; // To detect redundant calls
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _identityManager.Dispose();
                }
                disposedValue = true;
            }
        }
    }
}