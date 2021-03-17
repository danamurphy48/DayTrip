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
            destination.ConfirmSelection();
            transportation.ConfirmSelection();
            entertainment.ConfirmSelection();
            restaurant.ConfirmSelection();
            ReviewFinal();
        }

        public void ReviewFinal()
        {
            Console.WriteLine($"Here is your final itinerary for your day trip:");
            Console.WriteLine($"Destination: {destination.randomLocation}");
            Console.WriteLine($"Transportation: {transportation.randomTransport}");
            Console.WriteLine($"Entertainment: {entertainment.randomEntertainment}");
            Console.WriteLine($"Restaurant: {restaurant.randomRestaurant}");
            Console.WriteLine("Have a great trip!");
        }


    }
}
