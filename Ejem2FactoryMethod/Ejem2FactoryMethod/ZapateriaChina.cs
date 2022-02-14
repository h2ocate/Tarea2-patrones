using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem2FactoryMethod
{
    public class ZapateriaChina : Zapateria
    {    
    
                public override Zapatos CrearZapatos(string tipo)
                {
                    if (tipo == "Salvatore")
                    {
                        return new ZapatosSalvatore("China");
                    }
                    else if (tipo == "Tod's")
                    {
                        return new ZapatosTods("China");
                    }
                    else
                    {
                        return null;
                    }
                }
            }
}
