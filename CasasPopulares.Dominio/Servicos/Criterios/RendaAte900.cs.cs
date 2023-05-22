using CasasPopulares.Dominio.Entidades;
using CasasPopulares.Dominio.Servicos.Contratos;

namespace CasasPopulares.Dominio.Servicos.Criterios
{
    public class RendaAte900 : ICalcularPontuacao
    {
        public int CalcularPontuacao(Familia familia)
        {
            if (familia.RendaFamiliar <= 900)
                return 5;

            return 0;
        }
    }
}
