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

            int z = 1;
            while (z <= 4)
            {
                for (int i = 1; i <= z; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                z++;
            }


            int x = 4;
            while (x > 0)
            {
                for (int n = x - 1; n > 0; n--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                x--;
            }
        }
    }
}