using System;

namespace Orientacao.Poliformismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.SomAnimal();

            Cachorro cachorro = new Cachorro();
            cachorro.SomAnimal();

            Gato gato = new Gato();
            gato.SomAnimal();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Digite algo para sair ..");
            Console.ReadLine();

        }

        public class Animal
        {
            public virtual void SomAnimal()
            {
                Console.WriteLine("Animal faz somm");
            }
        }
        public class Cachorro : Animal { 
            public override void SomAnimal()
            {
                Console.WriteLine("Cachorro Lati");

            }
        }

        public class Gato : Animal
        {
            public override void SomAnimal()
            {
                Console.WriteLine("Gato faz miauuuu");
            }
        }


    }
}
