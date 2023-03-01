using System;

namespace Teste01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine("Ao fim do processamento a variável soma equivale à " + soma);
        }
    }
}
