using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seq_de_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe o numero
            Console.Write("Informe um número para a sequência: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Retorna se o número está contido na sequência de fibonacci
            bool resposta = contidoEmFibonacci(numero);
            if(resposta == true)
            {
                Console.WriteLine("\nO número dado PERTENCE a sequência de fibonacci");
            }
            else{
                Console.WriteLine("\nO número dado NÃO PERTENCE a sequência de fibonacci");
            }

            //Torna manual a saida da janela de console
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }

        //Verifica se o número está contido na sequência de fibonacci
        public static bool contidoEmFibonacci(int n)
        {
            if (n < 0)
            {
                return false;
            }

            int a = 0;
            int b = 1;

            while (b < n)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return b == n;
        }
    }
}
