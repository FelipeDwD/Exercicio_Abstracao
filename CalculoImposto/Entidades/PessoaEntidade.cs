using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CalculoImposto.Entidades
{
    abstract class PessoaEntidade
    {
        public string Nome { get; set; }

        public double RendaAnual { get; set; }

        public PessoaEntidade(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double valorImposto();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nome: ");
            sb.Append(Nome);
            sb.Append(" - R$ ");
            sb.Append(valorImposto().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
