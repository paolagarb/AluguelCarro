using System.Globalization;
using System.Text;

namespace Alguel_Carro.Entities
{
    public class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public double PagamentoTotal()
        {
            return PagamentoBasico + Imposto;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Pagamento básico: ");
            sb.AppendLine(PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("Imposto: ");
            sb.AppendLine(Imposto.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("Pagamento total: ");
            sb.AppendLine(PagamentoTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
