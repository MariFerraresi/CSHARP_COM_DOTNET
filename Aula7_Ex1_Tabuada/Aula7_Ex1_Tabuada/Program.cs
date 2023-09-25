using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7_Ex1_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            int resultado;

            Console.Write("Qual a tabuada que você deseja ver? Digite um número: ");
            tabuada = Convert.ToInt32(Console.ReadLine());


            for (int i=1; i<=10; i++)
                    {
                resultado = tabuada * i;
                Console.WriteLine("{0} X {1} = {2} ", tabuada, i, resultado);
               
            }

            Console.ReadLine();







        }
    }
}
