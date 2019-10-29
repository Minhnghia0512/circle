using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Circle
    {
        private double radius;
        private String _color;
        public string color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";
        }
        public Circle(double r, string cl)
        {
            radius = r;
            color = cl;
        }
        public double getRadius()
        {
            return radius;
        }
        public double getArea() {
            return radius * radius * 3.14;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetRadius (double newRadius)
        {
            radius = newRadius;
        }
        public String toString()
        {
            return "Circle[radius=" + radius + " color=" + color + "]";
        }
    }
}
