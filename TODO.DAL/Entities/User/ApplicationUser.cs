using Microsoft.AspNetCore.Identity;

namespace TODO.DAL.Entities.User
{
    public class ApplicationUser : IdentityUser
    {
        public string? Image { get; set; }

    }
}
