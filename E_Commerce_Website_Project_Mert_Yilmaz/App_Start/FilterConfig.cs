using System.Web;
using System.Web.Mvc;

namespace E_Commerce_Website_Project_Mert_Yilmaz
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
