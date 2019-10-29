using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radius of " + c1.getRadius() + " the area of " + c1.getArea()+" and it is " + c1.GetColor());
            Circle c2 = new Circle(2.0, "Blue");
            c2.SetRadius(3.2);
            Console.WriteLine("The circle has radius of " + c2.getRadius() + " and area of " + c2.getArea() + " and it is {0} ", c2.color="yellow");
        }
    }
}
