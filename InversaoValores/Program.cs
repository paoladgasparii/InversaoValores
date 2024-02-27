using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a, b, c;

            Console.WriteLine("Digite o valor do produto a: ");
            a = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto b: ");
            b = Console.ReadLine();

            c = a;
            a = b;
            b = c;

            Console.WriteLine("O novo valor de a é: " + a);
            Console.WriteLine("O novo valor de b é: " + b);
            Console.ReadKey();
        }
    }
}
