using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_DasafioFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio de fatorial");

            //Criando tabela de numeros fatoriais
            long fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine("A fotorial de " + i + " é " + fatorial);
            }


            Console.ReadLine();
        }
    }
}
