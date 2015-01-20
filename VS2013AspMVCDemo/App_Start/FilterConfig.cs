using System.Web;
using System.Web.Mvc;

namespace VS2013AspMVCDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
