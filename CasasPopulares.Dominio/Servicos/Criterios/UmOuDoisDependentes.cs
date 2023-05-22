using CasasPopulares.Dominio.Entidades;
using CasasPopulares.Dominio.Servicos.Contratos;

namespace CasasPopulares.Dominio.Servicos.Criterios
{
    public class UmOuDoisDependentes : ICalcularPontuacao
    {
        public int CalcularPontuacao(Familia familia)
        {
            int numeroDependentes = familia.ContarDependentesAptos();

            if (numeroDependentes >= 1 && numeroDependentes <= 2)
                return 2;

            return 0;
        }
    }
}
