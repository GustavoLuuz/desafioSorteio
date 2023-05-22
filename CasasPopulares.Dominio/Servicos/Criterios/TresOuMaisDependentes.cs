using CasasPopulares.Dominio.Entidades;
using CasasPopulares.Dominio.Servicos.Contratos;

namespace CasasPopulares.Dominio.Servicos.Criterios
{
    public class TresOuMaisDependentes : ICalcularPontuacao
    {
        public int CalcularPontuacao(Familia familia)
        {
            int numeroDependentes = familia.ContarDependentesAptos();

            if (numeroDependentes >= 3)
                return 3;

            return 0;
        }
    }
}
