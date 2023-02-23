using HtmlAgilityPack;
using System;

namespace ScrappingTranspSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPessoas = 0;
            int valorMaiorMes = 0;
            int numeroMes = 1;
            for (int i = 1; i <= 12; i++)
            {
                var html = @"https://www.transparencia.se.gov.br/Pessoal/VencimentoCargo.xhtml?codigo=4&ano=2022&mes=11";
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);

                var tableComissionados = htmlDoc.GetElementbyId("frmPrincipal:Tabela1_data");
                var linhas = tableComissionados.SelectNodes(".//tr");
                int totalPessoas = 0;
                foreach (var item in linhas)
              
                {
                     var colunas = item.SelectNodes(".//td");
                    totalPessoas = totalPessoas + Convert.ToInt32(colunas[2].InnerText);
                }
                Console.WriteLine("Quantidade no mês {0} é de: {1} ", i, valorMes);
                if (valorMes > valorMaiorMes)
                {
                    numeroMes = i;
                    valorMaiorMes = valorMes;

                }  
                Console.WriteLine("O total preenchido é: {0} ", totalPessoas/12);
                Console.WriteLine("Mês com maior número de Pessos é: {0} ", numeroMes);
                Console.WriteLine("Total de pessoa no mes maior é: {0} ", valorMaiorMes);
            }
        }
    }
}