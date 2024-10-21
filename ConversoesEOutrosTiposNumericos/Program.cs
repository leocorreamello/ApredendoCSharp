using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            //Fazendo um Casting
            double salario = 1200.50;
            //O int é uma variavel de 32 bits
            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            //O long é uma variavel de 64 bits
            long idadeUniverso = 13000000000000;
            Console.WriteLine(idadeUniverso);

            //O short é uma variavel de 16 bits
            short idade = 19;
            Console.WriteLine(idade);

            //O Float é igual o double porem menos utilizado
            float numero = 20.5f;
            Console.WriteLine(numero);

            Console.ReadLine();
        }
    }
}
