using System;
using System.IO;


namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            //Verifica qual o tipo de sistema operacional
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //@ antes de "" permite que o texto seja interpretado de
            // forma literal
            var path = @"~/primero_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                //Criar um streaming de string
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("novas informações");
                sw.WriteLine("no arquivo!");
            }
        }
    }
}
