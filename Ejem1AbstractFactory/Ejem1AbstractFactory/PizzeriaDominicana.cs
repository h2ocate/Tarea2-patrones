using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem1AbstractFactory
{
    public class PizzeriaDominicana : Pizzeria
    {
        public override Pizza CrearPizza()
        {
            return new PizzaCarne();
        }
    }
}
