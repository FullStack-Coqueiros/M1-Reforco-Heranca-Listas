using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Enfermeiro : Pessoa
    {
        public string Registro { get; set; }

        public Enfermeiro()
        {
            
        }
        public Enfermeiro(string nome): base(nome)
        {
            
        }
        public Enfermeiro(string nome, string enderco, string email) 
                            : base(nome, enderco,email)
        {
        }
        public Enfermeiro(string nome, string enderco, string email, string registro) 
                            : base(nome, enderco,email)
        {
            Registro = registro;
        }
    }
}