using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatures
{
    namespace WeeklyTemperatures
    {

        public class WeeklyTemperatures
        {
            //data member
            double[] temperaturesInWeek;
            public WeeklyTemperatures()
            {
                //initialize data member
                temperaturesInWeek = new double[7];
            }
            public WeeklyTemperatures(double[] temperatures)
            {
                //initialize data member
                temperaturesInWeek = temperatures;
            }
            public double HighestTemperature()
            {
                //initialize highest temp
                double highestTemp = temperaturesInWeek[0];
                //foreach loop to iterate through all the temperatures in the array
                foreach (double temperature in temperaturesInWeek)
                {
                    //if the current temperature is higher than the highest tenperature
                    //set it to highestTemp
                    if (temperature > highestTemp)
                        highestTemp = temperature;
                }
                //return highestTemp
                return highestTemp;
            }
            public double LowestTemperature()
            {
                //initialize lowest temp
                double lowestTemp = temperaturesInWeek[0];
                //foreach loop to iterate through all the temperatures in the array
                foreach (double temperature in temperaturesInWeek)
                {
                    //if the current temperature is lower than the lowest tenperature
                    //set it to lowestTemp
                    if (temperature < lowestTemp)
                        lowestTemp = temperature;
                }
                //return lowestTemp
                return lowestTemp;
            }
            public double AverageTemperature()
            {
                //initialize total temp
                double totalTemperature = 0;
                //foreach loop to iterate through all the temperatures in the array
                foreach (double temperature in temperaturesInWeek)
                {
                    //add the current temperature to the total temperature
                    totalTemperature = totalTemperature + temperature;
                }
                //return the total divided by 7
                return totalTemperature / 7;
            }
            public double AverageTempExceptLowest()
            {
                //initialize total temp
                double totalTemperature = 0;
                //initialize lowest temp
                double lowestTemp = temperaturesInWeek[0];
                //foreach loop to iterate through all the temperatures in the array
                foreach (double temperature in temperaturesInWeek)
                {
                    //if the current temperature is lower than the lowest tenperature
                    //set it to lowestTemp
                    if (temperature < lowestTemp)
                        lowestTemp = temperature;
                    //add the current temperature to the total temperature
                    totalTemperature = totalTemperature + temperature;
                }
                //subtract the current temperature from the total temperature
                totalTemperature = totalTemperature - lowestTemp;
                //return the total divided by 6
                return totalTemperature / 6;
            }
            public int NumDaysBelow(double temp)
            {
                //initialize numDays
                int numDays = 0;
                //foreach loop to iterate through all the temperatures in the array
                foreach (double temperature in temperaturesInWeek)
                {
                    //if the current temperature is lower than the given tenperature
                    //increment numDays
                    if (temperature < temp)
                        numDays++;
                }
                //return numDays
                return numDays;
            }
            public override string ToString()
            {
                //initialize highest temp
                double highestTemp = temperaturesInWeek[0];
                //initialize lowest temp
                double lowestTemp = temperaturesInWeek[0];
                //foreach loop to iterate through all the temperatures in the array
                foreach (double temperature in temperaturesInWeek)
                {
                    //if the current temperature is higher than the highest tenperature
                    //set it to highestTemp
                    if (temperature > highestTemp)
                        highestTemp = temperature;
                    //if the current temperature is lower than the lowest tenperature
                    //set it to lowestTemp
                    if (temperature < lowestTemp)
                        lowestTemp = temperature;
                }
                //initialize result with the header
                string result = "Day\tDay of Week\tTemperature\n";
                //iterate through all temperatures using for loop
                for (int i = 1; i <= 7; i++)
                {
                    //add the day number
                    result = result + i + "\t";
                    //add the day of week
                    if (i == 1)
                        result = result + "Monday" + "\t\t";
                    else if (i == 2)
                        result = result + "Tuesday" + "\t\t";
                    else if (i == 3)
                        result = result + "Wednesday" + "\t";
                    else if (i == 4)
                        result = result + "Thursday" + "\t";
                    else if (i == 5)
                        result = result + "Friday" + "\t\t";
                    else if (i == 6)
                        result = result + "Saturday" + "\t";
                    else
                        result = result + "Sunday" + "\t\t";
                    //add the temperature
                    result = result + temperaturesInWeek[i - 1] + "\n";
                }
                //add the temperature range
                result = result + "Temperature range: " + lowestTemp + " - " + highestTemp + "\n";
                //return the result
                return result;
            }
        }


        class WeelkyTemperaturesTest
        {
            public static void Main(String[] args)
            {
                WeeklyTemperatures temperatures = new WeeklyTemperatures(new double[] { 15, 13, 17, 16.5, 19, 18.5, 17 });
                Console.WriteLine("Highest temperature: " + temperatures.HighestTemperature());
                Console.WriteLine("Lowest temperature: " + temperatures.LowestTemperature());
                Console.WriteLine("Average temperature: " + temperatures.AverageTemperature());
                Console.WriteLine("Average temperature excluding the lowest temperature: " + temperatures.AverageTempExceptLowest());
                Console.WriteLine("Number of days where the temperature is below 18: " + temperatures.NumDaysBelow(18));
                Console.WriteLine(temperatures.ToString());
                Console.ReadKey();
            }
        }
    }
}
