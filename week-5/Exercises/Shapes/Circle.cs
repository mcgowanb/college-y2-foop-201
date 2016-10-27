using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public int Radius { get; set; }

        private double area;

        public double Area
        {
            get { return area; }
        }
        public Circle(int r) : base()
        {
            Radius = r;
            area = Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return String.Format("Type: {0}\nRadius: {1}\nArea: {2:0,000.00}", type, Radius, Area);
        }
    }
}
