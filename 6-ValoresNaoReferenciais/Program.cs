using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ValoresNaoReferenciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6 - Variáveis guardam valores e não refenciais");

            int idade = 20;
            int novaIdade = idade;

            idade = 36;

            Console.WriteLine(idade);
            Console.WriteLine(novaIdade);

            Console.ReadLine();
        }
    }
}
