using System.ComponentModel.DataAnnotations;

namespace BookStoreWithRepositoryPattern.Api
{
    public class RoleCreateModel
    {

        public string Id { get; set; }

        [Required, MaxLength(15), MinLength(3)]
        public string Name { get; set; }
    }
}
