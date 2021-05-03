using System;
using System.Collections.Generic;

namespace Employee_Time_Keeping_System
{
    class Program
    {
        static void Main(string[] args)
        {
		    string firstName;
		    string lastName;
		    string timeIn;
		    string timeOut;
		    DateTime timeInEntered;
		    DateTime timeOutEntered;

		    Console.WriteLine("|----------------------------------------------|");
		    Console.WriteLine("|         Employee Time Keeping System         |");
		    Console.WriteLine("|----------------------------------------------|");

            Console.WriteLine();

		    Console.Write("Enter your First Name:");
		    firstName = Console.ReadLine().ToUpper();

		    Console.Write("Enter your Last Name:");
		    lastName = Console.ReadLine().ToUpper();

		    Console.Write("Enter Time-In:");
		    timeIn = Console.ReadLine();

		    Console.Write("Enter Time-Out:");
		    timeOut = Console.ReadLine();

		    Console.WriteLine();

		    Console.WriteLine("Submitted Successfully!");

            Console.WriteLine("-----------------------------------------------");

		    var validTimeIn = DateTime.TryParse(timeIn, out timeInEntered);
            var validTimeOut = DateTime.TryParse(timeOut, out timeOutEntered);

		    if(firstName == "JAMES DAREL" && lastName == "ADVINCULA")
		    {
                Console.WriteLine("Employee Name:" + firstName + " " + lastName);

                if(validTimeIn && validTimeOut)
                {
                    Console.WriteLine("Time-In:" + timeInEntered.ToShortTimeString());
                    Console.WriteLine("Time-Out:" + timeOutEntered.ToShortTimeString());
                }
                
                else
                {
                    Console.WriteLine("ERROR! Invalid Time Format.");
                }

                Console.WriteLine();

                DateTime dateSubmitted = DateTime.Now;
                Console.Write("Date Submitted:");
                Console.WriteLine(dateSubmitted.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            }
        }
    }
}
