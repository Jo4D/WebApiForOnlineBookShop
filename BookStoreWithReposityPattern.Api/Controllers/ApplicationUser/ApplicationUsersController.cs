using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RepositoryPattern.Core;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookStoreWithRepositoryPattern.Api
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ApplicationUsersController : ControllerBase
    {
        private readonly IUnitOfWork uk;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public ApplicationUsersController(
            IUnitOfWork _uk,
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager
            )
        {
            uk = _uk;
            userManager = _userManager;
            signInManager = _signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(ApplicationUserCreateModel model)
        {
            model.Role = "Admin";
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
                var user = new ApplicationUser()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email
                };
                IdentityResult result
                      = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded == false)
                {
                    result.Errors.ToList().ForEach(i =>
                    {
                        ModelState.AddModelError("", i.Description);
                    });
                    myModel.Success = false;
                    myModel.Data =
                        ModelState.Values.SelectMany
                                (i => i.Errors.Select(x => x.ErrorMessage));
                }
                else
                {
                    await userManager.AddToRoleAsync(user, model.Role);
                    myModel.Success = true;
                    myModel.Message = "successful sign up";
                    myModel.Data = null;
                }
            }
            return Ok(myModel);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn([FromBody] SignInCreateModel model)
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
                var result
                     = await signInManager.PasswordSignInAsync
                        (model.UserName, model.Password, model.RememberMe,
                             true);
                var user1 = await userManager.FindByNameAsync(model.UserName);

                if (user1 is null || !await userManager.CheckPasswordAsync(user1, model.Password))
                {
                    myModel.Success = false;
                    myModel.Message = "Invalid UserName Or Password .";
                }
                else if (result.IsNotAllowed == true)
                {
                    myModel.Success = false;
                    myModel.Message = "Invalid UserName Or Password ";
                }
                else if (result.IsLockedOut)
                {
                    myModel.Success = false;
                    myModel.Message = "Is Locked Out";
                }


                else
                {
                    var user = await userManager.FindByNameAsync(model.UserName);
                    List<Claim> claims = new List<Claim>();
                    var roles = await userManager.GetRolesAsync(user);
                    roles.ToList().ForEach(i =>
                    {
                        claims.Add(new Claim(ClaimTypes.Role, i));
                    });

                    JwtSecurityToken token
                        = new JwtSecurityToken
                        (
                            signingCredentials:
                             new SigningCredentials
                             (
                                 new SymmetricSecurityKey(Encoding.ASCII.GetBytes("IOLJYHSDSIoleJHsdsdsas98WeWsdsdQweweHgsgdf_&6#2"))
                                 ,
                                 SecurityAlgorithms.HmacSha256
                             ),
                            expires: DateTime.Now.AddDays(5),
                            claims: claims
                        );

                    string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                    myModel.Success = true;
                    myModel.Message = "Successfulyy Loged In";
                    myModel.Data = new
                    {
                        User = user,
                        Toekn = tokenValue,
                        Roles = roles
                    };
                }
            }
            return Ok(myModel);
        }
    }
}
