using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class Gato : Animal
    {
        public Gato(string nome, double peso) : base(nome, peso)
        {
        }

        public override string FazerSom()
        {
            return "MIAU";
        }
    }
}
