using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverter_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe a string do usuario e insere os caracteres em um array
            Console.Write("Digite uma string: ");
            string original = Console.ReadLine();
            char[] caracteres = original.ToCharArray();
            int tamanho = caracteres.Length;

            //Inverte o conteudo
            for (int i = 0; i < tamanho / 2; i++)
            {
                char temp = caracteres[i];
                caracteres[i] = caracteres[tamanho - 1 - i];
                caracteres[tamanho - 1 - i] = temp;
            }

            //Imprime os resuultados
            string invertida = new string(caracteres);
            Console.WriteLine("\nString original: {0}", original);
            Console.WriteLine("String invertida: {0}", invertida);

            //Torna manual a saida da janela de console
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
