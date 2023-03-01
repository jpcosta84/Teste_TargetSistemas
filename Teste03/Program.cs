using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Teste03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader r = new StreamReader("C:\\repos\\TesteJoao\\Teste03\\dados.json");
            string json = r.ReadToEnd();
            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            Faturamento menorFaturamentoMes = faturamentos[0];
            Faturamento maiorFaturamentoMes = faturamentos[0];
            int diasComFaturamento = 0;
            double valorTotal = 0;

            foreach (Faturamento faturamento in faturamentos)
            {
                if (faturamento.Valor < menorFaturamentoMes.Valor)
                {
                    menorFaturamentoMes = faturamento;
                }
                if (faturamento.Valor > menorFaturamentoMes.Valor)
                {
                    maiorFaturamentoMes = faturamento;
                }
                if (faturamento.Valor > 0)
                {
                    valorTotal = valorTotal + faturamento.Valor;
                    diasComFaturamento++;
                }
            }

            double media = valorTotal / diasComFaturamento;
            int diasMaioresQueAMedia = 0;

            foreach (Faturamento faturamento in faturamentos)
            {
                if (faturamento.Valor > media)
                {
                    diasMaioresQueAMedia++;
                }
            }

            Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês é " + menorFaturamentoMes.Valor);
            Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês é " + maiorFaturamentoMes.Valor);
            Console.WriteLine("Número de dias no mês em que o valor de faturamento diário foi superior à média mensal é " + diasMaioresQueAMedia);
        }
    }
}
