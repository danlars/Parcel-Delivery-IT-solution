using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel_Delivery_IT_solution
{
    public class Order
    {
        public int CustomerId { get; set; }

        public int RegistrationNumber { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string TelephoneNumber { get; set; }

        public int Price { get; set; }

        public int Time { get; set; }

        public int Height { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public int Date { get; set; }

        public string CityFrom { get; set; }

        public string CityTo { get; set; }
    }
}
