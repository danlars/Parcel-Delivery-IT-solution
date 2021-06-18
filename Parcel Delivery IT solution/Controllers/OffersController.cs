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

            Dictionary<string, int> dict = getDictionary();

            int fromInt = dict[from];
            int toInt = dict[to];

            if (weight > 100000)
            {
                return RouteList;
            }

            GFG t = new GFG();
            int time = t.shortestPathTime(fromInt, toInt);
            int price = t.shortestPathPrice(fromInt, toInt);

            Route route = new Route();
            route.Time = time;
            route.Price = price;

            // Create a Map object
           
            RouteList.Add(route);
            return RouteList;
        }

        private Dictionary<string, int> getDictionary()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("Addis Abeba", 1);
            dict.Add("Amatave", 2);
            dict.Add("Bahrel Ghazal", 3);
            dict.Add("Cairo", 4);
            dict.Add("Congo", 5);
            dict.Add("Dakar", 6);
            dict.Add("Darfur", 7);
            dict.Add("De Kanariske Oeer", 8);
            dict.Add("Dragebjerget", 9);
            dict.Add("Guldkysten", 10);
            dict.Add("Hvalbugten", 11);
            dict.Add("Kabalo", 12);
            dict.Add("Kap Guardafui", 13);
            dict.Add("Kap St Marie", 14);
            dict.Add("Kapstaden", 15);
            dict.Add("Luanda", 16);
            dict.Add("Marrakesh", 17);
            dict.Add("Mocamique", 18);
            dict.Add("Omdurman", 19);
            dict.Add("Sahara", 20);
            dict.Add("Sierra Leone", 21);
            dict.Add("Slavekysten", 22);
            dict.Add("St. Helena", 23);
            dict.Add("Suakin", 24);
            dict.Add("Tanger", 25);
            dict.Add("Timbuktu", 26);
            dict.Add("Tripoli", 27);
            dict.Add("Tunis", 28);
            dict.Add("Victoriafaldene", 29);
            dict.Add("Victoriasoeen", 30);
            dict.Add("Wadai", 31);
            dict.Add("Zanzibar", 32);

            return dict;
        }
    }
}
