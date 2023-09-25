using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = DateTime.Now.Hour;
            string mensagem = String.Empty;

            switch (hora)
            {
                case 10:
                case 15:
                    mensagem = "Hora do intervalo";
                    break;
                case 12:
                    mensagem = "Hora do Almoço";
                    break;
                case 17:
                    mensagem = "Hora de dar Tchau";
                    break;


            }

            Console.WriteLine("Hora de manter o foco nos estudos!!!");
            Console.ReadLine();






        }
    }
}
