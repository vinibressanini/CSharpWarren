using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class BaseRepository<T> : IRepository<T> where T : BaseModel
    {

        List<T> pessoas;

        public BaseRepository()
        {
            this.pessoas = new List<T>();
        }
        public virtual string Create(T p)
        {
            this.pessoas.Add(p);
            return $"O dado de id: {p.Id} foi salvo com sucesso";
        }


        public virtual List<T> Read()
        {
            return pessoas;
        }

        public virtual string Update(T p)
        {
            return $"O dado de id: {p.Id} foi atualizado com sucesso";
        }
        public virtual string Delete(int id)
        {
            return $"O dado com com id: {id} foi deletada com sucesso";
        }
    }
}
