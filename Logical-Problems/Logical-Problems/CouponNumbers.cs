using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    class CouponNumbers
    {
        public static void Coupon()
        {
            var numbers = "0123456789";
            var array = new char[6];
            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numbers[random.Next(numbers.Length)];
            }

            var finalString = new String(array);
            Console.WriteLine("The distinct coupon number is: " + finalString);
            Console.ReadLine();
        }
    }
}
