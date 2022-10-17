using System;
using System.Linq;

namespace Homework2
{
  class Program
  {
    static void Main(string[] args)
    {
    
     //1.	Define 2 string variables. Introduce their value from keyboard. Display them in console
     
     Console.WriteLine("Enter first string: ");
     string String1 = Console.ReadLine();
     Console.WriteLine("Enter second string: ");
     string String2 = Console.ReadLine();
     
     Console.WriteLine("These are first two entered strings:");
     Console.WriteLine(String1);
     Console.WriteLine(String2);
     Console.WriteLine();
     
     // playing
     
     string String3 = "This is the 3rd string.";
     string String4 = "And this is the 4th string.";
     Console.WriteLine(String3);
     Console.WriteLine(String4);
     
     Console.WriteLine("The lenght of 3rd string is " + String3.Length + " characters.");
     Console.WriteLine("The lenght of 4th string is " + String4.Length + " characters.");
     
     int Y = String3.Length;
     int Z = String4.Length;
     
     int MAX = Math.Max(Y, Z);
     
     Console.WriteLine("The longest string from the last two has " + MAX + " characters.");
     Console.WriteLine();
     
     //2.	Define 2 integer variables. Introduce their value from keyboard. Display in console the following text “ Max provided value is x”, where x is the biggest value from the 2 provided.
     
     Console.WriteLine("Enter first integer: ");
     int Integer1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter second integer: ");
     int Integer2 = Convert.ToInt32(Console.ReadLine());
     
     //not requested
     //Console.WriteLine("Here are your numbers: ");
     //Console.WriteLine(Integer1);
     //Console.WriteLine(Integer2);
     int Biggest = Math.Max(Integer1, Integer2);
     Console.WriteLine("Max provided value is " + Biggest);
     Console.WriteLine();
     
     /*3.	Define a variable of array type. Display it in console. Each array value to be separated by coma “,”.
     a.	Use “for” instruction
     b.	Use “while” instruction*/
     
	 int[] childrenAges;
    
     string[] homeworks = {"Postman1", "Postman2", "Github", "C#1", "C#2"};
     int HWlenght = homeworks.Length-1;
     Console.WriteLine("Displaying my homeworks using 'for' instruction: ");
     for (int i = 0; i < homeworks.Length-1; i++) 
     	{
        Console.Write(homeworks[i] + ", ");
        }
     Console.Write(homeworks[HWlenght]);
     Console.WriteLine();
     
     Console.WriteLine("Displaying my homeworks using 'while' instruction: ");
     int n = 0;
     while (n < homeworks.Length-1)
     	{
        Console.Write(homeworks[n] + ", ");
        n++;
     	}
     Console.Write(homeworks[HWlenght]);
     Console.WriteLine();
     Console.WriteLine();
     
    //4.	Use above array and display the average of all array’s value in console, with following text: “Average value is x”
    
    childrenAges = new int[] {16, 9, 5};
    int agesLenght = childrenAges.Length-1;
    Console.Write("My children are ");
     int g = 0;
     while (g < childrenAges.Length-1)
     	{
        Console.Write(childrenAges[g] + ", ");
        g++;
     	}
     Console.Write(childrenAges[agesLenght]);
     Console.Write(" years old.");
     Console.WriteLine();
	 Console.WriteLine("My son is " + childrenAges[0]+".");
     Console.WriteLine("My older daughter is " + childrenAges[1]+".");
     Console.WriteLine("My younger daughter is " + childrenAges[2]+".");
     double avgAge = Queryable.Average(childrenAges.AsQueryable());
     Console.WriteLine("Average age of my children is " + avgAge + ".");
     Console.WriteLine();
    
//5.	Use above array and sort it in descending order  
      
      Console.WriteLine("The list of homeworks is sorted descendingly:");
      Array.Sort(homeworks);
      Array.Reverse(homeworks);
		foreach (string i in homeworks)
		{
 		 Console.WriteLine(i);
		}
      Console.WriteLine();
      Console.WriteLine("The children's ages are sorted ascendingly:");
      Array.Sort(childrenAges);
		foreach (int i in childrenAges)
		{
 		 Console.Write(i + " ");
		}
    }
  }
}