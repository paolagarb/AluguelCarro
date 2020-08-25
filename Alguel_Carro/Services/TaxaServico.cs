namespace Alguel_Carro.Services
{
    class TaxaServico
    {
       public double Imposto (double quantidade)
        {
            if (quantidade <= 100)
            {
                return quantidade * 0.2;
            } else
            {
                return quantidade * 0.15;
            }
        }

    }
}
