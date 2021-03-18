using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
               
                IdentityUser user = new IdentityUser{ UserName = model.Email, Email = model.Email};

                var result = await _userManager.CreateAsync(user,model.Password);

                if(result.Succeeded)
                {
                   await _signInManager.SignInAsync(user,false,null);
                   return RedirectToAction("Index","Home");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
            }
            return View(model);
        }

        private string GenerateUserName(string FirstName, string LastName)
        {
            return FirstName.Trim().ToUpper()+""+ LastName.Trim().ToLower();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
           return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AccountLoginViewModel model)
        {
            if(ModelState.IsValid)
            {
              var result = await  _signInManager.PasswordSignInAsync(model.Email,model.Password,model.Remember,false);
              if(result.Succeeded)
              {
                  return RedirectToAction("Index", "Home");
              }  
              ModelState.AddModelError(string.Empty,"Invalid Login Attempt");
            }
           return View(model);
        }
    }
}