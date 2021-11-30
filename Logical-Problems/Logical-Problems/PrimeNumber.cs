using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    public class PrimeNumber
    {
        
        public void Primenum()
        {
            int res = 0;
            Console.WriteLine("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    res ++;
                }
            }
            if (res == 2)
            {
                Console.WriteLine(num + " is prime");
                Console.ReadLine();
            }                
            else
            {
                Console.WriteLine(num + " is not a prime number");
                Console.ReadLine();
            }                
        }     
    }
}
