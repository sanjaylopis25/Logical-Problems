using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    public class SquareRoot
    {
        public static void Sqroot()
        {
            Console.WriteLine("Enter non-negative number: ");
            double c = Convert.ToInt32(Console.ReadLine());
            double t = c;
            double epsilon = 1e-15;
            while(Math.Abs(t-(c/t))>epsilon*t)
            {
                double x = (c / t)+t;
                t = x / 2;
            }
            Console.WriteLine("sqrt of number is : "+t);
            Console.ReadLine();
        }
    }
}
