using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using N_Katmanlı_Ders.Models;

namespace N_Katmanlı_Ders.Controllers
{
    public class Resgister_Controller : Controller
    {   
        private readonly UserManager<AppUser> _userManager;

        public Resgister_Controller(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> Index(UserRegisterVievModel models) 
        {
            AppUser _user = new AppUser();
            {
                _user.AppUserName = models.Name;
                _user.AppUserSurName = models.SurName;
                _user.UserName = models.UserName;
                _user.Email = models.Email;
                _user.Gender = models.Gender;

            };
            if (models.Password == models.ConfirmPassword)
            {
                var results = await _userManager.CreateAsync(_user, models.Password);


                if (results.Succeeded)
                {
                    return RedirectToAction("Index", "Login");

                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }

            return View(models);

        }



    }
}
