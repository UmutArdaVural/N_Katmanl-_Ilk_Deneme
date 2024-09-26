using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using N_Katmanlı_Ders.Models;

namespace N_Katmanlı_Ders.Controllers
{
    public class LoginController : Controller
    {   
        private readonly  SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
             _signInManager = signInManager;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        // lockaotend hatalı şifre girişi durumunda kullanıcıın ne zamana kadar sistemden banlandığı süre defolt degeri 5dk
        // lockoutenable kullanıcı sistemde banlımı değilmi 
        // accesfaild count kullanııcın hatalı şifre girişinde count değerini bir attırır defolt degeri 5 

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginVievModel p)
        {
            if (ModelState.IsValid) { 
            
                    var results =await _signInManager.PasswordSignInAsync(p.UserName, p.Password,false,true);

                if (results.Succeeded) { 
                return RedirectToAction("Index","Product");
                }
                else
                {
                    ModelState.AddModelError("", "HATA");
                }
            }

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Login");

        }



    }
}
