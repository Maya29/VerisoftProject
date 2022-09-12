using System;
using System.Collections.Generic;
using System.Text;

namespace VerisoftAssignment
{
    public abstract class Shape
    {
        protected string color;
        protected bool filled;

        // constractors
        public Shape()
        {
            this.color = "green";
            this.filled = true;
        }
        public Shape(string color, bool filled)
        {
            SetColor(color);
            SetFilled(filled);
        }

        // color getter and setter
        public string GetColor()
        {
            return this.color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }

        //filled getter and setter
        public bool IsFilled()
        {
            return this.filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }

        // print the  variables with toString
        public override string ToString()
        {
            //string str;
            //if (IsFilled)
            //{
            //    str = "A Shape with color of " + this.color + " and filled";
            //}
            //else
            //{
            //    str = "A Shape with color of " + this.color + " and Not filled";
            //}
            return IsFilled() ? "A Shape with color of " + this.color + " and filled" : "A Shape with color of " + this.color + " and Not filled";
        }

        // to do an override to SetLength and SetWidth i need to make the function here, but i don't think it's right. 
        // i can't name them as SetLength and SetWidth, since i aready have it in Rectangle.
        // i can't replace it with the setters i alredy have, since they need to do different thins.
        public virtual void SetWidthForSquare(double width) { }
        public virtual void SetLengthForSquare(double length) { }
    }
}
