using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINK2
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

            //Single permite filtrar elementos que sejam exatamente iguais 
            // aos declarados em sua chamada, caso não exista nenhum igual
            // ela retornará um erro.
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            //Trata o erro gerado no caso de o elemento filtrado ser 
            //inexistente.
            var fulano = alunos.SingleOrDefault(aluno =>
            aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno não encontrado!!!");
            }
            else
            {
                Console.WriteLine($"{fulano.Nome} {fulano.Nota}");
            }

            //Pega a primeira ocorrência que se encaixar nos parâmetros 
            //solicitados.
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            ////Trata o erro gerado no caso de o elemento filtrado ser 
            //inexistente.
            var sicrano = alunos.FirstOrDefault(
                aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno não encontrado!!!");
            }
            else
            {
                Console.WriteLine($"{fulano.Nome} {fulano.Nota}");
            }

            //Pega a última ocorrência que se encaixar nos parâmetros 
            //solicitados.
            var outraAna = alunos.Last(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            ////Trata o erro gerado no caso de o elemento filtrado ser 
            //inexistente.
            var sicrana = alunos.LastOrDefault(
                aluno => aluno.Nome.Equals("Sicrana"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno não encontrado!!!");
            }
            else
            {
                Console.WriteLine($"{fulano.Nome} {fulano.Nota}");
            }

            //Pula 1 aluno e pega os próximos 3.
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var aluno in exemploSkip)
            {
                Console.WriteLine(aluno.Nome);
            }

            //Filtra o maior valor
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            //Filtra o menor valor
            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            //Somatório
            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            //Média dos valores
            var mediaNota = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNota);

            //Média de alunos aprovados
            var mediaNotaAprovados = alunos.Where(
                a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotaAprovados);
        }
    }
}
