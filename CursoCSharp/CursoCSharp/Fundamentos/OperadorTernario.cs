using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            // O tipo da variável deve ser compatível com a expressão chamada.
            Console.Write("Insira a nota alcançada: ");
            double nota = double.Parse(Console.ReadLine());
            
            Console.WriteLine("O aluno teve boa conduta?");
            bool bomComportamento = bool.Parse(Console.ReadLine());
           
            var resultado = nota >= 7.0 && bomComportamento 
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
