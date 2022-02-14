using System;

namespace Ejem2FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Zapateria zapateria;
            Zapatos zapatos;

            zapateria = new ZapateriaItaliana();

            zapatos = zapateria.CrearZapatos("Salvatore");
            zapatos.Render();
            zapatos = zapateria.CrearZapatos("Tod's");
            zapatos.Render();
            Console.WriteLine("");

            zapateria = new ZapateriaChina();
            zapatos = zapateria.CrearZapatos("Salvatore");
            zapatos.Render();
            zapatos = zapateria.CrearZapatos("Tod's");
            zapatos.Render();
            Console.ReadKey();
        }
    }
}
