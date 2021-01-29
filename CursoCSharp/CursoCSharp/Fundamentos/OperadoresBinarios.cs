﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresBinarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            num1++;
            Console.WriteLine(num1);

            --num1;
            Console.WriteLine(num2);

            /*Operadores de adicação ou subtração depois da variável, 
             * tem precedência menor do que os operadores colocados antes*/

            Console.WriteLine(num1++ == --num2);
            Console.WriteLine($"{num1} {num2}");

        }
    }
}
