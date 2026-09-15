using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome; //CADEIA// //VARIAVEL//
            int idade; //INTEIRO//  //VARIAVEL//
            
            
            
            Console.WriteLine("Digite Seu Nome: "); //ESCREVA//
            nome = Console.ReadLine();   //LEIA//
            Console.WriteLine("Digite Sua Idade: ");
            idade = int.Parse(Console.ReadLine()); //CONVERTE O QUE DIGITAR PARA INTEIRO//
            Console.WriteLine("Parabéns" + nome + " Você Ganhou Uma Coca Cola!!! ");
            Console.WriteLine("\n Você Possui " + idade + " Anos, Beba Mais Água!!! ");




        }
    }
}
