using PlayGround;

partial class Program
{
  public static void Main()
  {
    //// Basic Test
    //Console.WriteLine("Hello, whats your Name?");
    //var Name = Console.ReadLine();
    //Console.WriteLine($"Nice to meet you {Name}.");

    // Class and Struct Test
    Console.WriteLine();
    Console.WriteLine("# Initialize class and struct");
    MyClass myClass = new MyClass();
    myClass.PrintColor();
    myClass.PrintColors();
    MyStruct myStruct = new MyStruct();

    // Exercise Chapter 3
    Console.WriteLine();
    Console.WriteLine("******************");
    Console.WriteLine("*** Chapter  3 ***");
    Console.WriteLine("******************");
    Console.WriteLine();
    Chapter_3_Exercise_5();
    Console.WriteLine();
    Chapter_3_Exercise_6();


    // Stop console from closing
    Console.WriteLine();
    Console.WriteLine("Press any key to close application.");
    Console.ReadKey(true);
  }
}