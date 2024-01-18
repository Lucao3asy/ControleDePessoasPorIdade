namespace ControleDePessoasPorIdade.Models
{
    public class PessoaModel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public PessoaModel(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }
    }
}


