using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    public class ReverseNumber
    {
        public static void Revnum()
        {
            int reverse = 0;
            Console.WriteLine("Enter the Number to Reverse: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            Console.WriteLine("The reverse of the given number is: " + reverse);
            Console.ReadLine();
        }
    }
}
