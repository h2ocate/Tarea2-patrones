using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem2FactoryMethod
{
    public class ZapatosTods : Zapatos
    {
        public ZapatosTods(string origen)
        {
            _descripcion = "Tod's";
            _origen = origen;
        }
    }
}
