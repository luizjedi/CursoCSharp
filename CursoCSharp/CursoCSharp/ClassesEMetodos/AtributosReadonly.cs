using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento; // Readonly torna o atributo imutável
        // e permite sua inicialização dentro do construtor

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }
    }
    class AtributosReadonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Luiz Felipe",
                new DateTime(1994, 11, 29));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

        }
    }
}
