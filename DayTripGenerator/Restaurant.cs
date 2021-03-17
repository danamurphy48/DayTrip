using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Restaurant
    {
        //member variables (has a)
        public List<string> restaurantOptions;
        Random random = new Random();
        public string randomRestaurant;
        public Restaurant()
        {
            restaurantOptions = new List<string>();
            AddRestaurantOptions();
            RandomizeRestaurant();
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

        private void RandomizeRestaurant()
        {
            int randomNumber = random.Next(0, restaurantOptions.Count);
            randomRestaurant = restaurantOptions[randomNumber];
            Console.WriteLine($"Restaurant selected: {randomRestaurant}");
        }

        public void ConfirmSelection()
        {
            Console.WriteLine($"Please confirm if you are happy with {randomRestaurant}: yes or no");
            bool choice = false;
            while (!choice)
            {
                string userInput = Console.ReadLine();
                {
                    switch (userInput)
                    {
                        case "yes":
                            Console.WriteLine($"Choice confirmed: {randomRestaurant}");
                            choice = true;
                            break;
                        case "no":
                            Console.WriteLine($"Running generator again");
                            choice = false;
                            RandomizeRestaurant();
                            Console.WriteLine($"Please confirm if you are happy with {randomRestaurant}: yes or no");
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
