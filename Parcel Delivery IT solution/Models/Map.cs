using System;

namespace Parcel_Delivery_IT_solution
{
    public class Map
    {

        String MapType;
        // Create a map.
        public Map(String mapType)
        {
            MapType = mapType;
        }

        public void updateMap()
        {
            return;
        }

        public Route getFastestRoute()
        {
            return new Route();
        }

        public Route getCheapestRoute()
        {
            return new Route();
        }

        // Removed package from the customer object.

    }
}