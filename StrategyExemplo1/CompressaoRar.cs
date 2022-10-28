using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace StrategyExemplo1
{
    public class CompressaoRar : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado usando Rar " + $"\nUm Arquivo com extensão .rar foi criado");
        }
    }
}
