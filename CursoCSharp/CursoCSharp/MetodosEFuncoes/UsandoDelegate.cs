﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b)
        {

            Console.WriteLine((a + b).ToString("F2")); // Formatar para duas 
                                                       //casas decimais
        }


        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 4.9));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            //Func necessita que sejam informados os tipos de entrada 
            //e o tipo de saída
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5,3));

            //Action só se informam os dados de entrada 
            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 23.4);
        }
    }
}
