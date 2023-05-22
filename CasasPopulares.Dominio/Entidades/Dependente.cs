namespace CasasPopulares.Dominio.Entidades
{
    public class Dependente : Pessoa
    {
        public Dependente(string nome, DateTime dataDeNascimento) :
        base(nome, dataDeNascimento){}
        public bool Apto => Idade <= 18;
    }
}
