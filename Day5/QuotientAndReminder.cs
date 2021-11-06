using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class QuotientAndReminder
    {
        public void getQandR()
        {
            Console.WriteLine("Enter the number : ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor : ");
            int userDivisor = int.Parse(Console.ReadLine());
            int Quotient = userInput / userDivisor;
            int Remainder = userInput % userDivisor;
            Console.WriteLine("Quotient is " + Quotient + " Remainder is " + Remainder);

        }
    }
}