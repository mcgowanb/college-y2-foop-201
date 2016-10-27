using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Area { get; set; }

        public Rectangle(int length, int width) : base()
        {
            Length = length;
            Width = width;
            Area = Length * Width;
        }

        public override string ToString()
        {
            return String.Format("Type: {0}\nLength: {1}\nWidth: {2}\nArea: {3}", type, Length, Width, Area);
        }
    }
}
