using MindboxTest.Abstract;
using System;

namespace MindboxTest.Models
{
    public class Circle : IGeometry
    {
        public Circle(double r)
        {
            R = r;
        }

        public double R { get; set; }
        public double GetSquare() => Math.PI * Math.Pow(R,2);
    }
}
