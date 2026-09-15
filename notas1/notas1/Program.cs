using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            string nome;
            Console.WriteLine("Digite o nome do Aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Segunda Nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Terceira Nota: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quarta Nota: ");
            n4 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("O nome do aluno é " + nome + "e a média dele é " + media);












        }
    }
}
