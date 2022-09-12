using Moq;
using NUnit.Framework;
using VerisoftAssignment;
using System.IO;
using System;

namespace VerisoftAssignmentTests
{
    public class ShapeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Tests For abstract Shape class

        [Test]
        public void ShapeNoArgConstructor_CheckIfDefaultParametersFilledSuccessfully_TheDefaultParams()
        {
            // Arrange
            string defaultColor = "green";
            string expectedObjToString = $"A Shape with color of {defaultColor} and filled";
            var mock = new Mock<Shape>()
            {
                CallBase = true /* the "reuse non-abstract" part */
            };
            //mock.Setup(x => x.GetColor()).Returns("green");
            //mock.Object.SetFilled(false);
            //mock.Setup(x => x.GetTitle()).Returns("Assistant");
            //mock.Object.Name = "Alice";

            // Act
            string objectColor = mock.Object.GetColor();
            bool objectFilled = mock.Object.IsFilled();
            string theObjToString = mock.Object.ToString();

            // Assert
            Assert.AreEqual(defaultColor, objectColor);
            Assert.IsTrue(objectFilled);
            Assert.AreEqual(expectedObjToString, theObjToString);
        Assert.Pass();
        }

        [Test]
        public void ShapeArgConstructor_CheckIfTheParametersFilledSuccessfully_TheUserParams()
        {
            // Arrange
            string userColor = "blue";
            string expectedObjToString = $"A Shape with color of {userColor} and filled";
            var mock = new Mock<Shape>(userColor, true)
            {
                CallBase = true /* the "reuse non-abstract" part */
            };

            // Act
            string objectColor = mock.Object.GetColor();
            bool objectFilled = mock.Object.IsFilled();
            string theObjToString = mock.Object.ToString();

            // Assert
            Assert.AreEqual(userColor, objectColor);
            Assert.IsTrue(objectFilled);
            Assert.AreEqual(expectedObjToString, theObjToString);
        }

        [Test]
        public void ShapeSetterSuccesss_CheckIfParameterValuesChange_NewParamsValues()
        {
            // Arrange
            string newColor = "red";
            string newObjToString = $"A Shape with color of {newColor} and Not filled";
            var mock = new Mock<Shape>()
            {
                CallBase = true /* the "reuse non-abstract" part */
            };
            mock.Object.SetColor(newColor);
            mock.Object.SetFilled(false);

            // Act
            string objectColor = mock.Object.GetColor();
            bool objectFilled = mock.Object.IsFilled();
            string theObjToString = mock.Object.ToString();

            // Assert
            Assert.AreEqual(newColor, objectColor);
            Assert.IsTrue(!objectFilled);
            Assert.AreEqual(newObjToString, theObjToString);
        }


// test to see if i cand take params from the main.

        //[Test]
        //public void TestMethod1()
        //{
        //    string Expected = "Hello World!";
        //    using (var sw = new StringWriter())
        //    {
        //        Console.SetOut(sw);
        //        VerisoftAssignment.Program.Main();

        //        var result = sw.ToString().Trim();
        //        Assert.AreEqual(Expected, result);
        //    }
        //}

    }
}