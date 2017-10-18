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
        private double q;
        private double z;

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

        public double VariableQ
        {
            set { q = value; }
            get { return q; }
        }

        public double VariableZ
        {
            set { z = value; }
            get { return z; }
        }

        public Point()
        {
            VariableX = 0;
            VariableY = 0;
            VariableQ = 0;
            VariableZ = 0;
        }

        public Point(double ex, double why, double queue, double zee)
        {
            VariableX = ex;
            VariableY = why;
            VariableQ = queue;
            VariableZ = zee;
        }

        public double CalculateDistance()
        {
            double mid1 = ((VariableX + VariableQ)/2);
            double mid2 = ((VariableY + VariableZ) / 2);
            Console.WriteLine($"The midpoint is ({mid1}, {mid2})");
            return mid1;
            return mid2;
          
        }

    }
}
