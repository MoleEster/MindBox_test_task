using MindboxTest.Abstract;
using System;

namespace MindboxTest.Models
{
    public class Triangle : IGeometry
    {
        public Triangle(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;

            if (Math.Pow(y, 2) + Math.Pow(z, 2) == Math.Pow(x, 2))
            {
                _katets = new double[]{ y, z };
            }
            if(Math.Pow(x, 2) + Math.Pow(z, 2) == Math.Pow(y, 2))
            {
                _katets = new double[] { x, z };
            }
            if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2))
            {
                _katets = new double[] { x, y };
            }
        }

        private readonly double[] _katets;
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public bool IsRectangular { get => _katets != null; }


        public double GetSquare()
        {
            double result;

            if (IsRectangular)
            {
                result = (Math.Pow(_katets[0], 2) * Math.Pow(_katets[1], 2)) / 2;
            }
            else
            {
                var halfPerimetr = (X + Y + Z) / 2;
                result = Math.Sqrt(halfPerimetr * (halfPerimetr - X) * (halfPerimetr - Y) * (halfPerimetr - Z));
            }

            return result;
        }
    }
}
