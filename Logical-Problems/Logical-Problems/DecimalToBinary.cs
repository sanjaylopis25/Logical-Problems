﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    class DecimalToBinary
    {
        public static void DecToBin()
        {
            Console.Write("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.ReadKey();
        }
    }
}
