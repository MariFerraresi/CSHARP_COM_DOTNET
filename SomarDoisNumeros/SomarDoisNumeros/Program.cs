using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarDoisNumeros
{    //Classe
    class Program
    {   //Método Principal
        static void Main(string[] args)
        {
            //Somar dois números

            int n1, n2, resultado;

            // A diferença entre WriteLine e Write, é que o WriteLine muda de linha para inserir o dado, e o Write insere
            // na mesma linha


            //Obtendo os valores

            Console.Write("Digite o número 1 : ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Processamento

            resultado = n1 + n2;


            //Exibir Resultado

            Console.WriteLine("O resultado da soma entre {0} e {1} é igual a {2}" , n1, n2, resultado);
            Console.ReadLine();


        }
    }
}
