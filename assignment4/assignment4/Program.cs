using assignment4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
  
    //public class for access, camelCase, memory allocation and variables type
        public class Employee
        {
            private int employeeNumber;
            private string firstName;
            private string lastName;
            private string dateOfHire;
            private string jobDescription;
            private string department;
            private double monthlySalary;

            //Constructors, value will be assigned after

            public Employee()
            {
                employeeNumber = 0;
                firstName = "";
                lastName = "";
                dateOfHire = "";
                jobDescription = "";
                department = "";
                monthlySalary = 0.0;

            }

            //Parameterised 

            public Employee(int employeeNumber, string firstName, string lastName, string dateOfHire
            , string jobDescription, string department, string v, double monthlySalary)
            {
                this.employeeNumber = employeeNumber;
                this.firstName = firstName;
                this.lastName = lastName;
                this.dateOfHire = dateOfHire;
                this.jobDescription = jobDescription;
                this.department = department;
                this.monthlySalary = monthlySalary;
            }

            //Properties

            public int EmployeeNumber
            {
                get
                {
                    return employeeNumber;
                }
                set
                {
                    employeeNumber = value;
                }
            }
            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }
            public string DateOfHire
            {
                get
                {
                    return dateOfHire;
                }
                set
                {
                    dateOfHire = value;
                }
            }
            public string JobDescription
            {
                get
                {
                    return jobDescription;
                }
                set
                {
                    jobDescription = value;
                }
            }
            public string Department
            {
                get
                {
                    return department;
                }
                set
                {
                    department = value;
                }
            }
            public double MonthlySalary
            {
                get
                {
                    return monthlySalary;
                }
                set
                {
                    monthlySalary = value;
                }
            }

            //Instance methods
            public string getFullNameSepratedBySpace()
            {
                return firstName + " " + lastName;
            }

            public string getFullNameSeperatedByComma()
            {
                return firstName + ", " + lastName;
            }

            public override string ToString()
            {
                return "Employee's Number: " + employeeNumber + "\nEmployee's Name:" + getFullNameSepratedBySpace()
                + "\nEmployee's Hiring Date: " + dateOfHire + "\nEmployee's Job Description: " + jobDescription +
                "\nEmployee's Department: " + department + "\nEmployee's Salary: " + monthlySalary.ToString("C");
            }
        }
    }


   

        class Program
        {
            static void Main(string[] args)
            {
        //Create employee Object with the attributes
        Employee employee = new Employee(1244, "Milos", "Vukovic", "10/02/2020", "Info Sec", "10/02/2020", "IT", 5000.00);
        //print name with space and comma
        Console.WriteLine(employee.getFullNameSeperatedByComma());
                Console.WriteLine(employee.getFullNameSepratedBySpace());
                //print employee detail
                Console.WriteLine(employee);
                //hold screen
                Console.ReadLine();
            }
        }
    




