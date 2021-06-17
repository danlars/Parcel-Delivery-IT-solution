/*
using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Parcel_Delivery_IT_solution.Controllers
{
    public class ValuesController : ApiController
    {
        static string _address = "http://api.worldbank.org/countries?format=json";
        private string result;

        // GET api/values
        public IEnumerable<string> Get()
        {
            GetResponse();
            return new string[] { result, "value2" };
        }

        private async void GetResponse()
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(_address);
            response.EnsureSuccessStatusCode();
            result = await response.Content.ReadAsStringAsync();
        }
    }
}
*/