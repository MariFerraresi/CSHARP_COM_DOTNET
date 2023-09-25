using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a quantidade adquirida:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            //processamento
            decimal total = valor * quantidade;

            Console.WriteLine("O total da sua compra é {0:c} !", total);
            Console.ReadLine();


        }
    }
}
