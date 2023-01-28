using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core;

namespace BookStoreWithRepositoryPattern.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IUnitOfWork uk;
        public AuthorsController(IUnitOfWork _uk)
        {
            uk = _uk;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var author = await uk.Authors.GetAll();
            return Ok(author);
        }
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var author = await uk.Authors.GetById(id);
            return Ok(author);
        }
        [HttpPost]
        public async Task<IActionResult> AddAuthor([FromBody] AuthorCreateModel model)
        {
            var Author = new Author
            {
                Name = model.Name
            };
            return Ok(uk.Authors.Add(Author));
        }
        [HttpPut(template: ("{id}"))]
        public async Task<IActionResult> UpdateAuthor(int id,[FromBody] AuthorCreateModel model)
        {
            var Author = new Author
            {
                Name = model.Name
            };
            return Ok(uk.Authors.Update(Author));

            
        }
        [HttpDelete(template: ("{id}"))]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            
            var Aurhor = await uk.Authors.GetById(id);

            return Ok(uk.Authors.Delete(Aurhor));
        }
    }
}
