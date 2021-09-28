using System;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis

            int a = Convert.ToInt32(vet[0]);
            int b = Convert.ToInt32(vet[1]);
            int c = Convert.ToInt32(vet[2]);

            int maiorAB = ((a + b + Math.Abs(a - b)) / 2);

            int maior = ((maiorAB + c + Math.Abs(maiorAB - c)) / 2);

            Console.WriteLine($"{maior} eh o maior");

        }
    }

}
