using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    /// <summary>
    /// O método static deve ser utilizado de forma direta na classe
    /// sem a criação de nenhuma instância
    /// </summary>
    public class CalculadoraEstatica
    {
        // Método de Classe ou Método Estático
        public  int Somar(int a, int b)
        {
            return a + b;
        }

        // Método de Instância
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            // Métodos sem static precisam ser utlizados através da criação
            // de instâncias
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,2));
          
        }
    }
}
