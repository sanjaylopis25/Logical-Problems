using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    public class TemperatureConversion
    {
        public static void TempConvert()
        {
            int F = 0;
            int C = 0;         
            const int Fahrenheit = 0;
            const int Celsius = 1;
            Console.WriteLine("Enter 0 to convert Fahrenheit to Celsius \nEnter 1 to convert Celsius to Fahrenheit: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == Fahrenheit)
            {
                Console.WriteLine("Enter Fahrenheit: ");
                F = Convert.ToInt32(Console.ReadLine());
                C = (F - 32) * 5 / 9;
                Console.WriteLine("In Celsius :"+ C);
                Console.ReadLine();
            }
            if (choice == Celsius)
            {
                Console.WriteLine("Enter Celsius: ");
                C = Convert.ToInt32(Console.ReadLine());
                F = (C * 9 / 5) + 32;
                Console.WriteLine("In Fahrenheit :" + F);
                Console.ReadLine();
            }
        } 
    }
}
