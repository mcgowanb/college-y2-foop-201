using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    abstract class Variation
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class ColourVariation : Variation
    {
        public String AdditionalInfo { get; set; }
        public ColourVariation(String type, String additionalInfo) : base(type)
        {
            AdditionalInfo = additionalInfo;
        }

        public override string ToString()
        {
            return base.ToString() + " " + AdditionalInfo;
        }

        public override bool Equals(object obj)
        {
            String s = (String)obj;
            return this.ToString().Equals(s);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class GenderVariation : Variation
    {
        public GenderVariation(String type): base(type)
        {

        }
    }
}
