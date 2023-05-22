using CasasPopulares.Dominio.Validacoes;

namespace CasasPopulares.Dominio.Entidades
{
    public class Familia
    {

        private IList<Dependente> _dependentes;

        public Familia(Pessoa pretendente, Pessoa conjuge)
        {
            _dependentes = new List<Dependente>();
            AtribuirPretendente(pretendente);
            AtribuirConjuge(conjuge);
            AtualizarRendaFamiliar();
        }

        public Pessoa Pretendente { get; private set; }
        public Pessoa Conjuge { get; private set; }
        public IReadOnlyCollection<Dependente> Dependentes { get { return _dependentes.ToArray(); } }
        public int RendaFamiliar { get; private set; }
        public int? Pontuacao { get; private set; }

        private void AtribuirPretendente(Pessoa pretendente)
        {
            ValidadorDePessoa.ValidarPessoa(pretendente);
            Pretendente = pretendente;
        }

        private void AtribuirConjuge(Pessoa conjuge)
        {
            ValidadorDePessoa.ValidarPessoa(conjuge);
            Conjuge = conjuge;
        }
        private void AtualizarRendaFamiliar()
        {            
            RendaFamiliar = Pretendente?.Renda ?? 0;
            RendaFamiliar += Conjuge?.Renda ?? 0;
        }

        public void AtribuirPontuacao(int pontuacao)
        {
            Pontuacao = pontuacao;
        }

        public void AtribuirDependente(Dependente dependente)
        {
            ValidadorDeFamilia.ValidarDependente(dependente);
            _dependentes.Add(dependente);
        }

        public int ContarDependentesAptos()
        {
            return _dependentes.Count(dependente => dependente.Apto);
        }
        
    }
}
