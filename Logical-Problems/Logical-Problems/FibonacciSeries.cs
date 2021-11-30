using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int res = 0;
            Console.WriteLine("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Series should repeat till number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" " + num1);
            Console.WriteLine(" " + num2);
            while (res <= N)
            {
                res = num1 + num2;
                Console.WriteLine(" " +res);
                num1 = num2;
                num2 = res;
            }
            Console.ReadLine();
        }
    }
}
