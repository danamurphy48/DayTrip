using System;
using System.Collections.Generic;
using System.Text;

namespace DayTripGenerator
{
    public static class Helper
    {
        public static int PickRandomNumber(int min, int max, Random random)
        {
            return random.Next(min, max);
        }

        public static string ConfirmChoice(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }
    }
}
