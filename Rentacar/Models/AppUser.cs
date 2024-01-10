using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace Rentacar.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
