using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Program
{
  public static void Chapter_3_Exercise_5()
  {
    Console.WriteLine("# Chapter 3 - Exercise 5");

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
  }


  public static void Chapter_3_Exercise_6()
  {
    Console.WriteLine("# Chapter 3 - Exercise 6");

    var myArray = new string[3,2];
    myArray[0,0] = "1";
    myArray[0,1] = "2";
    myArray[1,0] = "3";
    myArray[1,1] = "4";
    myArray[2,0] = "5";
    myArray[2,1] = "6";

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
      for (int j = 0; j < myArray.GetLength(1); j++)
      {
        Console.WriteLine($"Array at position {i},{j} contains {myArray[i,j]}.");
      }
    }
  }
}
