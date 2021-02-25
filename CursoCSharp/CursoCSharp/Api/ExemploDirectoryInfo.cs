﻿using System;
using System.IO;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();//Criar a pasta 
            }

            Console.WriteLine("== Arquivos ==============");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Diretórios ============");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
