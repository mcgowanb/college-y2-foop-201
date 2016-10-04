using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSquares
{
    public class Square
    {
        private int sideLength;
        private int area;

        public int SideLength {
            get { return area; }
        }
        public int Area {
            get { return area; }
        }

        public Square(int sideLength)
        {
            this.sideLength = sideLength;
            this.area = ComputeArea();
        }

        private int ComputeArea()
        {
            return sideLength * sideLength;
        }

        public override string ToString()
        {
            return String.Format("The area of a {0} by {0} circle is {1}", sideLength, area);
        }
    }
}
