using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskTwo;

namespace TaskTwo_Test
{
    [TestClass]
    public class TCircle_Test
    {
        [TestMethod]
        public void CalculateCircleArea_ProperAreaFormulaShouldCalculate()
        {
            // arrange
            double radius = 4;
            double expected = Math.PI * radius * radius;
            TCircle circle = new TCircle(radius);

            // act
            double actual = circle.CalculateCircleArea();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateCircleSectorArea_ProperSectorAreaFormulaShouldCalculateWithProperAngle()
        {
            // arrange
            double radius = 4;
            double angle = 1;
            double expected = radius * radius * Math.Abs(angle) / 2;
            TCircle circle = new TCircle(radius);

            // act
            double actual = circle.CalculateCircleSectorArea(angle);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateCircleSectorArea_ThrowExceptionWhenWrongAngle()
        {
            // arrange
            double radius = 4;
            double angle = 10;
            TCircle circle = new TCircle(radius);

            // act
            
            // assert
            Assert.ThrowsException<Exception>(() => circle.CalculateCircleSectorArea(angle));
        }

        [TestMethod]
        public void CalculateCircleLength_ProperAreaFormulaShouldCalculate()
        {
            // arrange
            double radius = 4;
            double expected = 2 * Math.PI * radius;
            TCircle circle = new TCircle(radius);

            // act
            double actual = circle.CalculateCircleLength();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
