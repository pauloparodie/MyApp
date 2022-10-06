using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.IdentityProvider.Model;
using MyApp.IdentityProvider.DataAccess;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Helpers;


namespace MyApp.IdentityProvider
{
    public class IdentityManager : IDisposable
    {
        ApplicationDbContext _ctx;

        public IdentityManager()
        {
            _ctx = new ApplicationDbContext();
        }

        public async Task<ClaimsIdentity> CreateUserAsync(ApplicationUser user)
        {
            var userManager = new ApplicationUserManager(new ApplicationUserStore(_ctx));
            user.PasswordHash = Crypto.HashPassword(user.PasswordHash);
            var res1 = await userManager.CreateAsync(user);
            if (!res1.Succeeded)
            {
                throw new Exception(res1.Errors.FirstOrDefault());
            }
            var res2 = await userManager.AddToRoleAsync(user.Id, "User");
            if (!res2.Succeeded)
            {
                throw new Exception(res2.Errors.FirstOrDefault());

            }
            return userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
        }

        public async Task<ClaimsIdentity> FindUserAsync(string userName, string password)
        {
            var userManager = new ApplicationUserManager(new ApplicationUserStore(_ctx));
            var user = await userManager.FindAsync(userName, password);
            return user == null ? null : userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
        }

        public async Task creatInitialUsersRolesAsync()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_ctx));
            var userManager = new ApplicationUserManager(new ApplicationUserStore(_ctx));

            if (!(await roleManager.RoleExistsAsync("Admin")))
            {
                var role = new IdentityRole("Admin");
                if ((await roleManager.CreateAsync(role)).Succeeded)
                {
                    if (((await userManager.FindByNameAsync("Admin"))) == null)
                    {
                        var user = new ApplicationUser
                        {
                            UserName = "admin",
                            Email = "admin@admin.pt",
                            PasswordHash = Crypto.HashPassword("12345678"),
                            Pet = "Pacheco"
                        };
                        if ((await userManager.CreateAsync(user)).Succeeded)
                        {
                            if (!(await userManager.AddToRoleAsync(user.Id, "Admin")).Succeeded)
                            {
                                throw new Exception("Error associating Admin Role");
                            }
                        }
                        else
                        {
                            throw new Exception("Error creating Admin User");
                        }
                    }
                }
                else
                {
                    throw new Exception("Error creating Admin Role");
                }
            }

            if (!(await roleManager.RoleExistsAsync("User")))
            {
                var role = new IdentityRole("User");
                if (!(await roleManager.CreateAsync(role)).Succeeded)
                {
                    throw new Exception("Error creating User Role");
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposedValue = false; // To detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _ctx.Dispose();
                }
                disposedValue = true;
            }
        }
    }
}
