using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero += 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 += 15;
            numero2 += 30;
        }
        public static void Executar()
        {
            // No parâmetro ref é necessário inicializar 
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            // No parâmetro out não é necessário criar e inicializar 
            //a variável antes, pois ele só gera saída
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");
        }
    }
}
