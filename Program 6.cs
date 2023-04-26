using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIsta2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P;
            double h;
            double IMC;

            Console.Write("insira o Peso da pessoa: ");
            P = double.Parse(Console.ReadLine());

            Console.Write("insira o Valor da altura da pessoa: ");
            h = double.Parse(Console.ReadLine());

            IMC = P / (Math.Pow(h,2));

            if (IMC < 20)
                Console.WriteLine("Abaixo do peso.");
            else
                    if (IMC < 25)
                    Console.WriteLine("Peso ideal");
                    else
                    Console.WriteLine("Acima do peso");
            {

            }
            {          

                           

            }
        }
    }
}
