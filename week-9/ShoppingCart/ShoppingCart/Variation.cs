using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Variation
    {
        public Variation() { }

        public Variation(String type)
        {
            this.Type = type;
        }
        public String Type { get; set; }

        public override string ToString()
        {
            return Type;
        }

        public override bool Equals(object obj)
        {
            String s = (String)obj;
            return Type.Equals(s);
        }



    }
}
