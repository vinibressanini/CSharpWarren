using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico3
    {
        public static void Executa()
        {
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;
            System.Console.WriteLine($"float min: {floatMin}");
            System.Console.WriteLine($"float min: {floatMax}");

            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;
            System.Console.WriteLine($"double min: {doubleMin}");
            System.Console.WriteLine($"double min: {doubleMax}");

            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;
            System.Console.WriteLine($"decimal min: {decimalMin}");
            System.Console.WriteLine($"decimal min: {decimalMax}");

            double n1 = 10.1;
            double n2 = 20.2;
            double result = 30.3;

            System.Console.WriteLine($"{n1 + n2} - {result}");
            System.Console.WriteLine($"{n1 + n2 == result}");
        }
    }
}
