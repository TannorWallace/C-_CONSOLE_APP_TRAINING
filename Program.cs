using System;

namespace Console_Lesson
{
  class Program
  {
    static void Main(string[] args)
    //Method 1
    // {
    //   Console.WriteLine("Please enter a message!");
    //   System.Console.WriteLine("You said..." + Console.ReadLine());

    // }
    //Method 2
    {
      Console.WriteLine("What is the name of your band?");
      string name = Console.ReadLine();
      Console.WriteLine("How many members are in your band?");
      int members = 0;
      if (!int.TryParse(Console.ReadLine(), out members))
      {
        Console.WriteLine("Enter a number dude.");
        Environment.Exit(0);
      }
      if (members < 1)
      {
        Console.WriteLine("You must have atleast 1 member");
        Environment.Exit(0);
      }
      else if (members == 1)
        Console.WriteLine(name + " is a solo act");
      else if (members == 2)
        Console.WriteLine(name + " is a duo act");
      else
        Console.WriteLine(name + " has " + members + " members.");

    }
  }
}
