using System;
/*
 * file header
 * Michael Quinlan
 * ITSE 1430 Fall 2021
 */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( string[] args )
        {
            int xyz;            
            Console.WriteLine("Hello World!");

            //Declare some primitives
            sbyte code = 10;
            short port = 1234;
            int hours = 45;
            long debtPaybackInYears = 10_000;

            double hoursWorkd = 80.9;
            decimal payRate = 12.50M;

            char letter = 'A';
            string name = "Bob";

            //Not primitive
            DateTime today = DateTime.Now;
            TimeSpan interval = TimeSpan.FromMinutes(10);
            Guid identifier = Guid.Empty;
        }
    }
}
