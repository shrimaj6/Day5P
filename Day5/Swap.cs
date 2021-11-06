using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class Swap
    {
        public void doSwap()
        {
            Console.WriteLine("Enter 2 numbers :");
            int userInput1 = int.Parse(Console.ReadLine());
            int userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swapping num1:" + userInput1 + " num2:" + userInput2);
            int temp = userInput1;
            userInput1 = userInput2;
            userInput2 = temp;
            Console.WriteLine("After swapping num1:" + userInput1 + " num2:" + userInput2);
        }
    }
}