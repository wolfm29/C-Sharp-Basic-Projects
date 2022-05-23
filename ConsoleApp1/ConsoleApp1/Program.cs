using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    class Customer
    {
        private string aFullName;
        private string aBirthDate;
        private int aMonthNum;
        private string aLastName;
        private int aBirthYr;
        private string aPurchaseMonth;

        public string PFullName
        {
            get
            {
                return aFullName;
            }
            set
            {
                aFullName = value;
            }
        }
        public string PBirthDate
        {
            get
            {
                return aBirthDate;
            }
            set
            {
                aBirthDate = value;
            }
        }
        public int PMonthNum
        {
            get
            {
                return aMonthNum;
            }
            set
            {
                aMonthNum = value;
            }
        }

        public string PLastName
        {
            get
            {
                NameParser(aFullName);
                return aLastName;
            }
        }
        public int PBirthYr
        {
            get
            {
                BirthdateParser(aBirthDate);
                return aBirthYr;
            }

        }

        public string PPurchaseMonth
        {
            get
            {
                MonthParser(aMonthNum);
                return aPurchaseMonth;
            }

        }
        public Customer(string f, string b, int m)
        {
            aFullName = f;
            aBirthDate = b;
            aMonthNum = m;
        }

        public void NameParser(string f)
        {
            const char Separator = (' ');
            string[] partition = f.Split(Separator);
            aLastName = partition[1];

        }
        public void BirthdateParser(string b)
        {
            string[] partiton = b.Split('/');
            aBirthYr = Convert.ToInt32(partiton[2]);
        }

        public void MonthParser(int m)
        {
            string[] NameOfMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            NameOfMonths[0] = NameOfMonths[0].TrimStart('0');
            aPurchaseMonth = NameOfMonths[m - 1];
        }






    }






    class CustomerD
    {
        static void Main(string[] args)
        {
            string fName;
            string bDate;
            string inVal;
            int mNum;
            int zCode;
            char runAgain = 'n';

            do
            {
                GetDetails(out fName, out bDate, out mNum, out zCode);
                Customer code = new Customer(fName, bDate, mNum);

                Console.WriteLine("Customer Code: {0}{1}{2}{3}", code.PLastName, code.PBirthYr % 100, code.PPurchaseMonth, zCode % 100);
                Console.WriteLine();
                Console.WriteLine("Do you want to run the code again? Enter Y/N");

                inVal = Console.ReadLine();
                runAgain = Convert.ToChar(inVal);


            }
            while ((runAgain == 'Y') || (runAgain == 'y'));
        }
        public static void GetDetails(out string fName, out string bDate, out int mNum, out int zCode)
        {
            Console.WriteLine("Consumer Application!");
            Console.WriteLine("Name (FirstName LastName): ");
            fName = Console.ReadLine();

            Console.WriteLine("Birthdate (mm/dd/yyyy): ");
            bDate = Console.ReadLine();

            Console.WriteLine("Month when you subscribed for the product (month number): ");
            mNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Customer Zip Code (12345): ");
            zCode = int.Parse(Console.ReadLine());



        }

    }
}
