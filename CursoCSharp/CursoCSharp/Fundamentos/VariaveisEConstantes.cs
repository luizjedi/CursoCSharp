using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        { // area da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O Saldo de Gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Tipo mais usado
            Console.WriteLine("Menor valor é " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("A população total é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor de Long é " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial é " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //Tipo mais usado
            Console.WriteLine("Valor de Mercado " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine("O Texto é " + texto);
        }
    }
}
