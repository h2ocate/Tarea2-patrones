using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem2FactoryMethod
{
    public abstract class Zapatos
    {
        protected string _descripcion;
        protected string _origen;

        public void Render()
        {
            Console.WriteLine(String.Format("Zapatos {0} hecho en {1}", _descripcion, _origen));
        }
    }
}
