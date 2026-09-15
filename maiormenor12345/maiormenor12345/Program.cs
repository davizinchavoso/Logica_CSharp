using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maiormenor12345
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5;
            Console.WriteLine("Digite o Primeiro Número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Terceiro Número: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Quarto Número: ");
            n4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Quinto Número: ");
            n5 = double.Parse(Console.ReadLine());

            if (n1 > n2 & n1 > n3 & n1 > n4 & n1 > n5)
            {
                Console.WriteLine("O Maior Número é: " + n1);
            }
            else if (n2 > n1 & n2 > n3 & n2 > n4 & n2 > n5) { 
            Console.WriteLine("O maior número é: " + n2);
            }




            else if (n3 > n1 & n3 > n2 & n3 > n4 & n3 > n5)
            {
                Console.WriteLine("O maior Número é: " + n3);
            }
            else if (n4 > n1 & n4 > n2 & n4 > n3 & n4 > n5)
            {
                Console.WriteLine("O Maior Número é: " + n4);

            }
            else
            {
                Console.WriteLine("O maior número é: " + n5);
            }














        }
    }
}
