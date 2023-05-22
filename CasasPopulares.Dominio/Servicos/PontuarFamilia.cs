using CasasPopulares.Dominio.Entidades;
using CasasPopulares.Dominio.Servicos.Contratos;

namespace CasasPopulares.Dominio.Servicos
{
    public class PontuarFamilia
    {
        private readonly List<ICalcularPontuacao> _criterios;

        public PontuarFamilia(List<ICalcularPontuacao> criterios)
        {
            _criterios = criterios;
        }

        public void CalcularPontuacao(Familia familia)
        {
            int pontuacaoTotal = 0;

            foreach (var criterio in _criterios)
            {
                pontuacaoTotal += criterio.CalcularPontuacao(familia);
            }
            familia.AtribuirPontuacao(pontuacaoTotal);
        }
    }
}
