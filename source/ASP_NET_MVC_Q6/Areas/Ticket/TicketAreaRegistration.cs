using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Ticket
{
    public class TicketAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Ticket";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Ticket_default",
                "Ticket/{action}",
                new { area = "Ticket", controller = "Main",action="List" }
        
            );
            context.MapRoute(
              "Ticket_default2",
              "Ticket/{action}/{id}",
              new { area = "Ticket", controller = "Main", action = "Detail", id = UrlParameter.Optional }
              //constraints: new { Controller = "Ticket", controller = "Main", action = "Detail"}
          );
        }
    }
}