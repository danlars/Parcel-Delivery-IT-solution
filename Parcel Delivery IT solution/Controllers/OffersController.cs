using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Parcel_Delivery_IT_solution.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class OffersController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public OffersController(){}

        [System.Web.Mvc.HttpGet]
        public List<Route> Get()
        {
            
            // TODO: Call the business logic returning the route
            
            Route routeCheapest = new Route()
            {
                RouteType = "Cheapest",
                Price = 10,
                Time = 15
            };

            Route routeFast = new Route()
            {
                RouteType = "Fastest",
                Price = 14,
                Time = 9
            };

            List<Route> RouteList = new List<Route>();
            RouteList.Add(routeCheapest);
            RouteList.Add(routeFast);
            return RouteList;
        }
    }
}
