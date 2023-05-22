using CasasPopulares.Dominio.Entidades;

namespace CasasPopulares.Dominio.Servicos.Contratos
{
    public interface ICalcularPontuacao
    {
        int CalcularPontuacao(Familia familia);
    }
}
