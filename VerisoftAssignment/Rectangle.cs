using System;
using System.Collections.Generic;
using System.Text;

namespace VerisoftAssignment
{
    public class Rectangle : Shape, GeometricObject
    {
        protected double width;
        protected double length;

        // constractors
        public Rectangle()
        {
            SetWidth(1.0);
            SetLength(1.0);
        }
        public Rectangle(double width, double length)
        {
            SetWidth(width);
            SetLength(length);
        }
        public Rectangle(string color, bool fillled, double width, double length) : base(color, fillled)
        {
            SetWidth(width);
            SetLength(length);
        }

        // width getter and setter
        public double GetWidth()
        {
            return this.width;
        }
        public void SetWidth(double width)
        {
            if(width > 0)
            {
                this.width = width;
            }
            else
            {
                throw new ArithmeticException("a width can not be a number under 1");
            }
        }

        // length getter and setter
        public double GetLength()
        {
            return this.length;
        }
        public void SetLength(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                throw new ArithmeticException("a length can not be a number under 1");
            }
        }

        public double GetArea()
        {
            return this.width * this.length;
        }

        public double GetPerimeter()
        {
            return this.width * 2 + this.length * 2;
        }

        // print the variables with toString
        public override string ToString()
        {
            return "A Rectangle with width = "+ this.width + " and length = " + this.length + ", which is a subclass of " + base.ToString();
        }


        //the override from the Shape Class
        public override void SetWidthForSquare(double width)
        {
            if (width > 0)
            {
                this.width = width;
                this.length = width;
            }
            else
            {
                throw new ArithmeticException("a width and length can not be a number under 1");
            }

        }
        // since this setters need to make the rectangle a square i can just send the user parameter to SetWidthForSquare, so i will not have a repeted code.
        public override void SetLengthForSquare(double length)
        {
            SetWidthForSquare(length);
        }
    }
}
