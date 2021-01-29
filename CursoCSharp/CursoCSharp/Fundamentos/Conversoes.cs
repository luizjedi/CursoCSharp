using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;//Conversão implícita
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;//Conversão explícita
            Console.WriteLine("Nota Truncada: {0}\n", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);//Conversão entre string e inteiro
            Console.WriteLine("Idade inserida: {0}\n", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);//Conversão entre string e inteiro
            Console.WriteLine("Resultado: {0}\n", idadeInteiro);

            //Primeira forma
            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);//Caso o valor informado não seja compatível ele imprime o valor padrão "0".
            Console.WriteLine("O primeiro número digitado foi: {0}\n", numero);

            //Segunda forma
            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);//Caso o valor informado não seja compatível ele imprime o valor padrão "0".
            Console.WriteLine("O segundo número digitado foi: {0}\n", numero2);

        }
    }
}
