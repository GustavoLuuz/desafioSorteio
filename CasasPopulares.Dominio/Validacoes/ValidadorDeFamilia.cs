using CasasPopulares.Dominio.Entidades;

namespace CasasPopulares.Dominio.Validacoes
{
    public static class ValidadorDeFamilia
    {
        public static void ValidarDependente(Dependente dependente)
        {
            if (dependente == null)
            {
                throw new ArgumentNullException(nameof(dependente));
            }
        }
    }
}
