using System;

namespace Homework3
{
  class Program
  {
  
/*1.	Define a function(method) which is called from Main() with following structure:
a.	Has “hello” name
b.	Returns void
c.	Displays in command line “Hello world!” text*/

    static void Hello()
    {
      Console.WriteLine("Hello world!");     
    }
    
//2.	Define another method which calculates and displays in command line the sum of 2 numbers received as parameters

	static void Sum(int term1, int term2)
    {
      Console.WriteLine(term1 + term2);
    }

//3.	Define a method which receives one parameter and returns its square value

    static int Square(int x)
    {
      return x * x;
    }

//4.	Define a method which receives an array and returns it this array sorted ASC

    static void SortedASC(string[] friends)
    {
        Array.Sort(friends);
          foreach (string i in friends)
		  {
 		   Console.Write(i + " ");
		  }
    }

//5.	Call all of above methods from Main() to prove their functionality

    static void Main(string[] args)
    {
      Hello();
      Sum(150, 250);
      Console.WriteLine(Square(11));
      string[] friends = {"John", "Amy", "Mary", "Andy"};
      SortedASC(friends);
    }
  }
}