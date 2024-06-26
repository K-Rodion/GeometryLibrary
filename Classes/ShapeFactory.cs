using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Classes
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(params double[] parameters)
        {
            return parameters.Length switch
            {
                1 => new Circle(parameters[0]),
                3 => new Triangle(parameters[0], parameters[1], parameters[2]),
                _ => throw new ArgumentException("Invalid number of parameters")
            };
        }
    }
}
