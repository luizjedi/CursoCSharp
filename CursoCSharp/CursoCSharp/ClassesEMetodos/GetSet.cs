using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        /// <summary>
        /// Private permite tornar os atributos privados e portanto
        /// seguros contra alterações indesejadas
        /// </summary>
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            // Primeira opção

            //if(cilindrada > 0)
            //{
            //    Cilindrada = cilindrada;
            //}

            // Segunda opção 

            //Cilindrada = Math.Abs(cilindrada);

            Cilindrada = cilindrada; // Ao tornar o atributo private uint 
            //não será passado valor negativo
        }
    }

    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG TITAN");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() +
                " " + moto2.GetCilindrada());
        }
    }
}
