using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    class PerfectNumber
    {       
        public void Perfect()
        {
            int j = 0;
            Console.WriteLine("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= 1000; i++)
            {
                if(num % i == 0)
                {
                    j = i + j;
                }
            }
            j = j - num;
            if (j == num)
            {
                Console.WriteLine(num + " is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num + " is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
