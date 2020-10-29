using System.Web;
using System.Web.Mvc;

namespace Gen_Repo_Pattern
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
