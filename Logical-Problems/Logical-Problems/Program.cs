using System;

namespace Logical_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            do
            {
                repeat = false;
                Console.WriteLine("Welcome to Logical Problems");
            Console.WriteLine("1: Fibonacci Numbers\n2: Perfect Number\n3: Prime Number");
            Console.WriteLine("4: Reverse Numbers\n5: Coupon Number\n6: Stop Watch\n7: Vending Machine");
            Console.WriteLine("8: Day Of Week \n9: Temperature Conversion\n10: Monthly Payment\n11: Square Root\n12: Binary To Decimal\n13: Decimal To Binary");
            Console.WriteLine("Enter Number of the program to execute: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:                  
                    FibonacciSeries fghgf = new FibonacciSeries();
                    fghgf.Fibonacci();
                    break;
                case 2:
                    PerfectNumber obj2 = new PerfectNumber();
                    obj2.Perfect();
                    break;
                case 3:
                    PrimeNumber obj3 = new PrimeNumber();
                    obj3.Primenum();
                    break;
                case 4:
                    ReverseNumber.Revnum();
                    break;
                case 5:
                    CouponNumbers.Coupon();
                    break;
                case 6:
                    Watch.ElapsedTime();
                    break;
                case 7:
                    VendingMachine.ReturnNotes();
                    break;
                case 8:
                    DayOfWeek.dayinweek();
                    break;
                case 9:
                    TemperatureConversion.TempConvert();
                    break;
                case 10:
                    MonthlyPayment.monthlyPayments();
                    break;
                case 11:
                    SquareRoot.Sqroot();
                    break;
                case 12:
                    BinaryToDecimal.BinToDec();
                    break;
                case 13:
                    DecimalToBinary.DecToBin();
                    break;
                default:
                    Console.WriteLine("Sorry invalid Selection.");
                    break;
            }
                Console.WriteLine("Would you like to repeat? Y/N");
                int input = Console.ReadKey().KeyChar;
                repeat = (input == 'Y');

            } while (repeat);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
