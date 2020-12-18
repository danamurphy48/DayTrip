using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Transportation
    {
        //member variables
        public List<string> transportOption;
        public Transportation()
        {
            transportOption = new List<string>();
        }

        //member methods
        public void OptionTransport()
        {
            transportOption.Add("Car");
            transportOption.Add("Plane");
            transportOption.Add("Train");
            transportOption.Add("Boat");
            transportOption.Add("Bicycle");
            transportOption.Add("Walk");
        }
    }
}
