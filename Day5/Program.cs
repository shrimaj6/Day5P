using System;

namespace Day5
{
    class Program
    {
        public static void Main(string[] args)
        {
        Label: Console.WriteLine("1:Percentage Coin-Flip\n2:Leap year \n3:Power of 2\n4:Harmonic Number\n5:Factors\n6:Quotient and Remainder\n7:Swap\n8:Even Odd\n9:Vowel or Consonants\n10:Largest Number ");
            Console.WriteLine("Enter choice");
            int user = int.Parse(Console.ReadLine());

            switch (user)
            {
                case 1:
                    HeadTail Obj1 = new HeadTail();
                    Obj1.PrintHeadTail();
                    break;
                case 2:
                    LeapYear Obj2 = new LeapYear();
                    Obj2.isLeap();
                    break;
                case 3:
                    PowerTwo Obj3 = new PowerTwo();
                    Obj3.isPower();
                    break;
                case 4:
                    HarmonicNumber Obj4 = new HarmonicNumber();
                    Obj4.isHarmonic();
                    break;
                case 5:
                    Factors Obj5 = new Factors();
                    Obj5.getFactors();
                    break;
                case 6:
                    QuotientAndReminder Obj6 = new QuotientAndReminder();
                    Obj6.getQandR();
                    break;
                case 7:
                    Swap Obj7 = new Swap();
                    Obj7.doSwap();
                    break;
                case 8:
                    EvenOdd Obj8 = new EvenOdd();
                    Obj8.getEvenOdd();
                    break;
                case 9:
                    VowelOrConsonant Obj9 = new VowelOrConsonant();
                    Obj9.isVowel();
                    break;
                case 10:
                    LargestAmongThree Obj10 = new LargestAmongThree();
                    Obj10.getLargest();
                    break;
                default:
                    Console.WriteLine("Enter number between 1-10");
                    break;
            }
            Console.WriteLine("Continue...y/n");
            if (Console.ReadKey().KeyChar.ToString() == "y")
            {
                goto Label;
            }
            Console.ReadKey();

        }
    }
}