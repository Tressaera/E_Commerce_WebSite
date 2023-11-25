using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_Website_Project_Mert_Yilmaz.Models;

namespace E_Commerce_Website_Project_Mert_Yilmaz
{
    public class ViewModel
    {
        public List<Products> ProductsList { get; set; }
        public List<Categories> CategoriesList { get; set; }
        public List<Customers> CustomersList { get; set; }
    }
}