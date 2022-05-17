using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest.Models;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MindboxTest.Tests
{
    [TestClass]
    public class Circle_GetSquare_Should
    {

        [Test]
        public void ShouldReturn_Square_Equal()
        {
            var testRadius = 10;
            var testCircleSquare_ToCompare = Math.PI * Math.Pow(testRadius, 2);

            var testCircle = new Circle(testRadius);

            Assert.AreEqual(testCircleSquare_ToCompare, testCircle.GetSquare());
        }

        [Test]
        public void ShouldFail_Square_NotEqual()
        {
            var testRadius = 11;
            var testCircleSquare_ToCompare = Math.PI * Math.Pow(testRadius, 2);

            var testCircle = new Circle(testRadius - 1);

            Assert.AreNotEqual(testCircleSquare_ToCompare, testCircle.GetSquare());
        }
    }
}
