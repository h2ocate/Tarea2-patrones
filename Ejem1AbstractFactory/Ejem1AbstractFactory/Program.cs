
using System;

namespace Ejem1AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria Fabrica;

            Fabrica = new PizzeriaItalina();
            Pizza pizza = Fabrica.CrearPizza();
            Console.WriteLine($"Pizza Italiana: {pizza.Descripcion}");
            Console.WriteLine("");
            Fabrica = new PizzeriaDominicana();
            pizza = Fabrica.CrearPizza();
            Console.WriteLine($"Pizza Dominicana: {pizza.Descripcion}");
            Console.ReadKey();
        }
    }
}
