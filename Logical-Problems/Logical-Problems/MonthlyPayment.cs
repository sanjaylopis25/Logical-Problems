using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    public class MonthlyPayment
    {
        public static void monthlyPayments()
        {
            Console.WriteLine("principal loan amount: ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("years to pay off: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("percent interest compounded monthly: ");
            double R = Convert.ToDouble(Console.ReadLine());
            double n = 12 * Y;
            double r = R / 1200;
            double x = Math.Pow((1+r),(-n));
            double Payment = (P * r) /(1 - x); 
            Console.WriteLine("Monthly Payment: "+Payment);
            Console.ReadLine();
        }
    }
}
