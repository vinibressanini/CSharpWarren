using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf{ get; set; }


        public PessoaFisica(string nome,string sobrenome,string cpf) : base(nome, sobrenome)
        {
            this.Cpf = cpf;
        }
       
        override
        public string Saudacao()
        {
            return base.Saudacao() + " - " + this.Cpf;
        }
    }
}
