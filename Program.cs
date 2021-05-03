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

            else
            {
                Console.WriteLine("New Employee");
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("               Weekly Attendance               ");
            var attendanceLogs = new List<string>()
            {"05/03/21 - In: 9:00am - Out: 5:00pm", "05/02/21 - In: 8:45am - Out: 5:00pm", 
             "04/30/21 - In: 9:05am - Out: 5:06pm", "04/29/21 - In: 8:55am - Out: 5:04pm", 
             "04/28/21 - In: 9:00am - Out: 6:00pm", "04/27/21 - In: 9:07am - Out: 5:00pm", 
             "04/26/21 - In: 8:45am - Out: 5:15pm"};

            Console.WriteLine(attendanceLogs[0]);
            Console.WriteLine(attendanceLogs[1]);
            Console.WriteLine(attendanceLogs[2]);
            Console.WriteLine(attendanceLogs[3]);
            Console.WriteLine(attendanceLogs[4]);
            Console.WriteLine(attendanceLogs[5]);
            Console.WriteLine(attendanceLogs[6]);
        }
    }
}
