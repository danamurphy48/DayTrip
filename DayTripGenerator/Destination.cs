using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Destination
    {
        //member variables
        public List<string> locationOption;

        //constructor
        public Destination()
        {
            locationOption = new List<string> ();
        }

        //member methods
        public void OptionLocation()
        {
            locationOption.Add("Milwaukee");
            locationOption.Add("Madison");
            locationOption.Add("Chicago");
            locationOption.Add("Green Bay");
            locationOption.Add("Minneapolis");
            locationOption.Add("Rockford");
        }
    }
}
