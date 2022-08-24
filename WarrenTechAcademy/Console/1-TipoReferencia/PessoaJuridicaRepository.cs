using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class PessoaJuridicaRepository
    {
        private List<PessoaJuridica> pessoas;

        public PessoaJuridicaRepository()
        {
            this.pessoas = new List<PessoaJuridica>();
        }
        public string Create(PessoaJuridica pessoa)
        {
            this.pessoas.Add(pessoa);
            return $"Pessoa: {pessoa.Nome} Salva Com Sucesso";
        }

        public List<PessoaJuridica> Read()
        {
            return pessoas;
        }

        public string Update(PessoaJuridica pessoa)
        {
            return $"Pessoa: {pessoa.Nome} Atualizada com Sucesso";
        }

        public string Delete(int id)
        {
            return $"Pessoa de id: {id} Deletada com Sucesso";
        }
    }
}
