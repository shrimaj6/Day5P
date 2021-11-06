using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class LeapYear
    {
        public void isLeap()
        {
            Console.WriteLine("Enter the year(4-digit): ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput % 400 == 0 || userInput % 4 == 0 && userInput % 100 != 0)
            {
                Console.WriteLine(userInput + " is a Leap Year");
            }
            else
            {
                Console.WriteLine(userInput + " is not a Leap Year");
            }
        }

    }
}