using NUnit.Framework;
using VerisoftAssignment;
using System.IO;
using System;

namespace VerisoftAssignmentTests
{
    class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleNoAgrConstractor_CheckIfDefaultParametersFilledSuccessfully_TheDefaultParams()
        {
            // Arrange
            Circle circle = new Circle();
            string defaultColor = "green";
            double defaultRadius = 1;
            // i can do just a test to see if the ToSting here is right to know that my params and constractor from Shape class is working.
            string expectedObjToString = $"A Circle with radius = {defaultRadius}, which is a subclass of A Shape with color of {defaultColor} and filled";

            // Act
            double radius = circle.GetRadius();
            string circleToString = circle.ToString();

            // Assert
            Assert.AreEqual(defaultRadius, radius);
            Assert.AreEqual(expectedObjToString, circleToString);
        }

        [Test]
        public void CircleConstractorWithOnlyRadius_CheckIfTheRadiusFilledSuccessfully_TheUserRadius()
        {
            // Arrange
            double defaultRadius = 14.5;
            string defaultColor = "green";
            Circle circle = new Circle(defaultRadius);
            string expectedObjToString = $"A Circle with radius = {defaultRadius}, which is a subclass of A Shape with color of {defaultColor} and filled";

            // Act
            double radius = circle.GetRadius();
            string circleToString = circle.ToString();

            // Assert
            Assert.AreEqual(defaultRadius, radius);
            Assert.AreEqual(expectedObjToString, circleToString);
        }

        [Test]
        public void CircleConstractorWithAllTheParams_CheckIfTheParametersProvideByTheUserFilledSuccessfully_TheUserParams()
        {
            // Arrange
            double defaultRadius = 50.4;
            string color = "black";
            bool isFilled = false;
            Circle circle = new Circle(color, isFilled, defaultRadius);
            string expectedObjToString = $"A Circle with radius = {defaultRadius}, which is a subclass of A Shape with color of {color} and Not filled";

            // Act
            double radius = circle.GetRadius();
            string circleToString = circle.ToString();

            // Assert
            Assert.AreEqual(defaultRadius, radius);
            Assert.AreEqual(expectedObjToString, circleToString);
        }

        [Test]
        public void CircleSetter_CheckIfParameterValuesChange_NewCircleParamsValues()
        {
            // Arrange
            double newradius = 50;
            Circle circle = new Circle();

            // Act
            circle.SetRadius(newradius);
            double radius = circle.GetRadius();

            // Assert
            Assert.AreEqual(newradius, radius);
        }

        [Test]
        public void GetCircleArea_CalculadeTheCircleArea_TheCircleArea()
        {
            // Arrange
            double radius = 50;
            Circle circle = new Circle(radius);

            // Act
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            double area = circle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, area);
        }

        [Test]
        public void GetCirclePerimeter_CalculadeTheCirclePerimeter_TheCirclePerimeter()
        {
            // Arrange
            double radius = 50;
            Circle circle = new Circle(radius);

            // Act
            double expectedPerimeter = 2 * Math.PI * radius;
            double perimeter = circle.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, perimeter);
        }
    }
}
