using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executnado o projeto 7 - Condicionais");
            //CTRL+K + D --> para organizar o codigo

            int idadeJoao = 18;
            int quantidadeDePesosas = 1;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Pode Entrar!");
            }
            else
            {
                if (quantidadeDePesosas >= 2)
                {
                    Console.WriteLine("João não é maior que 18, porem está acompanhado pode entrar");
                }
                else
                {
                    Console.WriteLine("Não pode Entrar!");
                }
            }


            Console.ReadLine();
        }
    }
}
