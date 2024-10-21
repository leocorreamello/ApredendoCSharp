using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executnado o projeto 8 - Condicionais2");
            //CTRL+K + D --> para organizar o codigo

            int idadeJoao = 16;
            int quantidadeDePesosas = 2;
            //Variavel boleana
            bool acompanhado = quantidadeDePesosas >= 2;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode Entrar!");
            }
            else
            {
                Console.WriteLine("Não pode Entrar!");
            }

            Console.ReadLine();
        }
    }
}
