using System;

namespace Ejem3Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal oAnimal = new Animal() {Nombre = "Perro" , patas = 4};
            //Clonamos los datos, pero hacemos que este no afecte a nuestro objeto asi es el uso de prototype Shallow,
            //aunque tome su valor se crea la distincion.
            Animal oAnimalClonado = oAnimal.Clone() as Animal;
            oAnimalClonado.patas = 5;
            Console.WriteLine("Nombre: " + oAnimal.Nombre);
            Console.WriteLine("Cantidad de patas: " + oAnimal.patas);
        }
    }
}
