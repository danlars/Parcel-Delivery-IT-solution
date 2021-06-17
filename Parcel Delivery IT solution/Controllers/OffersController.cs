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
        public List<Route> Get(Package package)
        {
            // Return the best routes


            Map map = new Map(package);

            Route routeFast = map.getFastestRoute();
            Route routeCheapest = map.getCheapestRoute();

            // TODO: Call the business logic returning the route

            // Create a Map object
            

            
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
