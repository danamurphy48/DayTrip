using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Restaurant
    {
        //member variables (has a)
        public List<string> restaurantOptions;
        public Restaurant()
        {
            restaurantOptions = new List<string>();
        }

        //member methods (can do)
        public void AddRestaurantOptions()
        {
            restaurantOptions.Add("Italian");
            restaurantOptions.Add("French");
            restaurantOptions.Add("Portugese");
            restaurantOptions.Add("Steak");
            restaurantOptions.Add("American");
            restaurantOptions.Add("Brazilian");
            restaurantOptions.Add("Spanish");
            restaurantOptions.Add("Irish");
            restaurantOptions.Add("Indian");
            restaurantOptions.Add("Chinese");
            restaurantOptions.Add("Nepalese");
            restaurantOptions.Add("Vietnamese");
            restaurantOptions.Add("Thai");
            restaurantOptions.Add("Japanese");
            restaurantOptions.Add("Swedish");
        }
    }
}
