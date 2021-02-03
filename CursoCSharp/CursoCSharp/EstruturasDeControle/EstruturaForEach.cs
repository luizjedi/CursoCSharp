using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        /// <summary>
        /// O comando foreach percorre do primeiro ao último
        /// elemento da variável sem necessidade de criar contadores
        /// e laços de repetição.
        /// </summary>
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Luiz" };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
