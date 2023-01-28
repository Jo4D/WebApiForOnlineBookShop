using System.ComponentModel.DataAnnotations;
namespace BookStoreWithRepositoryPattern.Api
{
    public class SignInCreateModel
    {
        public string UserName { get; set; }
        [Required]
        [MaxLength(16), MinLength(8)]
        [Display(Name = "Password"), DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}
