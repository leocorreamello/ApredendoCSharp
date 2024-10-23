using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncheado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            for (int contadorDeLinha = 0; contadorDeLinha <= 10; contadorDeLinha++)
            {
                for (int contadorDeColuna = 0; contadorDeColuna <= 10; contadorDeColuna++)
                {
                    Console.Write("*");
                    if (contadorDeColuna >= contadorDeLinha)
                        break;

                }
                Console.WriteLine();
            }

            for (int contadorDeLinha = 10; contadorDeLinha >= 0; contadorDeLinha--)
            {
                for (int contadorDeColuna = 0; contadorDeColuna <= 10; contadorDeColuna++)
                {
                    Console.Write("*");
                    if (contadorDeColuna >= contadorDeLinha)
                        break;

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
