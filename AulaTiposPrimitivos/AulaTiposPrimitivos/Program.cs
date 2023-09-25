using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tipos Primitivos");

            string nome = "Mariane";
            short idade = 100;
            int numero = 20;
            long numerogrande = 1200000;
            Int32 teste = 10;
            System.Int32 outroteste = 10;
            byte item = 20;

            double comissao = 32.45787898798;
            decimal valor = Convert.ToDecimal(1000.56);
            decimal valor1 = 1000.56m;

            DateTime data;
            //ou
            DateTime data1 = DateTime.Now;

            DateTime dataexemplo = new DateTime(2024, 12, 31);

            //formatar

            Console.WriteLine("{0}", dataexemplo);
            Console.WriteLine("{0:d}", dataexemplo);
            Console.WriteLine("{0:D}", dataexemplo);
            Console.WriteLine("{0:ddd}", dataexemplo);
            Console.WriteLine("{0:dddd}", dataexemplo);

            Console.ReadLine();








        }
    }
}
