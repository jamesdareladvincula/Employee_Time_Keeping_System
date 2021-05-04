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

		    Console.Write("Enter your First Name:\t");
		    firstName = Console.ReadLine().ToUpper();

		    Console.Write("Enter your Last Name:\t");
		    lastName = Console.ReadLine().ToUpper();

            Console.Write("Enter Time-In:\t");
		    timeIn = Console.ReadLine();

            Console.Write("Enter Time-Out:\t");
		    timeOut = Console.ReadLine();

		    Console.WriteLine();

		    Console.WriteLine("Submitted Successfully!");

            Console.WriteLine("-----------------------------------------------");

            var validTimeIn = DateTime.TryParse(timeIn, out timeInEntered);
            var validTimeOut = DateTime.TryParse(timeOut, out timeOutEntered);

            if(firstName == "JAMES DAREL" && lastName == "ADVINCULA")
            {
                Console.WriteLine("Employee Name:\t" + firstName + " " + lastName);

                if(validTimeIn && validTimeOut)
                {
                    Console.WriteLine("Time-In:\t" + timeInEntered.ToShortTimeString());
                    Console.WriteLine("Time-Out:\t" + timeOutEntered.ToShortTimeString());
                }
                    
                else
                {
                    Console.WriteLine("ERROR! Invalid Time Format.");
                }

                Console.WriteLine();

                DateTime dateSubmitted = DateTime.Now;
                Console.Write("Date Submitted:\t");
                Console.WriteLine(dateSubmitted.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            }

            else
            {
                Console.WriteLine("New Employee");
            }

            Console.WriteLine("-----------------------------------------------");

            ShowMenu();
        }
        static void ShowMenu()
            {
                Console.WriteLine("Please press:");
                Console.WriteLine("'v' - To View Previous Attendance");
                Console.WriteLine("'e' - To Exit Program");

                char menu = Convert.ToChar(Console.ReadLine());
                menu = char.ToLower(menu);

                switch (menu)
                {
                    case 'v':
                        ViewAttendance();
                        break;
                    
                    case 'e':
                        ExitProgram();
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }

            static void ViewAttendance()
            {
                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine("         Attendance Log         ");

                var attendanceLogs = new List<string>()
                {"05/03/21 - In: 9:00am - Out: 5:00pm", "05/02/21 - In: 8:45am - Out: 5:00pm", 
                 "05/01/21 -         Holiday         ", "04/30/21 - In: 9:05am - Out: 5:06pm", 
                 "04/29/21 - In: 8:55am - Out: 5:04pm", "04/28/21 - In: 9:00am - Out: 6:00pm", 
                 "04/27/21 - In: 9:07am - Out: 5:00pm"};

                foreach(var attendance in attendanceLogs)
                {
                    Console.WriteLine($"{attendance}");
                }
            }
            static void ExitProgram()
            {
                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine("|----------------------------------------------|");
		        Console.WriteLine("|                  Thank You!                  |");
		        Console.WriteLine("|----------------------------------------------|");
                
                System.Environment.Exit(0);
            }
    }
}
