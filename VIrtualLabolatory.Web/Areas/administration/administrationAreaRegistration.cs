using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.administration
{
    public class administrationAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "administration_default",
                "administration/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
