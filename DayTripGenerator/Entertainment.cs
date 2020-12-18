using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Entertainment
    {
        //member variables (HAS A)
        public List<string> entertainmentOption;
        //constructor (SPAWNER)
        public Entertainment()
        {
            entertainmentOption = new List<string>();

        }
        //member methods (CAN DO)

        public void OptionEntertainment()
        {
            entertainmentOption.Add("Theater");
            entertainmentOption.Add("Museum");
            entertainmentOption.Add("Sports Event");
            entertainmentOption.Add("Outdoor Attraction");

        }
    }
}
