using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Parcel_Delivery_IT_solution
{
    class DbClient
    {
        public Customer getCustomer(int ID)
        {
            Customer customer = new Customer();
            customer.CityOfResidence = "Copenhagen";
            customer.ZipCode = "1234565";
            customer.Email = "some@mail.com";
            customer.Name = "Anders And";
            customer.TelephoneNumber = "123456";
            customer.RegistrationNumber = 1234567;
            customer.CustomerId = 1;

            return customer;
        }
    }
}
