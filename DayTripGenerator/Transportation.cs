using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Transportation
    {
        //member variables
        public List<string> transportOption;
        Random random = new Random();
        public string randomTransport;

        public Transportation()
        {
            transportOption = new List<string>();
            OptionTransport();
            PickRandomTransport();
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

        private void PickRandomTransport()
        {
            int randomNumber = random.Next(0, transportOption.Count);
            randomTransport = transportOption[randomNumber];
            Console.WriteLine("Mode of tranport: " + randomTransport);
        }

        public void ConfirmSelection()
        {
            Console.WriteLine($"If you happy with {randomTransport}, type yes. If not, type no.");
            bool satisfied = false;
            while (!satisfied)
            {
                string userInput = Console.ReadLine();
                {
                    switch (userInput)
                    {
                        case "yes":
                            Console.WriteLine($"Choice confirmed: {randomTransport}");
                            satisfied = true;
                            break;
                        case "no":
                            Console.WriteLine($"Running generator again");
                            satisfied = false;
                            PickRandomTransport();
                            Console.WriteLine($"If you happy with {randomTransport}, type yes. If not, type no.");
                            break;
                        default:
                            Console.WriteLine("Please write 'yes' or 'no'.");
                            satisfied = false;
                            break;
                    }
                }
            }    
        }
    }
}
