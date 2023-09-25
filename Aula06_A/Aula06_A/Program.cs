using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_A
{
    class Program
    {
        static void Main(string[] args)
        {

            int hora = DateTime.Now.Hour;

            if (hora>17)

            {
                Console.WriteLine("Boa Noite!");
                Console.ReadLine();

            }

            else if (hora > 11)
            {
                Console.WriteLine("Boa Tarde!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Bom Dia!");
                Console.ReadLine();

            }



        }
    }
}
