using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] text ={"Dan",
        "C++",
        "FFF44443332DD",
        " +79263772622",
        " 892667777777",
        " (956)9090905" };

      foreach (string item in text)
      {
        string pattern = @"\d{4}";
        if (Regex.IsMatch(item, pattern))
        {
          //Console.WriteLine($"{item} это телефон"); 
          Console.WriteLine(item + " это телефон");
        }
        else
        {
          Console.WriteLine(
          string.Format("{0} это НЕ телефон", item)
          );
        }

      }

    }
  }
}