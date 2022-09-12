using System;

namespace LP_MyApplication
{
    class LP_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int myAge = 40;
            Console.WriteLine("I'm " + myAge + " years old.");

            const string currentMonth = "September";
            Console.WriteLine(currentMonth + " is the most beautiful month of the year.");

            Console.WriteLine("Enter date:");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Today is the " + date + "th of september.");
        }
    }
}