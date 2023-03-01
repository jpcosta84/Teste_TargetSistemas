using System;

namespace Teste05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string");
            string valor = Console.ReadLine();

            string stringInvertida = "";
            for (int i = valor.Length - 1; i >= 0; i--)
            {
                stringInvertida = stringInvertida + valor[i];
            }

            Console.WriteLine(stringInvertida);
        }
    }
}
