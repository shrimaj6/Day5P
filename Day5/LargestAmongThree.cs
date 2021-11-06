using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class LargestAmongThree
    {
        public void getLargest()
        {
            Console.WriteLine("Enter the 3 numbers : ");
            int userInput1 = int.Parse(Console.ReadLine());
            int userInput2 = int.Parse(Console.ReadLine());
            int userInput3 = int.Parse(Console.ReadLine());

            int max1 = Math.Max(userInput1, userInput2);
            int max2 = Math.Max(max1, userInput3);
            Console.WriteLine("Maximum value is " + max2);


        }
    }
}