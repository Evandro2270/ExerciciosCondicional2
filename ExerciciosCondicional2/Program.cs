using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                int x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    Console.WriteLine("Par! ");
                }
                else {
                    Console.WriteLine("Impar! ");
                }
            }
        }
    }
}