using BussinessLayer.Concrete;
using BussinessLayer.FluentValidation;
using DataAccesLayer.EntityFrameWork;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace N_Katmanlı_Ders.Controllers
{
    public class CustomerController1 : Controller
    {
        CustomerManeger customerManeger = new CustomerManeger(new EfCustomerDal());
        public IActionResult Index()
        {
            var values = customerManeger.GetCustomersListWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            JobManeger JobManeger = new JobManeger(new EfJobsDal());
            List<SelectListItem> values =( from x in JobManeger.TGetList()
                                          select new SelectListItem
                                          {
                                              Text = x.Name,
                                              Value = x.JobId.ToString()
                                          }).ToList();

            ViewBag.v=values;
            return View();

        }

        [HttpPost]
        public IActionResult AddCustomer(Customer p) 
        {
            CustomerValidator validationRules = new CustomerValidator();
            ValidationResult results = validationRules.Validate(p);
         
           
            if (results.IsValid)
            {
                customerManeger.TInsert(p);
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


        public IActionResult DeleteCustomer(int id )
        {
            var values = customerManeger.TGetById(id);
            customerManeger.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UptadeCustomer(int id)
        {
            JobManeger JobManeger = new JobManeger(new EfJobsDal());
            List<SelectListItem> values = (from x in JobManeger.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobId.ToString()
                                           }).ToList();

            ViewBag.v = values;
            var value = customerManeger.TGetById(id);
            return View(value);


        }
        [HttpPost]
        public IActionResult UptadeCustomer(Customer p)
        {

            customerManeger.TUpdate(p);
            return RedirectToAction("Index");
        }


    }
}
