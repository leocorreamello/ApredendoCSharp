using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TABUADA
            Console.WriteLine("Tabuada do 1 ao 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "x" + i + " = " + i * i);
            }

            Console.ReadLine();
        }
    }
}
