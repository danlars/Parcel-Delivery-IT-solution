using System;

namespace Parcel_Delivery_IT_solution
{
    public class Map
    {

        String MapType;

        // Create a map.
        public Map(string maptype)
        {
            MapType = maptype;
        }

        public void updateMap()
        {
            return;
        }

        public Route getFastestRoute()
        {

            Route routeCheapest = new Route()
            {
                RouteType = "Cheapest",
                Price = 10,
                Time = 15
            };

            return routeCheapest;
        }

        public Route getCheapestRoute()
        {

            Route routeFast = new Route()
            {
                RouteType = "Fastest",
                Price = 14,
                Time = 9
            };

            return routeFast;
        }

        // Removed package from the customer object.

    }
}