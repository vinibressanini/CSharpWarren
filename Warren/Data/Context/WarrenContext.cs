﻿using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class WarrenContext : DbContext

    {
        #region Props
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Planta> Planta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=192.168.0.99; Port=5433; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
