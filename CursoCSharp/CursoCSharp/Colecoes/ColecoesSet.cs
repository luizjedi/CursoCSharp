using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>//Não permite que itens repetidos sejam adicionados
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                livro
            };

            carrinho.UnionWith(combo);//Adiciona todos os elementos da lista em uma única operação
            Console.WriteLine(carrinho.Count);//Quantos elementos possui o carrinho
            //carrinho.RemoveAt(3);//Remove o quarto elemento do carrinho

            foreach (var item in carrinho)
            {
                // Console.WriteLine(carrinho.IndexOf(item));//Imprime a posição do item
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}

