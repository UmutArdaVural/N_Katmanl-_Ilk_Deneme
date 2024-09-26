using BussinessLayer.Concrete;
using BussinessLayer.FluentValidation;
using DataAccesLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

namespace N_Katmanlı_Ders.Controllers
{
    public class JobController : Controller
    {
        JobManeger JobManeger = new JobManeger(new EfJobsDal());
        public IActionResult Index()
        {
            var values = JobManeger.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            JobValidator validationRules = new JobValidator();
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                JobManeger.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


        public IActionResult DeleteJob(int id)
        {

            var value = JobManeger.TGetById(id);
            JobManeger.TDelete(value);
            return RedirectToAction("Index");

        }



        [HttpGet]
        public IActionResult UptadeJob(int id)
        {
            var value = JobManeger.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UptadeJob(Job p)
        {
            JobManeger.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
