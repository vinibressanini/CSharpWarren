﻿using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public string Create(T model)
        {
            return "Criado com Sucesso";        }

        public string Delete(int id)
        {
            return "Deletado com Sucesso";        }

        public List<T> GetAll()
        {
            List<T> values = new List<T>();
            return values;
        }

        public T GetById(int id)
        {
            T model = null;
            return model;
        }

        public string Update(T model)
        {
            return "Alterado com Sucesso";
        }
    }
}
