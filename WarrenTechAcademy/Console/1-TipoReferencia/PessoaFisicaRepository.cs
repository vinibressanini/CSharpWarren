using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class PessoaFisicaRepository
    {
        private List<PessoaFisica> pessoas;

        public PessoaFisicaRepository()
        {
            this.pessoas = new List<PessoaFisica>();
        }
        public string Create(PessoaFisica pessoa)
        {
            this.pessoas.Add(pessoa);
            return $"Pessoa: {pessoa.Nome} Salva Com Sucesso";
        }

        public List<PessoaFisica> Read()
        {
            return pessoas;
        }

        public string Update(PessoaFisica pessoa)
        {
            return $"Pessoa: {pessoa.Nome} Atualizada com Sucesso";
        }

        public string Delete(int id)
        {
            return $"Pessoa de id: {id} Deletada com Sucesso";
        }
    }
}
