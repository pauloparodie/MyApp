using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyApp.IdentityProvider.Model
{

    public class ApplicationUser : IdentityUser
    {
        public string Pet { get; set; }

        public string FootballTeam { get; set; }
    }

    
}