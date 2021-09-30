using System;
using System.Linq;
using static System.Console;

/*
 * This project is a collection of exersises that will teach students how to write clean and DRY code.
 * These exersises are stutable for beginer to experienced programmers.
 */
namespace CleanCodeExersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.CleanResults();
        }

       public void CleanResults()
        {

            IsLegalDrikingAgeClean();
            IsLoggedInClean();
            eligibleClean();
            GetPriceClean();
            ReadKey();
        }



        /*
         * Magic Number exercise
         */
        public bool IsLegalDrikingAgeDirty(int age)
        {
            if (age > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * Solution to Magic Number exercise
         * Use consts to describe the numbers you are using to your programs.
         */
        public bool IsLegalDrikingAgeClean()
        {
            // I set the legaldrinking age to be a constant int with the value 21.
            // It is now reusable.

            int customerAge = 31; // random "input number"
            const int legalAge = 21;

            Write("\n\n  Danny is 31 years old, is he allowed to drink if the minimum age is 21?: ");

            if (customerAge >= legalAge)
            {
                Write("TRUE");
                return true;
            }
            else
            {
                Write("FALSE");
                return false;
            }


        }
        /*
         * Be positive exersise
         */
        public bool IsLoggedInDirty(bool isNotloggedIn)
        {
            if (!isNotloggedIn == true)
            {
                System.Console.WriteLine("Succesfully logged in.");
                return true;
            }
            else
            {
                System.Console.WriteLine("Failed to logged in.");
                return false;
            }
        }
        /*
         * Solution to Be positive exersise
         */
        public bool IsLoggedInClean()
        {
            bool loggedIn = true;

            Write("\n\n\n\n  Login Status: ");

            if (loggedIn == true)
            {
                Write("Succesfully logged in.");
                return true;
            }
            else
            {
                Write("Failed to logged in.\n\n");
                return false;
            }
        }
        
         /* Intermediate exercise
         * What is the question answering?
         */
        public bool eligibleDirty(Employee employee)
        {
            if (employee.Age > 55
                && employee.YearsEmployed > 10
                && employee.IsRetired == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
     /* Solution to ohm Intermediate exercise
     * An intermediate Variable says a lot more them a long expression
     */

    public bool eligibleClean()
        {
            Employee E = new Employee();
            int myAge = 60;
            int myYearsEmployed = 14;
            bool amIRetired = true;

            Write("\n\n\n\n  SUPER MEGA BONUS PENSION demands: 1. Above 55 years old, 2. You have been employed for more than 10 years,\n  3. You are retired\n");
            Write("\n  Your record: Age 60, Years Employed 14, You are retired. \n\n  [Eligible] ");

            if (myAge > E.MinimumAge && myYearsEmployed > E.MinimumYearsEmployed && amIRetired == E.MustBeRetired)
            {
                Write("TRUE\n\n");
                return true;
            }
            else
            {
                Write("FALSE\n\n");
                return false;
            }
        }

        /*
         * Ternary exersise
         */


        public double GetPriceDirty(bool isPreordered)
        {
            if (isPreordered == true)
            {
                return 200.00;
            }
            else
            {
                return 350.00;
            }
        }
        /*
         * Solution to Ternary exersise
         * Use a oneline Ternary.
         * */
         
        public void GetPriceClean()
        {
            string isPreordered(double money) => money <= 200 ? "Beacuse you Preordered" : "Because you dit NOT Preorder";

            Write("\n\n  I have 200 in my account: ");

            Write(isPreordered(200));

            Write("\n\n  I have 350 in my account: ");

            Write(isPreordered(350));
        }
        /*
         * Strong type exersise - not done
         */

    }
}


