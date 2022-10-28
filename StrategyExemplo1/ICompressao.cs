using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//strategy
namespace StrategyExemplo1
{
    public interface ICompressao
    {
        void ComprimirArquivo(string nomeArquivo);
    }
}
