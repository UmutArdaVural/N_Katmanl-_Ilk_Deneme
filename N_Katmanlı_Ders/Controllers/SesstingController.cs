using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using N_Katmanlı_Ders.Models;

namespace N_Katmanlı_Ders.Controllers
{
    public class SesstingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;


        public SesstingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }



        [HttpGet]
        public  async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            
            userEditViewModel.Name = values.AppUserName;
            userEditViewModel.SurName = values.AppUserSurName ;
            userEditViewModel.Email = values.Email;
            userEditViewModel.Gender = values.Email;


            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel D )
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
                
            user.AppUserName = D.Name;
            user.AppUserSurName = D.SurName;
            user.Email=D.Email;
            user.Gender = D.Gender;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,D.Password);
            var results = await _userManager.UpdateAsync(user);

            if (results.Succeeded) 
            {
                return RedirectToAction("Index","Product");
            
            }
            return View();

        }

      


    }
}
