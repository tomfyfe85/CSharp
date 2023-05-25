using System;

namespace CSharp.Intro
{
  class Calculator
  {
    static void Main(string[] args)
    {
      {
        // note that the we have to declare a type (int) for the variable (result)
        int result = 2 + 2;
        Console.WriteLine("The result is {0:d}", result);
      }
    }
  }
}