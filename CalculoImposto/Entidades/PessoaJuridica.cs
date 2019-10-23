using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoImposto.Entidades
{
    class PessoaJuridica : PessoaEntidade
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
            :base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double valorImposto()
        {
            double valor = 0.0;

            if (NumeroFuncionarios > 10)
            {
                valor = RendaAnual * 0.14;
            }
            else
            {
                valor = RendaAnual * 0.16;
            }

            return valor;
        }
    }
}
