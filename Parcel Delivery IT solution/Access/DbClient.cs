using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Parcel_Delivery_IT_solution
{
    class DbClient
    {
        public Customer getCustomer(int ID)
        {
            Customer customer = new Customer();
            customer.CustomerId = ID;
            using (SqlConnection connection = new SqlConnection("Server=db-eit-dk1.database.windows.net;Database=db-eit-dk1; Initial Catalog=db-eit-dk1; User Id=admin-eit-dk1;Password=Eastindia4thewin;"))
            {
                string SqlCmdCustRegNo = "SELECT [RegistrationNumber], [Email], [CustommerName], [PhoneNumber], [ZipCode], [CityOfResidence] FROM Customer WHERE Customer_ID =" + ID.ToString();
                SqlCommand command = new SqlCommand(SqlCmdCustRegNo, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    string regno = reader[0].ToString();
                    string email = reader[1].ToString();
                    string CustName = reader[2].ToString();
                    string PhoneNumber = reader[3].ToString();
                    string ZipCode = reader[4].ToString();
                    string CityOfResidence = reader[5].ToString();

                    customer.RegistrationNumber = Int32.Parse(regno);
                    customer.Email = email;
                    customer.Name = CustName;
                    customer.TelephoneNumber = PhoneNumber;
                    customer.ZipCode = ZipCode;
                    customer.CityOfResidence = CityOfResidence;
                }
                // Call Close when done reading.
                reader.Close();
            }
            return customer;
        }

        public void SetOrder(Order order)
        {
            string cmdString = "INSERT INTO [OrderTable] ([Customer_ID], [Price], [PackageY], [PackageX], [PackageZ], [ShipmentDate], [FromCity], [ToCity]) VALUES (" + Convert.ToString(order.CustomerId) + ",'" + Convert.ToString(order.Price) + "'," + Convert.ToString(order.Height) + "," + Convert.ToString(order.Width) + "," + Convert.ToString(order.Length) + ",'" + order.Date + "','" + order.CityFrom + "','" + order.CityTo + "')";
            using (SqlConnection connection = new SqlConnection("Server=db-eit-dk1.database.windows.net;Database=db-eit-dk1; Initial Catalog=db-eit-dk1; User Id=admin-eit-dk1;Password=Eastindia4thewin;"))
            {
                SqlCommand command = new SqlCommand(cmdString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}