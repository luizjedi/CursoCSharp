using System;
using System.Globalization;//Não pega os símbolos padrões da própria máquina

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");

            /* Função .Parse converte um tipo de entrada em 
             * outro tipo de saída.*/
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);/* Serve para ignorar a 
                * formatação padrão da minha região*/

            Console.WriteLine($"{nome}, {idade} anos, R${salario}");

        }
    }
}
