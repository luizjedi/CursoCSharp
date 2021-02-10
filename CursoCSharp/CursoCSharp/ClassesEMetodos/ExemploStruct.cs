using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coodernada : Ponto
    {
        public int X;
        public int Y;

        public Coodernada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStruct
    {
        public static void Executar()
        {
            Coodernada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coodernada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);
             
            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);

        }
    }
}
