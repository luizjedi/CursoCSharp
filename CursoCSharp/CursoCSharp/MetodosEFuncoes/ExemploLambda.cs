using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //Action cria somente um referência ao método sem 
            //a necessidade de se criar nenhuma variável.

            //Sem parâmetros!!!
            Action algoNoConsole = () => // "=>" sintáxe para lambda no C#
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            // Com parâmetros!!!
            Action<string> algoNoConsole1 = (a) => // "=>" sintáxe para lambda no C#
            {
                Console.WriteLine("Lambda com C#!" + a);
            };

            algoNoConsole1("!!!!");

            Func<int> jogarDado = () =>
            {
                Random random = new Random(); //Essa funcão sorteia valores aleatórios
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero =>
            numero.ToString("X");

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(29,11,1994));
            
        }
    }
}
