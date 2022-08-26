﻿using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual List<T> GetAll()
        {
            List<T> animals = new List<T>();

            using (WarrenContext warrenContext = new WarrenContext())
            {
                animals = warrenContext.Set<T>().ToList();
            }

            return animals;
        }

        public virtual string Create(T model)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Set<T>().Add(model);
                warrenContext.SaveChanges();
            }
            return "Criado";

        }
        public virtual string Delete(int id)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Entry<T>(this.GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                warrenContext.SaveChanges();
            }
            return "Deletado com Sucesso";
        }

        public virtual T GetById(int id)
        {
            T model = null;
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Set<T>().Find(id);
            }
            return model;
        }

        public virtual string Update(T model)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                warrenContext.SaveChanges();
            }
            return "Alterado com Sucesso";
        }
    }
}
