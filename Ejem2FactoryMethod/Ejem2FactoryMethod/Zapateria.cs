using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem2FactoryMethod
{
    public abstract class Zapateria
    {
        public abstract Zapatos CrearZapatos(string tipo);
    }
}
