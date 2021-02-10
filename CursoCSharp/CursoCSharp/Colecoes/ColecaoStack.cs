using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        public static void Executar()
        {
            //Primeiro a entrar é o último a sair
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            //Elimina o último elemento adicionado e retorna o que ficou no topo
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            //Retorna o objeto que esta no topo sem removê-lo
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
