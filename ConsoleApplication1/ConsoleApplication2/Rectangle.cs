using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Rectangle
    {
        private float lenght;
        private float wide;
        public Rectangle()
        {
            this.lenght = 1.0f;
            this.wide = 1.0f;
        }
        public Rectangle(float l, float w)
        {
            lenght = l;
            wide = w;
        }
        public float getLenght()
        {
            return lenght;
        }
        public float getWide()
        {
            return wide;
        }
        public void SetLenght(float newLenght)
        {
            lenght = newLenght;
        }
        public void SetWide(float newWide)
        {
            wide = newWide;
        }
        public double getArea()
        {
            return lenght * wide;
        }
        public double getPerimeter()
        {
            return 2 * (lenght + wide);
        }
        public String toString()
        {
            return "Rectangle[lenght=" + lenght + " wide " + wide + " Area= " + getArea() + " perimeter " + getPerimeter() + "]";
        }
    }
}
