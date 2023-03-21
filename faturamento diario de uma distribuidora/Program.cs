using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace faturamento_diario_de_uma_distribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê o arquivo XML com os dados de faturamento mensal
            var xml = XDocument.Load("faturamento.xml");
            var faturamento = xml.Descendants("valor")
                                 .Select(e => (double)e)
                                 .ToArray();

            // Calcula o menor e o maior valor de faturamento
            double menor = faturamento.Min();
            double maior = faturamento.Max();

            // Calcula a média mensal de faturamento, excluindo dias sem faturamento
            double media = faturamento.Where(valor => valor > 0).Average();

            // Calcula o número de dias em que o faturamento diário foi superior à média mensal
            int acimaMedia = faturamento.Count(valor => valor > media);

            // Imprime os resultados
            Console.WriteLine($"Menor faturamento: R${menor:F2}");
            Console.WriteLine($"Maior faturamento: R${maior:F2}");
            Console.WriteLine($"Média mensal: R${media:F2}");
            Console.WriteLine($"Dias acima da média: {acimaMedia}");

            //Torna manual a saida da janela de console
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
