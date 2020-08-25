using System;
   
namespace Alguel_Carro.Entities
{
    class Aluguel
    {
        public DateTime Retirada { get; set; }
        public DateTime Devolução { get; set; }
        public Carro Carro { get; set; }
        public Fatura Fatura { get; set; }

        public Aluguel(DateTime retirada, DateTime devolução, Carro carro)
        {
            Retirada = retirada;
            Devolução = devolução;
            Carro = carro;
            Fatura = null;
        }
    }
}
