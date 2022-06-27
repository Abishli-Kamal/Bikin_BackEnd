using Bikin_Back_End.DAL;
using Microsoft.AspNetCore.Identity;

namespace Bikin_Back_End.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
