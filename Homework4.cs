using System;

namespace Homework4
{
  
  public class TestCase //create a TestCase class
  {
  
  string TestName; 
  string TestDescription; 
  string TestPriority; 
  string ExecutionResult; 
  int TestID = 0;
  
  public TestCase() //class constructor
  {
  TestName = "Login";
  TestDescription = "Test login with valid credentials";
  TestPriority = "Critical";
  }
  
  static void Main(string[] args)
  {
    TestCase Test1 = new TestCase(); //Create an object of TestCase class  (this will call the constrcutor)
    
    TestCase Test2 = new TestCase();
    Test2.TestID = 1;
    Test2.TestDescription = "Test login with empty password";
    
    TestCase Test3 = new TestCase();
   	Test3.ExecutionResult = "Passed";
    Console.WriteLine(Test1.TestID +" / " + Test1.TestName + " / " + Test1.TestDescription + " / " + Test1.TestPriority + " / " + Test1.ExecutionResult);//print the values from constructor and parameters
    Console.WriteLine(Test2.TestID +" / " + Test2.TestName + " / " +Test2.TestDescription + " / " + Test2.TestPriority + " / " + Test2.ExecutionResult);
    Console.WriteLine(Test3.TestID +" / " + Test3.TestName + " / " +Test3.TestDescription + " / " + Test3.TestPriority + " / " + Test3.ExecutionResult);
  }
  
  }
}