using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número entre 1 e 10: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // operadores || (ou) && (e)

            if (numero > 10 || numero < 1)
            {
                Console.WriteLine("Número Incorreto!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Obrigado!");
                Console.ReadLine();

            }


        }

            
           
    }
}
