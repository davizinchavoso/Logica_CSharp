using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;
            Console.WriteLine("Digite o Primeiro Número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Número: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 - n2;
            Console.WriteLine("O resultado da subtração é: " + soma);






        }
    }
}
