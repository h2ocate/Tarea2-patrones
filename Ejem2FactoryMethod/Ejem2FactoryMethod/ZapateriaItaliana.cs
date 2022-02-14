using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem2FactoryMethod
{
    public class ZapateriaItaliana: Zapateria
    {
        public override Zapatos CrearZapatos(string tipo)
        {
            if (tipo == "Salvatore")
            {
                return new ZapatosSalvatore("Italia");
            }
            else if (tipo == "Tod's")
            {
                return new ZapatosTods("Italia");
            }
            else
            {
                return null;
            }
        }
    }
}
