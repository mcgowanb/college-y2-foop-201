using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape
    {
        protected String type;

        public Shape()
        {
            String[] tAry = GetType().ToString().Split('.');
            type = tAry[1];
        }
    }
}
