using System.ComponentModel.DataAnnotations;

namespace BookStoreWithRepositoryPattern.Api
{
    public class AuthorCreateModel
    {
        
        [Required]
        public string Name { get; set; }
    }
}
