using System;
using System.Globalization;

namespace ProdutosEmUmPlano
{
    class Program
    {

        static void Main(string[] args)
        {
            //complete os espaços em branco com sua solução para o problema

            string[] valores = Console.ReadLine().Split(' ');   //Strings.Split(String, String, Int32, CompareMethod) Método = Retorna uma matriz unidimensional baseada em zero que contém um número especificado de subcadeias de caracteres.
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);
            // Converta um string em um número chamando o Parse (https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number)

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q2");
            }

        }

    }
}
