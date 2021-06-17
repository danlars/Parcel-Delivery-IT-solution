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
        public Customer Get(int customerId)
        {
            // Returns the costumer information

            DbClient client = new DbClient();

            Customer customer = client.getCustomer(customerId);
            
            // TODO: Call the database to get a customer given the ID

            return customer;
        }
    }
}
