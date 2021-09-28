using System;

namespace ProgramaQueLeiaValoresDe_X_Y
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int numero1 = Convert.ToInt32(vet[0]);
            int numero2 = Convert.ToInt32(vet[1]);

            int contador = 1;
            string grupoNumeros = "";

            for (int i = 1; i < numero2; i++)
            {
                if (contador < numero1)
                {
                    contador++;
                    grupoNumeros += " " + i.ToString();

                    if (i == numero2 - 1)
                    {

                        Console.WriteLine(grupoNumeros.Trim()); //Trim(Char) = Remove todas as instâncias à esquerda e à direita da cadeia de caracteres atual.
                    }
                }
                else
                {
                    if (contador == numero1)
                    {
                        grupoNumeros += " " + i.ToString();
                        Console.WriteLine(grupoNumeros.Trim());
                        grupoNumeros = "";
                    }
                    else
                    {
                        grupoNumeros = "";

                    }
                    contador = 1;
                }
            }
        }

    }
}





