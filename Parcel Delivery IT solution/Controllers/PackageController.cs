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
        public Boolean InsertPackage(int CustomerId, string Email, string Name, string TelephoneNumber, int Price, int Time, int Height, int Length, int Width, string CityFrom, string CityTo, string Date)
        {
            Order order = new Order();
            order.CustomerId = 1;
            order.Email = "adsf@mail.com";
            order.Name = "name";
            order.TelephoneNumber = "1324246";
            order.Price = 2;
            order.Time = 3;
            order.Height = 4;
            order.Length = 5;
            order.Width = 6;
            order.CityFrom = "Copenhagen";
            order.CityTo = "Rome";
            order.Date = "1234qer";
            
            // Insert RouteDTO to database
            DbClient client = new DbClient();

            client.SetOrder(order);

            return true;
        }
    }
}
