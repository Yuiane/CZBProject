using System.Web.Mvc;

namespace CZB.Web.Areas.Adm1n_L0g1n
{
    public class Adm1n_L0g1nAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Adm1n_L0g1n";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Adm1n_L0g1n_default",
                "Adm1n_L0g1n/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}