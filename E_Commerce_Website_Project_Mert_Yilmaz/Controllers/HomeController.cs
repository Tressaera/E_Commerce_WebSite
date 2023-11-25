using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Commerce_Website_Project_Mert_Yilmaz.Models;

namespace E_Commerce_Website_Project_Mert_Yilmaz.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            //Burada birden fazla listeleme yaptık.
            ViewModel model = new ViewModel();
            model.ProductsList=db.Products.ToList();
            model.CategoriesList=db.Categories.ToList();
            model.CustomersList=db.Customers.ToList();
            return View(model);
        }
    }
}