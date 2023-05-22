using CasasPopulares.Dominio.Entidades;
using System.Text.RegularExpressions;

namespace CasasPopulares.Dominio.Validacoes
{
    public static class ValidadorDePessoa
    {
        public static void ValidarPessoa(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                throw new ArgumentNullException(nameof(pessoa), "A pessoa não pode ser nula.");
            }

            ValidarNome(pessoa.Nome);
            ValidarDataDeNascimento(pessoa.DataDeNascimento);
            ValidarRenda(pessoa.Renda);
        }

        public static void ValidarNome(string nome)
        {
            ValidarNomeNuloOuBranco(nome);
            ValidarNomeComMenosDeDoisCaracteres(nome);
            ValidarNomeComCaracteresInvalidos(nome);
        }

        private static void ValidarNomeNuloOuBranco(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome da pessoa não pode ser nulo ou em branco.");
            }
        }

        private static void ValidarNomeComMenosDeDoisCaracteres(string nome)
        {
            if (nome.Length < 2)
            {
                throw new Exception("Nome da pessoa deve ter pelo menos 2 caracteres.");
            }
        }

        private static void ValidarNomeComCaracteresInvalidos(string nome)
        {
            if (!Regex.IsMatch(nome, @"^[a-zA-Z\s]*$"))
            {
                throw new Exception("Nome da pessoa deve conter apenas letras e espaços.");
            }
        }

        public static void ValidarDataDeNascimento(DateTime dataDeNascimento)
        {
            ValidarDataDeNascimentoPadrao(dataDeNascimento);
            ValidarDataDeNascimentoFutura(dataDeNascimento);
        }

        private static void ValidarDataDeNascimentoPadrao(DateTime dataDeNascimento)
        {
            if (dataDeNascimento == default)
            {
                throw new Exception("Data de nascimento inválida.");
            }
        }

        private static void ValidarDataDeNascimentoFutura(DateTime dataDeNascimento)
        {
            if (dataDeNascimento > DateTime.Now)
            {
                throw new Exception("Data de nascimento não pode ser futura.");
            }
        }

        public static void ValidarRenda(int renda)
        {
            if (renda < 0)
            {
                throw new Exception("Renda não pode ser negativa.");
            }
        }
    }
}

