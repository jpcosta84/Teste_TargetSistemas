using System;
using System.Collections.Generic;

namespace Teste04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Faturamento> faturamentos = new List<Faturamento>();
            faturamentos.Add(new Faturamento()
            {
                Estado = "SP",
                Valor = 67836.43
            });

            faturamentos.Add(new Faturamento()
            {
                Estado = "RJ",
                Valor = 36678.66
            });

            faturamentos.Add(new Faturamento()
            {
                Estado = "MG",
                Valor = 29229.88
            });

            faturamentos.Add(new Faturamento()
            {
                Estado = "ES",
                Valor = 27165.48
            });

            faturamentos.Add(new Faturamento()
            {
                Estado = "Outros",
                Valor = 19849.53
            });

            double valorTotal = 0;
            foreach (var faturamento in faturamentos)
            {
                valorTotal = valorTotal + faturamento.Valor;
            }

            foreach (var faturamento in faturamentos)
            {
                var percentual = faturamento.Valor * 100 / valorTotal;

                Console.WriteLine("O percentual faturamento de " + faturamento.Estado + " é " + percentual);
            }

        }
    }
}
