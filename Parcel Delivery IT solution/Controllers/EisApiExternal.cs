
using Microsoft.AspNetCore.Mvc;
using System;

namespace Parcel_Delivery_IT_solution.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class EisExternalController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public EisExternalController() { }

        [System.Web.Mvc.HttpGet]
        public string Get(string CityFrom, string CityTo, int Weight)
        {
            string jsonString;
            int price;
            int time;
            if (Weight > 100000)
            {
                return jsonString = "{'Weight above 100 kgs':" + 0 + ", '':" + 0 + "}";
            }
            if (CityFrom == "Amatave" & CityTo == "Kap Guardafui")
            {
                price = 8 * 5;
                time = 8 * 12;
            }
            else if (CityFrom == "Cairo" & CityTo == "Suakin")
            {
                price = 4 * 5;
                time = 4 * 5;
            }
            jsonString = "{'Price':" +  + ", 'Time':" +  + "}";
            return jsonString;
        }
    }
}


