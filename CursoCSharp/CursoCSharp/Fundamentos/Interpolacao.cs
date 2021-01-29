﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;
            
            //Concatenação
            Console.WriteLine("O " + nome + " da marca " +
                marca + " custa R$ " + preco + ".");
            
            //Interpolação
            Console.WriteLine("O {0} da marca {1} custa R$ {2}.",
                nome, marca, preco);

            //Interpolação 2ª forma
            Console.WriteLine($"A marca {marca} é muito boa!");
            Console.WriteLine($"1 + 1 =  {1 + 1}!");
        }
    }
}
