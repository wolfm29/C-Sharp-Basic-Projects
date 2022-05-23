using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int score; //score input
            int numb = 0; //tracking number of scores
            double sum = 0.0; //summary of scores
            double average; // average
            int student = 0;

            Console.WriteLine("Enter scores to calculate the average (from 0 to 100)");

            Console.WriteLine("Enter the number of students to calculate their average grade: ");
            int.TryParse(Console.ReadLine(), out student);



            for (int num = 0; num < student; num++)
            {



                Console.WriteLine("Enter score: ");
                int.TryParse(Console.ReadLine(), out score);
                //Loop is going on until -1 is inputed 
                while (score != -1)
                {

                    while(score < 0 || score > 100)

                    if (score < 0 || score > 100)
                    {
                        Console.WriteLine("Invalid input!");
                        score = 0;
                        Console.WriteLine("Enter new score: ");
                    }
                    else
                    {
                        Console.WriteLine("Enter new score: ");
                        score = Convert.ToInt32(Console.ReadLine());
                    }
                    sum += score;
                    numb++;


                }


                average = sum / numb; //Count average

                //Grade scores

                if (average > 90 && average < 101)
                {
                    Console.WriteLine("Average score is A");
                }
                else if (80 < average && average < 90)
                {
                    Console.WriteLine("Average score is B ");
                }
                else if (70 < average && average < 80)
                {
                    Console.WriteLine("Average score is C");
                }
                else if (60 < average && average < 70)
                {
                    Console.WriteLine("Average score is D");
                }
                else if (average < 60)
                {
                    Console.WriteLine("Average score is F");
                }
                //In case user inputs invalid scores such as 200,300,-100, etc.
                else
                {
                    Console.WriteLine("Invalid scores!");
                }
            }
            Console.ReadKey();
        }
    }
}
