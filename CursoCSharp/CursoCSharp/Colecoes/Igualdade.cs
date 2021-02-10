using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2; // Apontam para o mesmo local de memória
          
            Console.WriteLine(p1 == p2);//Atribuição por Valor!!!
            Console.WriteLine(p2 == p3);//Atribuição por Referência!!!
            
            Console.WriteLine(p1.Equals(p2)); //Compara endereço de memória

        }
    }
}
