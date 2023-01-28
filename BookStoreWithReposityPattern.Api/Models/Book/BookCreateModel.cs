using RepositoryPattern.Core;
using System.ComponentModel.DataAnnotations;

namespace BookStoreWithRepositoryPattern.Api
{
    public class BookCreateModel
    {
        [Required]
        public string Title { set; get; }
        [Required]
        public string Category { set; get; }
        [Required]
        public string Description { set; get; }
        [Required]
        public double Rate { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime ModifiedAt { set; get; }
        [Required]
        public double Price { set; get; }
        [Required]
        public IFormFile Image { set; get; }
       
        public int DiscountId { set; get; }
        [Required]
        public int AuthorId { set; get; }
        [Required]
        public int PublishingCompanyId { set; get; }
        [Required]
        public int WharehouseId { set; get; }
    
    }
}
