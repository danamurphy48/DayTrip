using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    class Itinerary
    {
        //member variables
        Destination destination;
        Transportation transportation;
        Entertainment entertainment;
        Restaurant restaurant;

        //constructor
        public Itinerary()
        {
            Welcome();
            destination = new Destination();
            transportation = new Transportation();
            entertainment = new Entertainment();
            restaurant = new Restaurant();
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
            //Destination destination = new Destination();
            destination.ConfirmSelection();
        }
        public void SelectTransportation()
        {
            //Transportation transportation = new Transportation();
            transportation.ConfirmSelection();
        }

        public void SelectEntertainment()
        {
            //Entertainment entertainment = new Entertainment();
            entertainment.ConfirmSelection();
        }

        public void SelectRestaurant()
        {
            //Restaurant restaurant = new Restaurant();
            restaurant.ConfirmSelection();
        }



    }
}
