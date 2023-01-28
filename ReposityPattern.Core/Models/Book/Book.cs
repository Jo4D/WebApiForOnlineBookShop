namespace RepositoryPattern.Core
{
    public class Book
    {
        public int BookId { set; get; }
        public string Title { set; get; }
        public string Category { set; get; }
        public string Description { set; get; }
        public double Rate { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime ModifiedAt { set; get; }
        public double Price { set; get; }
        public byte[] Image { set; get; }
        public int DiscountId { set; get; }
        public virtual Discount Discount { set; get; }
        public int AuthorId { set; get; }
        public virtual Author Author { set; get; }
        public int PublishingCompanyId { set; get; }
        public virtual PublishingCompany PublishingCompany { set; get; }
        public int WharehouseId { set; get; }
        public virtual Wharehouse Wharehouse { set; get; }
        public virtual CaretItem CaretItem { set; get; }
        public virtual OrderItem OrderItem { set; get; }
    }
}
