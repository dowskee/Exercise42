using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
{
    class Point
    {
        private int x;
        private int y;

        public int VariableX
        {
            set { x = value; }
            get { return x; }
        }

        public int VariableY
        {
            set { y = value; }
            get { return y; }
        }

        public Point()
        {
            VariableX = 0;
            VariableY = 0;
        }

        public Point(int ex, int why)
        {
            VariableX = ex;
            VariableY = why;
        }
    }
}
