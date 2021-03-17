using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Destination
    {
        //member variables
        public List<string> locationOption;
        Random random = new Random();
        public string randomLocation;

        //constructor
        public Destination()
        {
            locationOption = new List<string>();
            OptionLocation();
            RandomizeLocation();
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

        private void RandomizeLocation()
        {
            int randomNumber = random.Next(0, locationOption.Count);
            randomLocation = locationOption[randomNumber];
            Console.WriteLine($"Destination selected: {randomLocation}");
        }

        public void ConfirmSelection()
        {
            Console.WriteLine($"Please confirm if you are happy with {randomLocation}: yes or no");
            bool satisfied = false;
            while (!satisfied)
            {
                string userInput = Console.ReadLine();
                
                switch(userInput)
                {
                    case "yes":
                        satisfied = true;
                        Console.WriteLine($"Choice confirmed: {randomLocation}");
                        break;
                    case "no":
                        satisfied = false;
                        Console.WriteLine("Running generator again");
                        RandomizeLocation();
                        Console.WriteLine($"Please confirm if you are happy with {randomLocation}: yes or no");
                        break;
                    default:
                        Console.WriteLine("Please write 'yes' or 'no'");
                        break;
                }
            }
        }
    }
}
