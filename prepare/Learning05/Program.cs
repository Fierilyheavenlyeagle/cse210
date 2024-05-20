using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        
        Square square1 = new Square("yellow", 5);
 //       Console.WriteLine(square1.GetColor());
  //      Console.WriteLine(square1.GetArea());

        Circle circle2 = new Circle("red", 2);
     //   Console.WriteLine(circle2.GetColor());
      //  Console.WriteLine(circle2.GetArea());

        Rectangle rectangle3 = new Rectangle("green", 4,8);
     //   Console.WriteLine(rectangle3.GetColor());
    //    Console.WriteLine(rectangle3.GetArea());

        List<Shape> shaped = new List<Shape>();
        shaped.Add(square1);
        shaped.Add(circle2);
        shaped.Add(rectangle3);

        foreach( Shape sh in shaped)
        {
            Console.WriteLine(sh.GetColor());
            Console.WriteLine(sh.GetArea());
        }

    }
}
