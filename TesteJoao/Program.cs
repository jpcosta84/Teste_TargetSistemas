using System;

namespace TesteJoao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            var numeroDigitado = int.Parse(Console.ReadLine());

            var fibonacci = 0;
            var numeroAnterior = 0;
            var numeroAtual = 1;

            while (fibonacci < numeroDigitado)
            {
                fibonacci = numeroAnterior + numeroAtual;
                
                if(numeroDigitado == fibonacci)
                {
                    Console.WriteLine("Número pertence à sequencia de fibonacci");
                }

                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }
        }
    }
}
