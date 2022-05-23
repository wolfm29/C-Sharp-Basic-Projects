using System; //Microsoft Visual Studio teemplate for c#
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignemnt1
{
    class Banner //user class
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White; //background color
            Console.ForegroundColor = ConsoleColor.Black; //font color
            //using write line to make the banner
            Console.WriteLine("*******************************************************");
            Console.WriteLine("**        Programming Assignment #1                  **");
            Console.WriteLine("**        Developer: Milos Vukovic                   **");
            Console.WriteLine("**        Date Submitted: August 18                  **");
            Console.WriteLine("**        Purpose: CS220 class assignment.           **");
            Console.WriteLine("*******************************************************");
            Console.ReadLine(); //to stop running program 

        }
    }
}
