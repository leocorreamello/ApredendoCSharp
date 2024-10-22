using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executnado o projeto 10 - Calcula Poupança");

            //0,36% = 0,0036
            double valorInvestido = 1000;
            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 1 mês, você terá R$ " + valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 2 meses, você terá R$ " + valorInvestido);

            //Inicializando com While
            int contadorMes = 0;
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                contadorMes++;
            }
            Console.WriteLine("Após 12 meses, voce terá R$ " + valorInvestido);

            //Inicializando com For
            for (int i = 0; i <= 12; i++)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
            }
            Console.WriteLine("Após 12 meses, voce terá R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}
