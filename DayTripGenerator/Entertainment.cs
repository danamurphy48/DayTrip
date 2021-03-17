using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Entertainment
    {
        //member variables (HAS A)
        public List<string> entertainmentOption;
        Random random = new Random();
        public string randomEntertainment;

        //constructor (SPAWNER)
        public Entertainment()
        {
            entertainmentOption = new List<string>();
            OptionEntertainment();
            RandomizeEntertainment();
        }
        //member methods (CAN DO)

        public void OptionEntertainment()
        {
            entertainmentOption.Add("Theater");
            entertainmentOption.Add("Museum");
            entertainmentOption.Add("Sports Event");
            entertainmentOption.Add("Outdoor Attraction");

        }
        private void RandomizeEntertainment()
        {
            int randomNumber = random.Next(0, entertainmentOption.Count);
            randomEntertainment = entertainmentOption[randomNumber];
            Console.WriteLine($"Entertainment option: {randomEntertainment}");
        }

        public void ConfirmSelection()
        {
            Console.WriteLine($"Please confirm if you are happy with {randomEntertainment}: yes or no");
            bool choice = false;
            while (!choice)
            {
                string userInput = Console.ReadLine();
                {
                    switch (userInput)
                    {
                        case "yes":
                            Console.WriteLine($"Choice confirmed: {randomEntertainment}");
                            choice = true;
                            break;
                        case "no":
                            Console.WriteLine($"Running generator again");
                            choice = false;
                            RandomizeEntertainment();
                            Console.WriteLine($"Please confirm if you are happy with {randomEntertainment}: yes or no");
                            break;
                        default:
                            Console.WriteLine("Please write 'yes' or 'no'.");
                            choice = false;
                            break;
                    }
                }
            }
        }
    }
}
