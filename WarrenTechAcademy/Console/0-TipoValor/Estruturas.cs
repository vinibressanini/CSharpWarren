using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class Estruturas
    {
        public static void Executa()
        {
            byte idade = 10;
            PessoaClasse p1 = new PessoaClasse();
            p1.Nome = "Chimbinha";
            PessoaStruct p2 = new PessoaStruct();
            p2.Nome = "Jojo";

            PessoaClasse p3 = new PessoaClasse();
            PessoaStruct p4 = new PessoaStruct();

            p3 = p1;
            p4 = p2;

            p1.Nome = "Chimbinha melhor guitarrista do Mundo";
            p2.Nome = "Jojo melhor dançarina > shakira";

            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p2.Nome);
            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);

        }
    }

    struct PessoaStruct
    {
        public string Nome { get; set; }
        public int Sobrenome { get; set; }
        public byte Idade { get; set; }

    }

    class PessoaClasse
    {
        public string Nome { get; set; }
        public int Sobrenome { get; set; }
        public byte Idade { get; set; }

    }
}
