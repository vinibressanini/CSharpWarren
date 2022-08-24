using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class BaseRepository : IRepository
    {

        List<Pessoa> pessoas;

        public BaseRepository()
        {
            this.pessoas = new List<Pessoa>();
        }
        public string Create(Pessoa p)
        {
            this.pessoas.Add(p);
            return $"Pessoa: {p.Nome} Salva Com Sucesso";
        }


        public List<Pessoa> Read()
        {
            return pessoas;
        }

        public string Update(Pessoa p)
        {
            return $"Pessoa: {p.Nome} Atualizada com Sucesso";
        }
        public string Delete(int id)
        {
            return $"Pessoa Com Id: {id} Deletada com Sucesso";
        }
    }
}
