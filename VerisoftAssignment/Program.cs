using NUnit.Engine;
using System;
using System.Xml;

namespace VerisoftAssignment
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            Circle c1 = new Circle(4);
            Console.WriteLine(c1);
            c1.SetRadius(5.6);
            c1.SetColor("blue");
            c1.SetFilled(false);
            Console.WriteLine(c1);
            Console.WriteLine(c1.GetArea());
            Console.WriteLine(c1.GetPerimeter());

            Rectangle r1 = new Rectangle();
            Console.WriteLine(r1);
            r1.SetColor("black");
            r1.SetLength(7);
            Console.WriteLine(r1);
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(r1.GetPerimeter());
        }
    }
}
