using System;

namespace StrategyExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Padrão Strategey ##\n");

            CompressaoContext ctx = new CompressaoContext(new CompressaoRar());

            Console.WriteLine("Informa o nome do arquivo a comprimir");
            var nomeArquivo = Console.ReadLine();

            Console.WriteLine("\nInforme o tipo de compressão a ser usada");
            Console.WriteLine("1-Rar - 2-Zip - 3-Gzip\n");

            var opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 2:
                    ctx.DefineStrategy(new CompressaoZip());
                    break;
                case 3:
                    ctx.DefineStrategy(new CompressaoGzip());
                    break;
            }
            ctx.CriarArquivoCompactado(nomeArquivo);
            Console.Read();
        }
    }
}
