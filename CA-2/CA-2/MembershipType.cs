using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_2
{
    class MembershipType
    {
        public String Type { get; set; }

        //constructor
        public MembershipType(String type)
        {
            Type = type;
        }

        //default no args constructor
        public MembershipType()
        {

        }

        //overriding ToString to return text
        public override string ToString()
        {
            return Type;
        }

        //overriding the Equals method to run comparison by string value
        //rather than object type
        public override bool Equals(object obj)
        {
            String s = (String)obj;
            return Type.Equals(s);
        }
    }
}
