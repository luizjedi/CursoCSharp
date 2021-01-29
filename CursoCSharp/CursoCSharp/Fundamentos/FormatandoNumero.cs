using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
             Console.WriteLine(valor.ToString("F1"));//Arredonda o valor para 1 casa decimal.
             Console.WriteLine(valor.ToString("C"));//Adiciona símbolo monetário.
             Console.WriteLine(valor.ToString("P"));//Multiplica por cem e add % no final.
             Console.WriteLine(valor.ToString("#.##"));//Duas casas decimais.

            CultureInfo cultura = new CultureInfo("en-US");//Permite padronizar a formatação para uma cultura específica.
            Console.WriteLine(valor.ToString("C3", cultura));

        }
    }
}
