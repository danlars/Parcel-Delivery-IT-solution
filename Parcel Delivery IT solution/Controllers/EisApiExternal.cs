
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
                return jsonString = "{'Price':" + "invalid" + ", 'Time':" + "invalid" + "}";
            }
            if (CityFrom == "Amatave" & CityTo == "Kap Guardafui")
            {
                price = 8 * 5;
                time = 8 * 12;
            }
            else if (CityFrom == "Cairo" & CityTo == "Suakin")
            {
                price = 4 * 5;
                time = 4 * 12;
            }
            else if (CityFrom == "Cairo" & CityTo == "Tunis")
            {
                price = 5 * 5;
                time = 5 * 12;
            }
            else if (CityFrom == "Dakar" & CityTo == "De Kanariske Øer")
            {
                price = 5 * 5;
                time = 5 * 12;
            }
            else if (CityFrom == "Dakar" & CityTo == "Sierre Leone")
            {
                price = 3 * 5;
                time = 3 * 12;
            }
            else if (CityFrom == "Dakar" & CityTo == "St. Helena")
            {
                price = 10 * 5;
                time = 10 * 12;
            }
            else if (CityFrom == "De Kanariske Øer" & CityTo == "Dakar")
            {
                price = 5 * 5;
                time = 5 * 12;
            }
            else if (CityFrom == "De Kanariske Øer" & CityTo == "Timbuktu")
            {
                price = 3 * 5;
                time = 3 * 12;
            }
            else if (CityFrom == "Guldkysten" & CityTo == "Hvalbugten")
            {
                price = 11 * 5;
                time = 11 * 12;
            }
            else if (CityFrom == "Guldkysten" & CityTo == "Sierre Leone")
            {
                price = 4 * 5;
                time = 4 * 12;
            }
            else if (CityFrom == "Guldkysten" & CityTo == "Slavekysten")
            {
                price = 4 * 5;
                time = 4 * 12;
            }
            else if (CityFrom == "Hvalbugten" & CityTo == "Guldkysten")
            {
                price = 11 * 5;
                time = 11 * 12;
            }
            else if (CityFrom == "Hvalbugten" & CityTo == "Kapstaden")
            {
                price = 3 * 5;
                time = 3 * 12;
            }
            else if (CityFrom == "Hvalbugten" & CityTo == "Slavekysten")
            {
                price = 9 * 5;
                time = 9 * 12;
            }
            else if (CityFrom == "Hvalbugten" & CityTo == "St. Helena")
            {
                price = 10 * 5;
                time = 10 * 12;
            }
            else if (CityFrom == "Kap Guardafui" & CityTo == "Amatave")
            {
                price = 8 * 5;
                time = 8 * 12;
            }
            else if (CityFrom == "Kap Guardafui" & CityTo == "Omdurman")
            {
                price = 8 * 5;
                time = 8 * 12;
            }
            else if (CityFrom == "Kap Guardafui" & CityTo == "Suakin")
            {
                price = 4 * 5;
                time = 4 * 12;
            }
            else if (CityFrom == "Kap St Marie" & CityTo == "Kapstaden")
            {
                price = 8 * 5;
                time = 8 * 12;
            }
            else if (CityFrom == "Kap St Marie" & CityTo == "Mocamique")
            {
                price = 3 * 5;
                time = 3 * 12;
            }
            else if (CityFrom == "Kapstaden" & CityTo == "Hvalbugten")
            {
                price = 3 * 5;
                time = 3 * 12;
            }
            else if (CityFrom == "Kapstaden" & CityTo == "Kap St Marie")
            {
                price = 8 * 5;
                time = 8 * 12;
            }
            else if (CityFrom == "Kapstaden" & CityTo == "St Helena")
            {
                price = 9 * 5;
                time = 9 * 12;
            }
            else if (CityFrom == "Mocamique" & CityTo == "Kap Guardafui")
            {
                price = 8 * 5;
                time = 8 * 12;
            }
            else if (CityFrom == "Mocamique" & CityTo == "Kap St Marie")
            {
                price = 3 * 5;
                time = 3 * 12;
            }
            else if (CityFrom == "Sierre Leone" & CityTo == "Dakar")
            {
                price = 3 * 5;
                time = 3 * 12;
            }
            else if (CityFrom == "Sierre Leone" & CityTo == "Guldkysten")
            {
                price = 4 * 5;
                time = 4 * 12;
            }
            else if (CityFrom == "Sierre Leone" & CityTo == "St. Helena")
            {
                price = 11 * 5;
                time = 11 * 12;
            }
            else if (CityFrom == "Slavekysten" & CityTo == "Guldkysten")
            {
                price = 4 * 5;
                time = 4 * 12;
            }
            else if (CityFrom == "Slavekysten" & CityTo == "Hvalbugten")
            {
                price = 9 * 5;
                time = 9 * 12;
            }
            else if (CityFrom == "St. Helena" & CityTo == "Dakar")
            {
                price = 10 * 5;
                time = 10 * 12;
            }
            else if (CityFrom == "St. Helena" & CityTo == "Hvalbugten")
            {
                price = 10*5;
                time = 10*12;
            }
            else if (CityFrom == "St. Helena" & CityTo == "Kapstaden")
            {
                price = 9*5;
                time = 9*12;
            }
            else if (CityFrom == "St. Helena" & CityTo == "Sierre Leone")
            {
                price = 11*5;
                time = 11*12;
            }
            else if (CityFrom == "Suakin" & CityTo == "Cairo")
            {
                price =  4* 5;
                time = 4 * 12;
            }
            else if (CityFrom == "Suakin" & CityTo == "Kap Guardafui")
            {
                price = 4 * 5;
                time = 4 * 12;
            }
            else if (CityFrom == "Tanger" & CityTo == "De Kanariske Øer")
            {
                price = 3*5;
                time = 3*12;
            }
            else if (CityFrom == "Tanger" & CityTo == "Tunis")
            {
                price = 3*5;
                time = 3*12;
            }
            else if (CityFrom == "Tunis" & CityTo == "Cairo")
            {
                price = 5* 5;
                time =  5* 12;
            }
            else if (CityFrom == "Tunis" & CityTo == "Tanger")
            {
                price =3 *5;
                time = 3*12;
            }
            else
            {
                return jsonString = "{'Price':" + "invalid" + ", 'Time':" + "invalid" + "}";
            }
            jsonString = "{'Price':" + price + ", 'Time':" + time + "}";
            return jsonString;
        }
    }
}


