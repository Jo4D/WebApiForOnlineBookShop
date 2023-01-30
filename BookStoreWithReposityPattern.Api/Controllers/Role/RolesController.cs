using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreWithRepositoryPattern.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        RoleManager<IdentityRole> RoleManager;
        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            RoleManager = roleManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleCreateModel model)
        {
            ResultViewModel myModel = new ResultViewModel();
            if (ModelState.IsValid == false)
            {
                myModel.Success = false;
                myModel.Data =
                    ModelState.Values.SelectMany
                            (i => i.Errors.Select(x => x.ErrorMessage));
            }
            else
            {
                var result =
                await RoleManager.CreateAsync(
                    new IdentityRole
                    {
                        Name = model.Name
                    });
                if (result.Succeeded == false)
                {
                    result.Errors.ToList().ForEach(i =>
                    {
                        ModelState.AddModelError("", i.Description);
                    });
                    
                }
                else
                {
                }

            }
            return Ok("Role Has Been Created Successfully");

        }
    }
}
