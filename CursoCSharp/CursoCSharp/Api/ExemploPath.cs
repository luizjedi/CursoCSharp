using System;
using System.IO;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta.txt".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo Criado!");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
           
            Console.WriteLine("\n\n");
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            Console.WriteLine("\n\n");
            Console.WriteLine(Path.GetExtension(pasta));
            Console.WriteLine(Path.GetFileName(pasta));
            Console.WriteLine(Path.GetFileNameWithoutExtension(pasta));
            Console.WriteLine(Path.GetDirectoryName(pasta));
            Console.WriteLine(Path.HasExtension(pasta));
        }
    }
}
