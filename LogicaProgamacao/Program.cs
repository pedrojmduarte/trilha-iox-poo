using System;

namespace LogicaProgamacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 números inteiros:");

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o número a ser buscado:");

            int numeroBuscado = int.Parse(Console.ReadLine());
            bool numeroEncontrado = false;

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    numeroEncontrado = true;
                }
            }

            if (numeroEncontrado == true)
            {
                Console.WriteLine("O número " + numeroBuscado + " foi encontrado com sucesso!");
                if (numeroBuscado % 2 == 0)
                {
                    Console.WriteLine("O número buscado é par");
                }
                else
                {
                    Console.WriteLine("O número buscado é ímpar");
                }
            }
            else
            {
                Console.WriteLine("O número " + numeroBuscado + " não foi encontrado.");
            }

        }
    }
}
