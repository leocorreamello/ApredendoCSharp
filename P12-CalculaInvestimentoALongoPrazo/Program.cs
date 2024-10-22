using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoALongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executnado o projeto 12 - Calcula Investimento a Longo Prazo");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int i = 1; i <= 12; i++)
            {   
                valorInvestido *= fatorRendimento;
                Console.WriteLine("Após " + i + " meses, você terá R$ " + valorInvestido);
                fatorRendimento += 0.0010;
            }

            Console.ReadLine();
        }
    }
}
