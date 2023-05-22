using CasasPopulares.Dominio.Entidades;
using CasasPopulares.Dominio.Servicos.Contratos;

namespace CasasPopulares.Dominio.Servicos.Criterios
{
    public class Renda901a1500 : ICalcularPontuacao
    {
        public int CalcularPontuacao(Familia familia)
        {
            if (familia.RendaFamiliar > 900 && familia.RendaFamiliar <= 1500)
                return 3;

            return 0;
        }
    }
}
