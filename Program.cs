using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {   // Por L.R. Mendes, (c) 2022
            Console.WriteLine("(c)Raziel, 2022\n");
            
            Double altura, bas3, area;
            Console.Write("Escreva a base: ");
            bas3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nAgora escreva a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            area = bas3 * altura;
            Console.WriteLine("\nA area de seu retangulo é de " + area + ".");

            Console.Write("\nAperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
