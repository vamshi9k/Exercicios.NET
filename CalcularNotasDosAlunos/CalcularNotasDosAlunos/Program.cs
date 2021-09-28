using System;

class CalcularNotasDosAlunos
{
     static void Main(string[] args)
    {
        double somNotas = 0;
        int cont = 0;

        do
        {
            double notEntradaConsole = double.Parse(Console.ReadLine());

            if (notEntradaConsole < 0 || notEntradaConsole > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                cont++;
                somNotas += notEntradaConsole;
            }
        } while (cont < 2);

        Console.WriteLine("media = " + (somNotas / 2).ToString("N2"));
    }

}

