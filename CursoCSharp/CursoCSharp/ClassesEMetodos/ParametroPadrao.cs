using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        /// <summary>
        /// O valor padrão possibilita a chamada do método sem que sejam
        ///inicializados todos atributos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7));
        }
    }
}
