using Microsoft.AspNetCore.Identity;

namespace RepositoryPattern.Core
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ShoppingSession ShoppingSession { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
