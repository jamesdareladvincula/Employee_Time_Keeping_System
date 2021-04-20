using System;

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

            Console.WriteLine("Employee Time Keeping System");
			
            Console.WriteLine("Enter your First Name:");
			firstName = Console.ReadLine().ToUpper();
            
            Console.WriteLine("Enter your Last Name:");
			lastName = Console.ReadLine().ToUpper();
			
			Console.WriteLine("Enter Time-In:");
			timeIn = Console.ReadLine();
			
			Console.WriteLine("Enter Time-Out:");
			timeOut = Console.ReadLine();
			
			Console.WriteLine();

            Console.WriteLine("Submitted Successfully!");

            
			
            if(firstName == "JAMES DAREL" && lastName == "ADVINCULA")
            {
			    Console.WriteLine("Employee Name:" + firstName + " " + lastName);
			    Console.WriteLine("Time-In:" + timeIn);
			    Console.WriteLine("Time-Out:" + timeOut);
			
			    DateTime dateSubmitted = DateTime.Now;
			    Console.Write("Date Submitted:");
			    Console.WriteLine(dateSubmitted.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            }
        }
    }
}
