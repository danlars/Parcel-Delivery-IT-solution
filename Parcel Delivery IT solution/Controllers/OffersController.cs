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


            Map map = new Map("os");

            Route routeFast = map.getFastestRoute();
            Route routeCheapest = map.getCheapestRoute();

            // TODO: Call the business logic returning the route

            // Create a Map object
            

            List<Route> RouteList = new List<Route>();
            RouteList.Add(routeCheapest);
            RouteList.Add(routeFast);
            return RouteList;
        }
    }
}
