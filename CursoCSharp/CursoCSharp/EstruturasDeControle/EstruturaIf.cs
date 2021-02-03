using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")  //primeira forma
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s"; //segunda forma
          
            bomComportamento = entrada.ToLower() == "s"; // Terceira forma

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra!");
            }
        }
    }
}
