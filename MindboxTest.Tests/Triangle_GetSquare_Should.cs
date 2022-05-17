using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest.Models;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MindboxTest.Tests
{
    [TestClass]
    public class Triangle_GetSquare_Should
    {
        [Test]
        public void ShouldReturn_True_When_Triangle_IsRectangular()
        {
            var testRectangularTriangle = new Triangle(3, 4, 5);
            Assert.IsTrue(testRectangularTriangle.IsRectangular);
        }

        [Test]
        public void ShouldReturn_False_When_Triangle_NotRectangular()
        {
            var testRectangularTriangle = new Triangle(7, 8, 9);
            Assert.IsFalse(testRectangularTriangle.IsRectangular);
        }

        [Test]
        public void ShouldReturn_True_When_TriangleSquare_Equal()
        {
            double testX = 6;
            double testY = 7;
            double testZ = 8;
            double testHalfPerimeter = (testX + testY + testZ) / 2;
            var testTriangleSquare_ToCompare = Math.Sqrt(testHalfPerimeter * (testHalfPerimeter - testX) * (testHalfPerimeter - testY) * (testHalfPerimeter - testZ));

            var testRectangularTriangle = new Triangle(6, 7, 8);
            Assert.AreEqual(testTriangleSquare_ToCompare,testRectangularTriangle.GetSquare());
        }

        [Test]
        public void ShouldReturn_False_When_TriangleSquare_NotEqual()
        {
            var testX = 7;
            var testY = 8;
            var testZ = 9;
            var testHalfPerimeter = (testX + testY + testZ) / 2;
            var testTriangleSquare_ToCompare = Math.Sqrt(testHalfPerimeter * (testHalfPerimeter - testX) * (testHalfPerimeter - testY) * (testHalfPerimeter - testZ));

            var testRectangularTriangle = new Triangle(6, 7, 8);
            Assert.AreNotEqual(testTriangleSquare_ToCompare, testRectangularTriangle.GetSquare());
        }
    }
}