using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class VowelOrConsonant
    {
        public void isVowel()
        {
            Console.WriteLine("Enter a character: ");
            char userInput = char.Parse(Console.ReadLine());
            if (userInput == 'a' || userInput == 'A' || userInput == 'e' || userInput == 'E' || userInput == 'i' || userInput == 'I' || userInput == 'o' || userInput == 'O' || userInput == 'u' || userInput == 'U')
            {
                Console.WriteLine("Entered char " + userInput + " is a vowel");
            }
            else
            {
                Console.WriteLine("Entered char " + userInput + " is not a vowel");
            }
        }
    }
}