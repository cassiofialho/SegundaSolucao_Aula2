using System;

namespace _02_ComandoRepeticaoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Tabuada 1 ao 10:");

            Console.WriteLine();

            while (num1 <= 10)
            {
                num2 = 0;
                Console.WriteLine();
                Console.WriteLine($"Tabuada do {num1}");
                while(num2 <= 10)
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    num2++;
                }
                num1++;
            }            

            Console.ReadKey();
        }
    }
}