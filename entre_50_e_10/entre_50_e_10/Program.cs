using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entre_50_e_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite Um Número:");
            n1 = double.Parse(Console.ReadLine());
            if (n1 >= 10 & n1 <= 50)
            {
                Console.Write("Seu Número Está Entre 10 e 50");
            }

            else
            {
                Console.WriteLine("Seu Número Não Está Entre 10 e 50 ");
            }
                    
              
            
            





        }
    }
}
