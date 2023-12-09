using System;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello, whats your Name?");
    var Name = Console.ReadLine();
    Console.WriteLine($"Nice to meet you {Name}.");

    Console.WriteLine();
    Console.WriteLine("Press any key to close application.");
    Console.ReadKey(true);
  }
}