using Microsoft.AspNetCore.Identity;

namespace TestOwnedTypes.Data
{
    public class AppUser : IdentityUser
    {
        public virtual Address Address { get; set; }
    }
}
