using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem Horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com Hora atual
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora:" + diaAtual.Hour);
            Console.WriteLine("Minutes:" + diaAtual.Minute);

            //Próximo dia
            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd"));//dia
            Console.WriteLine(diaAtual.ToString("d"));//dia/mes/ano
            Console.WriteLine(diaAtual.ToString("D"));//Descrição completa
            
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));


        }
    }
}
