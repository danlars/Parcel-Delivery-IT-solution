using Microsoft.AspNetCore.Mvc;


namespace Parcel_Delivery_IT_solution.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class BusinessLogicController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public BusinessLogicController(){}

        [System.Web.Mvc.HttpGet]
        public Route Get()
        {
            
            // TODO: Call the business logic returning the route
            
            Route route = new Route
            {
                Price = 10,
                Time = 15
            };

            return route;
        }
    }
}
