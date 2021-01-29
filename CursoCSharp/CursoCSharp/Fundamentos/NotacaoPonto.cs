using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            /* O ponto de interrogação permite o compilador 
             * analisar se a variável possui valor definido 
             * o que impede a ocorrência de um erro de variável nula.
             * Deixando o código mais seguro.*/
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
