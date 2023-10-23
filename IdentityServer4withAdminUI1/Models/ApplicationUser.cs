using Microsoft.AspNetCore.Identity;

namespace IdentityServer4withAdminUI1.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public bool IsBlocked { get; set; }
        public bool IsDeleted { get; set; }
    }
}