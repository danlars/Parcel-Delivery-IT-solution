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
        public Boolean InsertPackage(RouteDTO routeDTO)
        {
            
            // Insert RouteDTO to database

            return true;
        }
    }
}
