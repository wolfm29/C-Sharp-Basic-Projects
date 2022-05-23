using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment5
{

    namespace ProgramBmi
    {
        public class BMI
        {
           private double weightKg;
            private double heightCm;

            public BMI() //default constructor
            {
                weightKg = 0;
                heightCm = 0;
            }
            public BMI(double weightKg, double heightCm) //parameterized constructor
            {
                this.weightKg = weightKg;
                this.heightCm = heightCm;
            }

            public double WeightKg
            {
                get
                {
                    return weightKg;
                }
                set
                {
                    weightKg = value;
                }

            }

            public double HeightCm
            {
                get
                {
                    return heightCm;
                }
                set
                {
                    heightCm = value;
                }

            }

            
            public void Input() //function to input height and weight
            {
                Console.WriteLine("Enter weight in kilograms");
                weightKg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height in metres (ex: 1.85)");
                heightCm = Convert.ToDouble(Console.ReadLine());
            }


            public void BMIstatus() //function to calculate BMI and display status of person
            {
                double bmi;
                bmi = weightKg / (heightCm * heightCm);
                Console.WriteLine("BMI: {0:F2}", bmi);

                if (bmi < 18.5)
                {
                    Console.WriteLine("Person is Underweight");
                }
                else if (bmi > 18.5 && bmi < 24.9)
                {

                    Console.WriteLine("Person is normal");
                }
                else if (bmi > 25 && bmi < 29.9)
                {
                    Console.WriteLine("Person is Overweight");
                }
                else if (bmi >= 30)
                {
                    Console.WriteLine("Person is Obese");
                }

            }
        }

        public class BMIus
        {
            private double weightLbs;
            private double heightFtIn;

            public BMIus() //default constructor
            {
                weightLbs = 0;
                heightFtIn = 0;
            }
            public BMIus(double weightLbs, double heightFtIn) //parameterized constructor
            {
                this.weightLbs = weightLbs;
                this.heightFtIn = heightFtIn;
            }

            public double WeightLbs
            {
                get
                {
                    return weightLbs;
                }
                set
                {
                    weightLbs = value;
                }

            }

            public double HeightFtIn
            {
                get
                {
                    return heightFtIn;
                }
                set
                {
                    heightFtIn = value;
                }

            }


            public void Inputus() //function to input height and weight
            {
                Console.WriteLine("Enter weight in pounds");
                weightLbs = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height in feets and inchs (Ex:6.5)");
                heightFtIn = Convert.ToDouble(Console.ReadLine());
            }


            public void BMIusstatus() //function to calculate BMI and display status of person
            {
                double bmius;
                heightFtIn *= 12;
                bmius = (weightLbs * 703) / (heightFtIn * heightFtIn);
                Console.WriteLine("BMI: {0:F2}", bmius);


                if (bmius < 18.5)
                {
                    Console.WriteLine("Person is Underweight ");
                }
                else if (bmius > 18.5 && bmius < 24.9)
                {
                    Console.WriteLine("Person is normal ");
                }
                else if (bmius > 25 && bmius < 29.9)
                {
                    Console.WriteLine("Person is Overweight ");
                }
                else if (bmius >= 30)
                {
                    Console.WriteLine("Person is Obese");
                }

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                int question;
                Console.WriteLine("To use metric units press 1 or press 2 for imperial units");
                question = int.Parse(Console.ReadLine());

                if (question == 1)
                {

                    BMI person1 = new BMI();
                    person1.Input(); //call functions
                    person1.BMIstatus();
                    Console.ReadLine();
                }
                else if(question == 2)
                    {
                    BMIus person1 = new BMIus();
                    person1.Inputus(); //call functions
                    person1.BMIusstatus();
                    Console.ReadLine();

                }
            }
        }
    }
}
