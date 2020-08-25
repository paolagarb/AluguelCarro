using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alguel_Carro.Entities;

namespace Alguel_Carro.Services
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private TaxaServico _taxaServico = new TaxaServico();

        public ServicoAluguel(double precoHora, double precoDia)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }

        public void ProcessarFatura(Aluguel aluguel)
        {
            TimeSpan duracao = aluguel.Devolução.Subtract(aluguel.Retirada);
            double PagamentoBasico = 0.00;
            if (duracao.TotalHours <= 12.0)
            {
                PagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours);
            } 
            else
            {
                PagamentoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _taxaServico.Imposto(PagamentoBasico);

            aluguel.Fatura = new Fatura(PagamentoBasico, imposto);
        }
    }
}
