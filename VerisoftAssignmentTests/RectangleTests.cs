using NUnit.Framework;
using VerisoftAssignment;
using System.IO;
using System;

namespace VerisoftAssignmentTests
{
    class RectangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        public void RectangleNoAgrConstractor_CheckIfDefaultParametersFilledSuccessfully_TheDefaultParams()
        {
            // Arrange
            string defaultColor = "green";
            Rectangle rectangle = new Rectangle();
            double defaultWidth = 1, defaultLength = 1;
            // i can do just a test to see if the ToSting here is right to know that my params and constractor from Shape class is working.
            string expectedObjToString = $"A Rectangle with width = {defaultWidth} and length = {defaultLength}, which is a subclass of A Shape with color of {defaultColor} and filled";

            // Act
            double rectangleW = rectangle.GetWidth();
            double rectangleL = rectangle.GetLength();
            string rectangleToString = rectangle.ToString();

            // Assert
            Assert.AreEqual(defaultWidth, rectangleW);
            Assert.AreEqual(defaultLength, rectangleL);
            Assert.AreEqual(expectedObjToString, rectangleToString);
        }

        [Test]
        public void RectangleConstractorWithOnlyWidthAndLength_CheckIfTheWidthAndLengthFilledSuccessfully_TheUserWidthAndLength()
        {
            // Arrange
            string defaultColor = "green";
            double rWidth = 20, rLength = 50;
            Rectangle rectangle = new Rectangle(rWidth, rLength);
            string expectedObjToString = $"A Rectangle with width = {rWidth} and length = {rLength}, which is a subclass of A Shape with color of {defaultColor} and filled";

            // Act
            double rectangleW = rectangle.GetWidth();
            double rectangleL = rectangle.GetLength();
            string rectangleToString = rectangle.ToString();

            // Assert
            Assert.AreEqual(rWidth, rectangleW);
            Assert.AreEqual(rLength, rectangleL);
            Assert.AreEqual(expectedObjToString, rectangleToString);
        }

        [Test]
        public void RectangleConstractorWithAllTheParams_CheckIfTheParametersProvideByTheUserFilledSuccessfully_TheUserParams()
        {
            // Arrange
            double rWidth = 20, rLength = 50;
            string color = "red";
            bool isFilled = true;
            Rectangle rectangle = new Rectangle(color, isFilled, rWidth, rLength);
            string expectedObjToString = $"A Rectangle with width = {rWidth} and length = {rLength}, which is a subclass of A Shape with color of {color} and filled";

            // Act
            double rectangleW = rectangle.GetWidth();
            double rectangleL = rectangle.GetLength();
            string rectangleToString = rectangle.ToString();

            // Assert
            Assert.AreEqual(rWidth, rectangleW);
            Assert.AreEqual(rLength, rectangleL);
            Assert.AreEqual(expectedObjToString, rectangleToString);
        }
        [Test]
        public void RectangleSetter_CheckIfParameterValuesChange_NewRectangleParamsValues()
        {
            // Arrange
            double rWidth = 20, rLength = 50;
            Rectangle rectangle = new Rectangle();

            //Act
            rectangle.SetWidth(rWidth);
            rectangle.SetLength(rLength);
            double rectangleW = rectangle.GetWidth();
            double rectangleL = rectangle.GetLength();

            //Assert
            Assert.AreEqual(rWidth, rectangleW);
            Assert.AreEqual(rLength, rectangleL);
        }

        [Test]
        public void GetRectangleArea_CalculadeTheRectangleArea_TheRectangleArea()
        {
            // Arrange
            double rWidth = 20, rLength = 50;
            Rectangle rectangle = new Rectangle(rWidth, rLength);

            //Act

            double expectedArea = rWidth * rLength;
            double rectangleArea = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, rectangleArea);
        }

        [Test]
        public void GetRectanglePerimeter_CalculadeTheRectanglePerimeter_TheRectanglePerimeter()
        {
            // Arrange
            double rWidth = 20, rLength = 50;
            Rectangle rectangle = new Rectangle(rWidth, rLength);

            //Act

            double expectedPerimeter = rWidth * 2 + rLength * 2;
            double rectanglePerimeter = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedPerimeter, rectanglePerimeter);
        }
    }
}
