using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Cylinder : Shape
    {
        public int Radius { get; set; }
        public int Height { get; set; }
        public double Area { get; set; }

        public Cylinder(int r, int h) : base()
        {
            Radius = r;
            Height = h;
            Area = (2 * Math.PI * Math.Pow(Radius, 2)) + (Height * (2 * Math.PI * Radius));
        }

        public override string ToString()
        {
            return String.Format("Type: {0}\nRadius: {1}\nHeight: {2}\nArea: {3:000.00}", type, Radius, Height, Area);
        }
    }
}
