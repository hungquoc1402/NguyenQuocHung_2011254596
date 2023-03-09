using System.Web;
using System.Web.Mvc;

namespace NguyenQuocHung_2011254596
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
