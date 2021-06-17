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
        public List<Route> Get(string from, string to, int height, int length, int width)
        {
            // Package package
            //Package package = new Package(from, to, height, length, width);

            /*
             public string from { get; set; }

            public string to { get; set; }

            public string weight { get; set; }

            public string height { get; set; }

            public string length { get; set; }

            public string width { get; set; }
            */

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
