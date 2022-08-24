using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoBooleano
    {

        public static void Executa()
        {
            bool gostaDeCalypso = false;
            bool naoGostaDeBaroes = true;

            bool eMaior = 10 > 11;
            bool eIgual = 10 + 11 == 21;
            if (eMaior)
            {
                System.Console.WriteLine("É maior");
            } else
            {
                System.Console.WriteLine("É menor");
            }
        }

    }
}
