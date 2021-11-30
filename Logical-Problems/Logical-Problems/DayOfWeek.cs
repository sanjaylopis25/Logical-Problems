using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    public class DayOfWeek
    {
        public static void dayinweek()
        {
            int day = 0;
            int month = 0;
            int year = 0;
            int x = 0;
            Console.WriteLine("Enter the Date: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year: ");
            int y = Convert.ToInt32(Console.ReadLine());
            year = y - (14 - m) / 12;
            x = year + year / 4 - year / 100 + year / 400;
            month = m + 12 * ((14 - m) / 12) - 2;
            day = (d + x + 31 * month / 12) % 7;
            switch(day)
            {
                case 0:
                    Console.WriteLine("Day is Sunday");
                    break;
                case 1:
                    Console.WriteLine("Day is Monday");
                    break;
                case 2:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day is Friday");
                    break;
                case 6:
                    Console.WriteLine("Day is Saturday");
                    break;
            }
            Console.ReadLine();
        }
    }
}
