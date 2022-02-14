using System;
using System.Collections.Generic;
using System.Text;

namespace Ejem1AbstractFactory
{
    public class PizzeriaItalina: Pizzeria
    {
        public override Pizza CrearPizza()
        {
            return new PizzaMargherita();
        }
    }
}
