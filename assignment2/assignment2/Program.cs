using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cents = 92; //change amount
            int quarters;
            int dimes;
            int nickels;
            int pennies;
            int leftover; //using leftover as a storage for leftover

            quarters = cents / 25;
            leftover = cents % 25;

            dimes = leftover / 10;
            leftover = leftover % 10;

            nickels = leftover / 5;
            leftover = leftover % 5;

            pennies = leftover;

             

            Console.WriteLine("Change amount = {0:C}",  0.92); //monetary format
            Console.WriteLine("Number of quarters = " + quarters);
            Console.WriteLine("Number of dimes = " + dimes);
            Console.WriteLine("Number of nickels = " + nickels);
            Console.WriteLine("Number of pennies = " + pennies);

            Console.ReadLine();

        }
    }
}
