using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class PowerTwo
    {
        public void isPower()
        {
            Console.WriteLine("Enter a num(less than 31): ");
            int userInput = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i < userInput; i++)
            {
                num = num * 2;
                Console.WriteLine(num + " ");
            }
        }

    }
}