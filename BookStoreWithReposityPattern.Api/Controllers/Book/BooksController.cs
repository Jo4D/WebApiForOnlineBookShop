using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core;

namespace BookStoreWithRepositoryPattern.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork uk;
        private new List<string> AllowedExten = new List<string> { ".jpg", ".png" };
        private long MaxFileSize = 1048576;
        public BooksController(IUnitOfWork _uk)
        {
            uk = _uk;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var book = await uk.Books.GetAll();
            return Ok(book);
        }
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await uk.Books.GetById(id);
            return Ok(book);
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromForm] BookCreateModel model)
        {
            if (!AllowedExten.Contains(Path.GetExtension(model.Image.FileName).ToLower()))
            {
                return BadRequest("only .jpg and .png extensions are allowed..");
            }
            if (model.Image.Length>MaxFileSize)
            {
                return BadRequest("The file is too big..please choose smaller one");
            }
            var datastream = new MemoryStream();
            await model.Image.CopyToAsync(datastream);

            var _Book = new Book
            {
                Title = model.Title,
                Description = model.Description,
                Category = model.Category,
                Price = model.Price,
                Rate = model.Rate,
                CreatedAt = model.CreatedAt,
                ModifiedAt = model.ModifiedAt,
                Image = datastream.ToArray(),
                PublishingCompanyId = model.PublishingCompanyId,
                WharehouseId =model.WharehouseId,
                AuthorId= model.AuthorId,
                DiscountId = model.DiscountId


                
            };
            return Ok(uk.Books.Add(_Book));
        }
        [HttpPut(template: ("{id}"))]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] BookCreateModel model)
        {

            if (!AllowedExten.Contains(Path.GetExtension(model.Image.FileName).ToLower()))
            {
                return BadRequest("only .jpg and .png extensions are allowed..");
            }
            if (model.Image.Length > MaxFileSize)
            {
                return BadRequest("The file is too big..please choose smaller one");
            }
            var datastream = new MemoryStream();
            await model.Image.CopyToAsync(datastream);

            var Book = new Book
            {
                Title = model.Title,
                Description = model.Description,
                Category = model.Category,
                Price = model.Price,
                Rate = model.Rate,
                CreatedAt = model.CreatedAt,
                ModifiedAt = model.ModifiedAt,
                Image = datastream.ToArray(),
                PublishingCompanyId = model.PublishingCompanyId,
                WharehouseId = model.WharehouseId,
                AuthorId = model.AuthorId,
                DiscountId = model.DiscountId
            };


            return Ok(uk.Books.Update(Book));
        }
        [HttpDelete(template: ("{id}"))]
        public async Task<IActionResult> DeleteBook(int id)
        {

            var Book = await uk.Books.GetById(id);

            return Ok(uk.Books.Delete(Book));
        }
    }
}
