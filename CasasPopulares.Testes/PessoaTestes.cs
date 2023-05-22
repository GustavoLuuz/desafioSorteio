using CasasPopulares.Dominio.Entidades;

namespace CasasPopulares.Tests
{
    public class PessoaTestes
    {
        [Fact]
        public void DeveCriarPessoaComNomeEDataDeNascimento()
        {
            string nome = "Gustavo";
            DateTime dataDeNascimento = new DateTime(1990, 1, 1);


            var pessoa = new Pessoa(nome, dataDeNascimento);

            Assert.Equal(nome, pessoa.Nome);
            Assert.Equal(dataDeNascimento, pessoa.DataDeNascimento);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void DeveLancarExcecaoAoCriarPessoaComNomeInvalido(string nomeInvalido)
        {
            DateTime dataDeNascimento = new DateTime(1990, 1, 1);

            Assert.Throws<Exception>(() => new Pessoa(nomeInvalido, dataDeNascimento));
        }

        [Fact]
        public void DeveFalharAoCriarPessoaComDataDeNascimentoFutura()
        {

            string nome = "Kleitinho";
            DateTime dataDeNascimento = DateTime.Now.AddDays(1);

            Assert.Throws<Exception>(() => new Pessoa(nome, dataDeNascimento));
        }

        [Fact]
        public void DeveAtribuirRendaValida()
        {

            string nome = "Luz";
            DateTime dataDeNascimento = new DateTime(1990, 1, 1);
            int renda = 2000;
            var pessoa = new Pessoa(nome, dataDeNascimento);

            pessoa.AtribuirRenda(renda);

            Assert.Equal(renda, pessoa.Renda);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        public void DeveFalharAoAtribuirRendaInvalida(int rendaInvalida)
        {

            string nome = "Marise";
            DateTime dataDeNascimento = new DateTime(1990, 1, 1);
            var pessoa = new Pessoa(nome, dataDeNascimento);

            Assert.Throws<Exception>(() => pessoa.AtribuirRenda(rendaInvalida));
        }
    }
}
