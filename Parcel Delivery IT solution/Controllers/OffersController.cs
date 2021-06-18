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
        public List<Route> Get(string from, string to, int height, int length, int width, int weight, string date)
        {
            List<Route> RouteList = new List<Route>();

            int from2 = 1;
            int to2 = 3;

            if (weight > 100000)
            {
                return RouteList;
            }

            GFG t = new GFG();
            int time = t.shortestPathTime(from2, to2);
            int price = t.shortestPathPrice(from2, to2);

            Route route = new Route();
            route.Time = time;
            route.Price = price;

            // Create a Map object
           
            RouteList.Add(route);
            return RouteList;
        }
    }
}
