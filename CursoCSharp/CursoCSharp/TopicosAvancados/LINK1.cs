using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINK1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "André", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Júlia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Márcio", Idade = 18, Nota = 6.8},
            };

            Console.WriteLine("== Aprovados ================");

            //A função Where permite que um ou mais atributos de uma classe sejam
            //acessados através da função lambda e que comparações sejam feitas.
            var aprovados = alunos.Where(a => a.Nota > 7.0)
                .OrderBy(a => a.Nome);//OrderBy organiza em ordem crescente ou decrescente
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n\n== Reprovados ===============");

            var reprovados = alunos.Where(a => a.Nota < 7.0)
                .OrderBy(a => a.Nome);
            foreach (var aluno in reprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            //A função Select irá criar um array composto apenas pelo tipo
            //string do Nome. Os outros atributos da classe serão descartados
            //nessa nova lista.
            Console.WriteLine("\n\n== Chamada ==================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n\n== Aprovados (por Idade) ====");
            var alunosAprovados = from aluno in alunos
                                  where aluno.Nota >= 7
                                  orderby aluno.Idade
                                  select aluno.Nome;
            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
