using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Comentarios
    {
        /// <summary>
        /// Esse método explica as possibilidades ao se criar 
        /// comentários
        /// </summary>
        public static void Executar()
        {
            //Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");
            //Basta colocar "///" e ele é criado automaticamente
            Console.WriteLine("O C# tem o XML Comments");

            /*
             * Esse é um comentário
             * de múltiplas linhas...
             */
            Console.WriteLine("Linhas de código podem ser transformadas em");
            Console.WriteLine("comentários através do atalho Ctrl+K, Ctrl+C");
            Console.WriteLine("Ctrl+K, Ctrl+U retorna o comentário para código");
            //Para que essa função seja utilizada é necessário selecionar
            //a parte do código desejada
        }
    }
}