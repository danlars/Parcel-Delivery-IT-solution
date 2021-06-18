using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Parcel_Delivery_IT_solution.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class PackageController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public PackageController(){}

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Boolean InsertPackage(int customerId, string email, string name, string telephoneNumber, int price, int time, int height, int length, int width, string cityFrom, string cityTo, string date)
        {// int, string, string, string, int, int, int, int, int, string, string, string
            Order order = new Order();
            order.CustomerId = 1;
            order.Email = "adsf@mail.com";
            order.Name = "asdf";
            order.TelephoneNumber = "asdf";
            order.Price = 12;
            order.Time = 12;
            order.Height = 12;
            order.Length = 12;
            order.Width = 12;
            order.CityFrom = "Kapstaden";
            order.CityTo = "Hvalbugten";
            order.Date = "01/01/2020";

            /*
            order.CustomerId = customerId;
            order.Email = email;
            order.Name = name;
            order.TelephoneNumber = telephoneNumber;
            order.Price = price;
            order.Time = time;
            order.Height = height;
            order.Length = length;
            order.Width = width;
            order.CityFrom = cityFrom;
            order.CityTo = cityTo;
            order.Date = date;
            */

            // Insert RouteDTO to database
            DbClient client = new DbClient();
            client.SetOrder(order);

            return true;
        }
    }
}
