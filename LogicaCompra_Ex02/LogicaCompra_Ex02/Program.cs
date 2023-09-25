using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompra_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            // formas de pagamento
            //Se o valor da compra for maior que R$1.000 , pode parcelar em  3x.
            // Se nã for, apenas a vista

            // Declaração das Variaveis

            decimal ValorCompra;
            int NumeroParcelas = 3;
            decimal ValorParcela;

            // Obtendo os valores

            Console.WriteLine("Digite o valor da compra : ");
            ValorCompra = Convert.ToDecimal(Console.ReadLine());

            // processamento

            if (ValorCompra >1000)
            {
                ValorParcela = ValorCompra / NumeroParcelas;
                Console.WriteLine("Você poderá dividir a sua compra em 03 parcelas de {0:c}", ValorParcela);
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Esta compra aceita apenas pagamento a vista");
                Console.ReadLine();

            }





        }
    }
}
