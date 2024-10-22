using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executnado o projeto 11 - Calcula Poupança 2");

            //0,36% = 0,0036
            double valorInvestido = 1000;

            for (int i = 1; i <= 12; i++)
            {
                //valorInvestido = valorInvestido + valorInvestido * 0.0036; é igual a linha baixo
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + i + " meses, você terá R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
