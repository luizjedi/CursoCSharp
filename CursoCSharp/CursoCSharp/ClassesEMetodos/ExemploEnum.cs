using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    /// <summary>
    /// A estrutura enum permite criar a enumeração de objetos
    /// </summary>
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmePraFamilia = new Filme();
            filmePraFamilia.Titulo = "Vovozona 3";
            filmePraFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmePraFamilia.Titulo, 
                filmePraFamilia.GeneroDoFilme);
        }
    }
}
