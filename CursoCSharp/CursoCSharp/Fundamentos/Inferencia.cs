using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Luiz Felipe"; 
            // A inferência permite que o conteúdo da variável seja 
            // analisado automaticamente tipado.
            // Ao utilizar o recurso de inferência é necessário inicializar
            // a variável de imediato.
            Console.WriteLine(nome);
            
            // int idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
