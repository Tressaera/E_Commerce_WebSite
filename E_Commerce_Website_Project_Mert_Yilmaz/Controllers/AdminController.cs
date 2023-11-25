using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using E_Commerce_Website_Project_Mert_Yilmaz.Models;

namespace E_Commerce_Website_Project_Mert_Yilmaz.Controllers
{
    public class AdminController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var admin=db.Admin.FirstOrDefault(x => x.KullaniciAdi== ad.KullaniciAdi && x.Sifre ==ad.Sifre);
            if (admin != null)
            {
                FormsAuthentication.SetAuthCookie(ad.KullaniciAdi, false);
                Session["kullanici"] = ad.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
            return View();
            }         
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            return View();
        }
    }
}