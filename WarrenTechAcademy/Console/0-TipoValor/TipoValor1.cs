using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoValor1
    {
        public void Executa()
        {
            byte byteMin = Byte.MinValue;
            byte byteMax = Byte.MaxValue;
            System.Console.WriteLine("Byte Min: " + byteMin);
            System.Console.WriteLine("Byte Max: " + byteMax);

            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            System.Console.WriteLine("sbyte min: " + sbyteMin);
            System.Console.WriteLine("sbyte max" + sbyteMax);

            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            System.Console.WriteLine("short min: " + shortMin);
            System.Console.WriteLine("short max" + shortMax);

            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            System.Console.WriteLine("ushort min : " + ushortMin);
            System.Console.WriteLine("ushort max : " + ushortMax);


            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            System.Console.WriteLine("int min: " + intMin);
            System.Console.WriteLine("int max :" + intMax);

            Int16 int16Min = Int16.MinValue;
            Int16 int16Max = Int16.MaxValue;
            System.Console.WriteLine("int16 min: " + int16Min);
            System.Console.WriteLine("int16 max :" + int16Max);
            
            Int32 int32Min = Int32.MinValue;
            Int32 int32Max = Int32.MaxValue;
            System.Console.WriteLine("int32 min: " + int32Min);
            System.Console.WriteLine("int32 max :" + int32Max);

            Int64 int64Min = Int64.MinValue;
            Int64 int64Max = Int64.MaxValue;
            System.Console.WriteLine("int64 mim: " + int64Min);
            System.Console.WriteLine("int64 max: " + int64Max);

        }
    }
}
