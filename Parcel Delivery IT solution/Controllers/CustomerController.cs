using Microsoft.AspNetCore.Mvc;
using System;

namespace Parcel_Delivery_IT_solution.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class CustomerController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public CustomerController(){}

        [System.Web.Mvc.HttpGet]
        public Customer Get(String customerId)
        {

            // TODO: Call the database to get a customer given the ID

            Customer customer = new()
            {
                CustomerId = 1,
                RegistrationNumber = 2,
                Email = "some-email@mail.com",
                TelephoneNumber = "12345678",
                ZipCode = "1234",
                CityOfResidence = "Copenhagen"
            };

            return customer;
        }
    }
}
