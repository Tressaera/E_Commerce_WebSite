using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Commerce_Website_Project_Mert_Yilmaz.Models;

namespace E_Commerce_Website_Project_Mert_Yilmaz.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            var hakkim = db.About.ToList();
            return View(hakkim);
        }
    }
}