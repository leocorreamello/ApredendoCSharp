using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_DesafioRestoDaDivisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio de resto de Divisão");

            int numeroEscolhido = 13;
            if (numeroEscolhido % 3 == 0)
            {
                Console.WriteLine("Esse " + numeroEscolhido + " é divisivel por 3!");
            }
            else
            {
                Console.WriteLine("Esse " + numeroEscolhido + " não é divisivel por 3!");
            }

            Console.WriteLine(); //Quebrar a linha!

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("(: O número " + i + " é divisivel por 3!");
                }
                else
                {
                    Console.WriteLine("): O número " + i + " não é divisivel por 3!");
                }
            }

            Console.ReadLine();
        }
    }
}
