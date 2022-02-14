using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem1AbstractFactory
{
    public abstract class Pizza
    {
        protected string _descripcion;

        public object Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}
