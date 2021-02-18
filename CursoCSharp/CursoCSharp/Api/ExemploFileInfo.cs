using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                //Se existir algum arquivo com o mesmo nome, ele será
                //deletado
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }
        /// <summary>
        /// Será criado uma arquivo de origem e feita uma cópia do mesmo,
        /// e o arquivo de origem será movido para o arquivo destino,
        /// restando dois arquivos ao final da execução do programa.
        /// O arq_destino e o arq_copia.
        /// </summary>
        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoCopia, caminhoDestino);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
