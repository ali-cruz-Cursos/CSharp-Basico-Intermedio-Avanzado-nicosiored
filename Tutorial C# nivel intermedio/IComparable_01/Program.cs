using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CRectangulo[] rects = new CRectangulo[5];

            rects[0] = new CRectangulo(6, 7);
            rects[1] = new CRectangulo(4, 6);
            rects[2] = new CRectangulo(4, 3);
            rects[3] = new CRectangulo(7, 6);
            rects[4] = new CRectangulo(5, 7);

            foreach (CRectangulo r in rects)
            {
                Console.WriteLine($"{r}");
            }

            Console.WriteLine("\n\nArray.Sort(rects)\n\n");

            // Hacemos uso de sort, el cual necesita la implementacion de IComparable
            Array.Sort(rects);


            foreach (CRectangulo r in rects)
            {
                Console.WriteLine(r);
            }

            Console.ReadLine();
        }
    }
}
