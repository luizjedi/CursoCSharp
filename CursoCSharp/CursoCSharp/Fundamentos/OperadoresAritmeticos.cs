using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço com Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);

            Console.WriteLine("O preço final é {0}\n", totalComDesconto);

            //Calculo IMC
            double peso = 62.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);//Operador de potenciação
            Console.WriteLine($"O IMC é {imc.ToString("#.##")}.");

            //Número Par/Ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
