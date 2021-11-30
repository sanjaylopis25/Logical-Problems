using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    public class VendingMachine
    {
        public static void ReturnNotes()
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notesCount = new int[notes.Length];
            Console.WriteLine("Please Enter an amount in Rs to return change from vending machine");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    notesCount[i] = amount / notes[i];
                    amount = amount - (notesCount[i] * notes[i]);
                    if (amount <= 0)
                        break;
                }
            }
            for (int i = 0; i < notes.Length; i++)
            {
                if (notesCount[i]!=0)
                {
                    Console.WriteLine("Number of " + notes[i] + "rs note :" + notesCount[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
