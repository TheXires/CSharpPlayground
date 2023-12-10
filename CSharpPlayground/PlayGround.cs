using System;

namespace PlayGround
{
  class MyClass
  {
    public Color color { get; set; }
    public Array colors { get; set; }
    public MyClass()
    {
      Console.WriteLine("MyClass constructor.");
      color = Color.Red;
      colors = Enum.GetValues(typeof(Color));
    }

    public void PrintColor()
    {
      Console.WriteLine($"Selected color is {color}");
    }

    public void PrintColors()
    {
      Console.WriteLine("Available colors are: ");
       foreach (var item in colors)
      {
        Console.WriteLine($"> {item}");
      }
    }
  }

  struct MyStruct
  {
    public MyStruct()
    {
      Console.WriteLine("MyStruct constructor.");
    }
  }

  enum Color
  {
    Red,
    Green,
    Blue
  }
}
