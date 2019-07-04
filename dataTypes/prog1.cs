using System;
namespace intro
{
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter the side of the square: ");
    float side=float.Parse(Console.ReadLine());
    float area=side*side;
    Console.Write("Area of the Square is "+area);
    
  }
}
}