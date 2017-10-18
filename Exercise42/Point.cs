using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
{
    class Point
    {
        private double x;
        private double y;

        public double VariableX
        {
            set { x = value; }
            get { return x; }
        }

        public double VariableY
        {
            set { y = value; }
            get { return y; }
        }

        public Point()
        {
            VariableX = 0;
            VariableY = 0;
        }

        public Point(double ex, double why)
        {
            VariableX = ex;
            VariableY = why;
        }

        public double CalculateDistance()
        {
            double dist = Math.Sqrt((VariableX * VariableX) + (VariableY * VariableY));
            Console.WriteLine($"It has a distance of {dist}");
            return dist;
          
        }

    }
}
