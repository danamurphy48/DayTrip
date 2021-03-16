using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Itinerary
    {
        //member variables
        Destination destination;
        Transportation transport;
        Entertainment entertainment;
        Restaurant restaurant;

        //constructor
        public Itinerary()
        {
            Welcome();
        }
        //member methods

        public void Welcome()
        {
            Console.WriteLine($"Welcome to Day Trip Generator. \nYour trip will be randomly generated from destination and transportation to entertainment and dining.");
        }
        public void BeginDayTrip()
        {
            SelectDestination();
            SelectTransportation();
            SelectEntertainment();
            SelectRestaurant();
        }
        public void SelectDestination()
        {
            Destination destination = new Destination();
            destination.OptionLocation();
        }
        public void SelectTransportation()
        {
            Transportation transportation = new Transportation();
            transportation.ConfirmSelection();
        }

        public void SelectEntertainment()
        {
            Entertainment entertainment = new Entertainment();
            entertainment.OptionEntertainment();
        }

        public void SelectRestaurant()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.AddRestaurantOptions();
        }



    }
}
