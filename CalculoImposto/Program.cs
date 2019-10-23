using CalculoImposto.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculoImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPago = 0.0;
            List<PessoaEntidade> listGenerica = new List<PessoaEntidade>();
            

            Console.WriteLine("Qual o número de pagadores? ");
            int pagadores = int.Parse(Console.ReadLine());

            for (int i = 0; i < pagadores; i++)
            {
                Console.WriteLine($"Digite os dados do {(i+1)}º pagador: ");

                Console.Write("F - Fisica ou J - Juridica: ");
                char tipoEntidade = char.Parse(Console.ReadLine());

                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write($"Qual foi a renda anual do(a) {nome}? ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipoEntidade == 'F')
                {
                    Console.Write($"Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listGenerica.Add( new PessoaFisica(nome, rendaAnual, gastosSaude));

                }else if (tipoEntidade == 'J')
                {
                    Console.Write($"Quantos funcionários {nome} tem: ");
                    int quantidadeFuncionarios = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listGenerica.Add(new PessoaJuridica(nome, rendaAnual, quantidadeFuncionarios));
                }
            }

            Console.WriteLine("Taxas pagas: ");

            foreach (PessoaEntidade pe in listGenerica)
            {
                Console.WriteLine(pe);
                totalPago += pe.valorImposto();
            }

            Console.WriteLine();
            Console.WriteLine($"Taxa total: {totalPago.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
