using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        /// <summary>
        /// Params permite a criação de um array e o armazenamento de uma 
        /// quantidade indefinida de atributos, que podem ser acessado através 
        /// da estrutura foreach.
        /// </summary>
        /// <param name="pessoas"></param>
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Pedro","Manu","Luiz", "Yara");
        }
    }
}
