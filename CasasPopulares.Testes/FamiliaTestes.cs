using CasasPopulares.Dominio.Entidades;

namespace CasasPopulares.Testes
{
    public class FamiliaTestes
    {
        [Fact]
        public void DeveCriarFamiliaValida()
        {
            var pretendente = new Pessoa("Gustavo", DateTime.Now.AddYears(-30));
            var conjuge = new Pessoa("Paula", DateTime.Now.AddYears(-28));

            var familia = new Familia(pretendente, conjuge);

            Assert.Equal(pretendente, familia.Pretendente);
            Assert.Equal(conjuge, familia.Conjuge);
        }

        [Fact]
        public void DeveLancarExcecaoAoCriarFamiliaSemPretendente()
        {

            var conjuge = new Pessoa("Paula", DateTime.Now.AddYears(-28));

            Assert.Throws<ArgumentNullException>(() => new Familia(null, conjuge));
        }

        [Fact]
        public void DeveLancarExcecaoAoCriarFamiliaSemConjuge()
        {
            var pretendente = new Pessoa("Gustavo", DateTime.Now.AddYears(-30));

            Assert.Throws<ArgumentNullException>(() => new Familia(pretendente, null));
        }

        [Fact]
        public void DeveAdicionarDependenteValido()
        {
            var pretendente = new Pessoa("asdret", DateTime.Now.AddYears(-30));
            var conjuge = new Pessoa("aaaaa", DateTime.Now.AddYears(-28));
            var dependente = new Dependente("Juninho", DateTime.Now.AddYears(-10));
            var familia = new Familia(pretendente, conjuge);

            familia.AtribuirDependente(dependente);

            Assert.Contains(dependente, familia.Dependentes);
        }

        [Fact]
        public void DeveLancarExcecaoAoAdicionarDependenteInvalido()
        {
            var pretendente = new Pessoa("Gustavo", DateTime.Now.AddYears(-30));
            var conjuge = new Pessoa("Maria", DateTime.Now.AddYears(-28));
            var familia = new Familia(pretendente, conjuge);

            Assert.Throws<ArgumentNullException>(() => familia.AtribuirDependente(null));
        }

    }
}
