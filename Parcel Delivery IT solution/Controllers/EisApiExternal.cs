
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
            string jsonString = "{'Price':" + CityFrom + ", 'Time':" + 2;
            return jsonString;
        }
    }
}


