using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            // Permite a alocação de elementos repetidos
            fila.Enqueue("Hanna");
            fila.Enqueue("Luiz");
            fila.Enqueue("Guaraci");
            fila.Enqueue("Guaraci");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // Retira o primeiro elemento da fila
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            // É preciso importar "using System.Collections;" para utilizar
            // o Queue Collections
            var salada = new Queue();

            // Permite a alocação de diferentes tipos 
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            // Contains verifica a existência de um item na fila
            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
