using System;
using System.Collections;

namespace prak4_02_upr02
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack stack = new Stack();
      stack.Push("1-st");
      stack.Push("2-nd");
      stack.Push("3-d");
      stack.Push("Go");
      while (stack.Count > 0)
      {
        object obj = stack.Pop();
        Console.WriteLine("'From Stack: {0}", obj);
      }

    }
  }
}