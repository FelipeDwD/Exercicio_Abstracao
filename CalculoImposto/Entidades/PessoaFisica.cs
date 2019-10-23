using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoImposto.Entidades
{
    class PessoaFisica : PessoaEntidade
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
            : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double valorImposto()
        {
            double valor = 0.0;

            if (RendaAnual < 20000.00)
            {
                valor = RendaAnual * 0.15;
            }
            else
            {
                valor = RendaAnual * 0.25;
            }         

            if (GastosSaude != 0)
            {
                valor -= GastosSaude / 2;
            }

            return valor;
        }
    }
}
