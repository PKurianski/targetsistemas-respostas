using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faturamento_mensal_de_uma_distribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo o valor do faturamento mensal por estado
            decimal sp = 67836.43M;
            decimal rj = 36678.66M;
            decimal mg = 29229.88M;
            decimal es = 27165.48M;
            decimal outros = 19849.53M;

            // Calculando o valor total mensal da distribuidora
            decimal total = sp + rj + mg + es + outros;

            // Calculando o percentual de representação de cada estado
            decimal percSP = (sp / total) * 100;
            decimal percRJ = (rj / total) * 100;
            decimal percMG = (mg / total) * 100;
            decimal percES = (es / total) * 100;
            decimal percOutros = (outros / total) * 100;

            // Exibindo os resultados
            Console.WriteLine("Percentual de representação do faturamento mensal por estado:");
            Console.WriteLine("SP: {0:F2}%", percSP);
            Console.WriteLine("RJ: {0:F2}%", percRJ);
            Console.WriteLine("MG: {0:F2}%", percMG);
            Console.WriteLine("ES: {0:F2}%", percES);
            Console.WriteLine("MG: {0:F2}%", percMG);
            Console.WriteLine("Outros: {0:F2}%", percOutros);

            //Torna manual a saida da janela de console
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
