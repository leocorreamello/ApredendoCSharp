using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executnado o projeto 5 - Caracteres e textos");

            //Charcter
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //Utilizando a ASCII table para os codigos dos Números
            primeiraLetra = (char)76;
            Console.Write(primeiraLetra);
            char segundaLetra = (char)69;
            Console.Write(segundaLetra);
            char terceiraLetra = (char)(primeiraLetra + 3); //O = 79
            Console.WriteLine(terceiraLetra);
            //Com isso escrevi o meu nome Leo

            //String
            string texto = "Curso de CSharp na Alura!";
            //Utiliznado o @ para modificar o texto
            string textoFormatado = 
@"Olá
Me chamo
Leonardo!";

            Console.WriteLine(texto);
            Console.WriteLine(textoFormatado);


            Console.ReadLine();
        }
    }
}
