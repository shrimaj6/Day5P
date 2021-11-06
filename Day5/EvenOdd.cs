using System;
using System.Collections.Generic;
using System.Text;

namespace Day5

{
    public class EvenOdd
    {
        public void getEvenOdd()
        {
            Console.WriteLine("Enter a num: ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput % 2 == 0)
            {
                Console.WriteLine("Even : " + userInput);
            }
            else
            {
                Console.WriteLine("Odd : " + userInput);
            }
        }
    }
}