using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)//Método protegido, não sendo 
                                                  //possível acessar diretamente pela main
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }
        /// <summary>
        /// Virtual permite que a classe possa ser sobrescrita se necessário
        /// </summary>
        /// <returns></returns>
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro // Significa que a classe Uno está herdando os 
                             //métodos e atributos da classe carro
    {
        /// <summary>
        /// Como não foi criado construtor padrão na classe carro é preciso
        ///chamar o construtor base dentro da própria classe e informar o 
        ///parâmetro a ser utilizado
        /// </summary>
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }
        /// <summary>
        /// Override serve para sobrescrever um método
        /// existente na classe pai
        /// </summary>
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        /// <summary>
        /// Ao utilizar o operador new oculta o método da classe pai, sem precisar utilizar
        /// "virtual" ou "override"
        /// </summary>
        /// <returns></returns>
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }

    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Ferrari...");
            Ferrari
                carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com o tipo Carro...;;");
            Carro carro3 = new Ferrari(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com o tipo Carro...;;");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

