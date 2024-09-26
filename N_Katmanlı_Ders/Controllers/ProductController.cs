using BussinessLayer.Concrete;
using BussinessLayer.FluentValidation;
using DataAccesLayer.EntityFrameWork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace N_Katmanlı_Ders.Controllers
{
    public class ProductController : Controller
    {
        ProductManeger productManeger = new ProductManeger(new EfProductlDal());
        public IActionResult Index()
        {
            var values = productManeger.TGetList();
            return View(values);
        }

        [HttpGet]   
        public IActionResult AddProduct()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p) 
        {  
            ProductValidator validationRules = new ProductValidator();
            ValidationResult results = validationRules.Validate(p);
             if (results.IsValid) {
                 productManeger.TInsert(p);
                 return RedirectToAction("Index");
             }
             else
             {
                 foreach (var item in results.Errors)
                 {
                     ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                 }
             }
            return View();
        }


        public IActionResult DeleteProduct(int id) 
        {

            var value  = productManeger.TGetById(id);
            productManeger.TDelete(value);
            return RedirectToAction("Index");

        }
        


        [HttpGet]
        public IActionResult UptadeProduct(int id )
        {
            var value = productManeger.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UptadeProduct(Product p )
        {
            productManeger.TUpdate(p);
            return RedirectToAction("Index");
        }


    }
}
