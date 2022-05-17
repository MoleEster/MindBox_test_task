using MindboxTest.Abstract;
using MindboxTest.Models;
using System;
using System.Collections.Generic;

namespace MindboxTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(new Circle(2));
            geometries.Add(new Triangle(3,4,5));
            geometries.Add(new Triangle(7,4,5));

            foreach (var item in geometries)
            {
                Console.WriteLine(item.GetSquare());
                if(item.GetType() == typeof(Triangle))
                {
                    var triangle = item as Triangle;
                    Console.WriteLine("triangle is rectangular:" + triangle.IsRectangular);
                }
            }

            Console.ReadLine();
        }
    }
}
