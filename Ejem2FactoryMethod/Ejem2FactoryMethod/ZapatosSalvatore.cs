using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem2FactoryMethod
{
    public class ZapatosSalvatore : Zapatos
    {
       public ZapatosSalvatore(string origen)
        {
            _descripcion = "Salvatore Ferragamo";
            _origen = origen;
        }
    }
}
