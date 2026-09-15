using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos
{
    internal class Program     //CRIE UM ALGORITIMO PARA CADASTRO DE PRODUTO: CODIGO, FABRICANTE, CATEGORIA,PREÇO, ESTOQUE, VALOR TOTAL EM ESTOQUE//
    {
        static void Main(string[] args)
        {
            int codigo, estoque;
            string fabricante, categoria;
            double preco, total;
            Console.WriteLine("Digite o Código: ");
            codigo = int.Parse(Console.ReadLine());   
            Console.WriteLine("Digite o Fabricante: ");
            fabricante = Console.ReadLine();
            Console.WriteLine("Digite a Categoria: ");
            categoria = Console.ReadLine();
            Console.WriteLine("Digite o Preço :");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Estoque:  ");
            estoque = int.Parse(Console.ReadLine()); 
            
            total = preco * estoque;
            Console.WriteLine("O Valor Total em Estoque é : " + total);








        }
    }
}
