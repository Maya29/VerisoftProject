using System;
using System.Collections.Generic;
using System.Text;

namespace VerisoftAssignment
{
    public class Circle : Shape, GeometricObject
    {
        protected double radius;

        // constractors
        public Circle()
        {
            SetRadius(1.0);
        }
        public Circle(double radius)
        {
            SetRadius(radius);
        }
        public Circle(string color, bool fillled, double radius) : base(color,fillled)
        {
            this.radius = radius;
        }

        // radius getter and setter
        public double GetRadius()
        {
            return this.radius;
        }
        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }
            else
            {
                throw new ArithmeticException("a radius can not be a number under 1");
            }
           
        }

        // circle area formula is: pi*radius^2
        public double GetArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        // circle Perimeter formula is: 2*pi*radius
        public double GetPerimeter()
        {
            return 2 * Math.PI * this.radius;
        }

        // print the variables with toString
        public override string ToString()
        {
            return "A Circle with radius = "+this.radius+", which is a subclass of "+ base.ToString();
        }
    }
}
