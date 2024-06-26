using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Classes
{
    public class Triangle : IShape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("All sides must be positive");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Invalid triangle sides");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        #region Properties====================================================================

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        #endregion


        #region Methods====================================================================

        public double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-6;
        }

        #endregion




    }
}
