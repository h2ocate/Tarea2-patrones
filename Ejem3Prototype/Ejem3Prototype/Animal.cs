using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem3Prototype
{
    class Animal : ICloneable
    {
        public int patas {get; set;}
        public String Nombre {get; set;}

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
