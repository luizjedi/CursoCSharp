using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal (string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }
        /// <summary>
        /// Está sendo chamado um construtor base da classe "pai" Animal
        /// </summary>
        /// <param name="nome"></param>
        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        /// <summary>
        /// Está sendo chamado o construtor da classe Cachorro através do 
        /// operador this
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="altura"></param>
        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        /// <summary>
        /// O ToStrin converte o objeto para forma textual personalizada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $" {Nome} tem {Altura}cm de Altura!";
        }
    }



    class ConstrutorThis
    {
        public static void Executar()
        {
            var hanna = new Cachorro("Hanna");
            var kisar = new Cachorro("Kisar", 20.0);

            Console.WriteLine(hanna);
            Console.WriteLine(kisar);
        }
    }
}
