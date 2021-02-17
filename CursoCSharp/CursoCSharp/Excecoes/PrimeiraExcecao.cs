using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor) //Método que pode causar um erro
        {
            if (valor > Saldo)
            { //Throw precisa ser incluido para que a execeção seja lançada.
                throw new ArgumentException("Saldo Insuficiente!");
            }

            Saldo -= valor;
        }
    }


    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try { //Como o método sacar pode gerar erro a chamada da função 
                  // deve ser feita com o "try".
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");

            } catch (Exception ex) // Recebe como parâmetro a exceção que 
            //aconteceu.
            {
                Console.WriteLine(ex.Message);
            }
            finally // Será executado em qualquer situação
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
