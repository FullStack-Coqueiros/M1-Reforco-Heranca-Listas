namespace Heranca
{
    public class Medico : Pessoa
    {
        public string CRM { get; set; }
        public string Especialidade { get; set; }

        public Medico()
        {
            
        }
        public Medico(string crm, string especialidade)
        {
            CRM = crm;
            Especialidade = especialidade;
        }

        // public Medico(string nome, string telefone, string email, 
        //               string crm, string especialidade): this (crm, especialidade) {
        //     Nome = nome;
        //     Telefone = telefone;
        //     Email = email;
        // }

        public Medico(string nome, string telefone, string email, 
                      string crm, string especialidade): base (nome,telefone,email) {
            CRM = crm;
            Especialidade = especialidade;
        }
    }
}