using System;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello, whats your Name?");
    var Name = Console.ReadLine();
    Console.WriteLine($"Nice to meet you {Name}.");

    Console.WriteLine();
    Console.WriteLine("# Initialize Array");

    var myArray = new int[3][];
    myArray[0] = [1, 2, 3];
    myArray[1] = [1, 2, 3, 4];
    myArray[2] = [1, 2, 3, 4, 5];


    foreach (var item in myArray.Select((value, i) => new { i, value }))
    {
      Console.WriteLine($"Array at position {item.i} contains {item.value.Length} items.");
    }

    int[][] mySecondArray = [[1, 2, 3], [1, 2, 3, 4], [1, 2, 3, 4, 5]];

    foreach (var item in mySecondArray.Select((value, i) => new { i, value }))
    {
      Console.WriteLine($"Second array at position {item.i} contains {item.value.Length} items.");
    }

    Console.WriteLine();
    Console.WriteLine("Press any key to close application.");
    Console.ReadKey(true);
  }
}