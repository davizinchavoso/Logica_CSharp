using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antecessor_sucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, menor, maior;
            Console.WriteLine("Escolha um Número:");
            n1 = int.Parse(Console.ReadLine());

            maior = n1 + 1;
            menor = n1 - 1;
            Console.WriteLine("O antecessor é: " + menor);
            Console.WriteLine("O sucessor é: " + maior);










        }
    }
}
