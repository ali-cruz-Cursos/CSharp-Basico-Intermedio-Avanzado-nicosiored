using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesGenericas_02
{
    class CPunto :IComparable<CPunto>
    {
        private int x;
        private int y;

        public CPunto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format($"X={x}, Y={y}");
        }

        public int CompareTo(CPunto b)
        {
            double magA = Math.Sqrt(x * x + y * y);
            double magB = Math.Sqrt(b.x * b.x + b.y * b.y);

            if (magA > magB)
                return 1;
            if (magA < magB)
                return -1;
            else
                return 0;
        }
                           
    }
}
