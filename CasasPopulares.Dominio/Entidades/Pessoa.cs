using CasasPopulares.Dominio.Validacoes;

namespace CasasPopulares.Dominio.Entidades
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataDeNascimento)
        {
            ValidadorDePessoa.ValidarNome(nome);
            ValidadorDePessoa.ValidarDataDeNascimento(dataDeNascimento);
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
        }

        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public int Renda { get; private set; }
        public int Idade { get { return CalcularIdade(); } }

        private int CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataDeNascimento.Year;
            if (dataAtual < DataDeNascimento.AddYears(idade))
                idade--;

            return idade;
        }
        public void AtribuirRenda(int renda)
        {
            ValidadorDePessoa.ValidarRenda(renda);
            Renda = renda;
        }
    }
}
