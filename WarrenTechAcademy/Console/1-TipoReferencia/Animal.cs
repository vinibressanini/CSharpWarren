﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class Animal : BaseModel
    {
        public string Nome { get; set; }
        public double Peso { get; set; }

        public Animal (string nome, double peso)
        {
            this.Nome = nome;
            this.Peso = peso;
        }

        public virtual string FazerSom ()
        {
            return "Som...";
        }
    }
}
