using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class Factors
    {
        public void getFactors()
        {
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
            int i = 2;
            while (userInput > 1)
            {
                while (userInput % i == 0)
                {
                    Console.WriteLine(i);
                    userInput = userInput / i;
                }

                i++;
            }
        }
    }
}