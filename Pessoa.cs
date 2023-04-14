namespace Heranca
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }

        public Pessoa()
        {
            DataCadastro = DateTime.Now;
        }
        public Pessoa(string nome):this()
        {
            Nome = nome;
        }
        public Pessoa(string nome, string telefone, string email) : this(nome)
        {
            Telefone = telefone;
            Email = email;
        }

    }
}