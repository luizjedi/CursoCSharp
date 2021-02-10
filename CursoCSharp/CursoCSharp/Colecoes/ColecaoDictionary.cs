using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); // chave, valor

            filmes.Add(2000, "Gladiator");
            filmes.Add(2002, "Spider-Man");
            filmes.Add(2004, "The Incribles");
            filmes.Add(2006, "O Grande Truque");

           // Utiliza a chave int para fazer a comparação
            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                //Caso nao esteja presente no dicionário ele retorna uma lista
                // vazia
                Console.WriteLine("2006 " + filmes.GetValueOrDefault(2008));
            }

            //Retorna um valor booleano ao analisar se o objeto está ou não contido
            //no dicionário
            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            Console.WriteLine(filmes.ContainsValue("Spider-Man"));

            //Retorna um valor booleano para indicar se o objeto foi removido
            //do dicionário
            
            //Este primeiro método gera erro no terminal caso o objeto não 
            //exista no dicionário
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            Console.WriteLine("2004 " + filmes.GetValueOrDefault(2004));

            // Terceiro método de pesquisa
            if (filmes.TryGetValue(2006, out string filme2006))
            {
                Console.WriteLine($"Filme {filme2006}!");
            }

            else
            {
                Console.WriteLine($"Filme inexistente!");
            }

            //Perconrrendo os elementos da lista por chave
            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            //Perconrrendo os elementos da lista por valores
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            //Percorrendo chaves e valores simultaneamente
            
            //1ª Forma
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}!");
            }

            //2ª Forma - Por inferência
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}!");
            }

        }
    }
}
