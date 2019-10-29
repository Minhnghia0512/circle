using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Circle2
    {
        private double radius;
		public Circle2()
        {
            this.radius = 1.0;
		}
        public Circle2(double r)
        {
            radius = r;
        }
        public double getRadius()
        {
            return radius;
        }
        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }
        public double getArea()
        {
            return radius * radius * 3.14;
        }
        public double getCircumference()
        {
            return radius * 2 * 3.14; 
        }
        public String toString()
        {
            return "Circle[radius=" + radius + " Area= " + getArea() + " Circumference= "+ getCircumference() + "]";
        }
    }
}
