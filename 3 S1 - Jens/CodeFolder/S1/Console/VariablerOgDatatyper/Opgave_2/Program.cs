using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Del 1

            //  Heltal

            byte myByte = 8; // 0 - 255
            sbyte mySbyte = -8; // -128 - +127
            short myShort = 32767; // -32.768 - +32.767
            ushort myUshort = 65535; // 0 - 65.535
            int myInt = 2; // -2.147.483.647 - +2.147.483.647
            uint myUint = 4; // 0 - 4.294.967.295
            long myLong = 20454; // -9.223.372.036.854.775.808 - +9.223.372.036.854.775.808
            ulong myUlong = 23123; // 0 - 18.446.744.073.709.551.615

            //  Decimaltal

            float myFloat = 3.32F; // -3.402823^38 - +3.402823^38
            double myDouble = 241.124214; // -1.179769313486232^308 - +1.79769313486232^308
            decimal myDecimal = 131; // 1.0 x 10^-28 - 7.9 x 10^28

            // Del 2

            // Heltal

            Console.WriteLine("Byte Min: {0}, Byte Max: {1}.", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Sbyte Min: {0}, Sbyte Max: {1}.", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Short Min: {0}, Short Max: {1}.", short.MinValue, short.MaxValue);
            Console.WriteLine("Ushort Min: {0}, Ushort Max: {1}.", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Int Min: {0}, Int Max: {1}.", int.MinValue, int.MaxValue);
            Console.WriteLine("Uint Min: {0}, Uint Max: {1}.", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Long Min: {0}, Long Max: {1}.", long.MinValue, long.MaxValue);
            Console.WriteLine("Ulong Min: {0}, Ulong Max: {1}.", ulong.MinValue, ulong.MaxValue);

            // Decimaltal

            Console.WriteLine("Float Min: {0}, Float Max: {1}.", float.MinValue, float.MaxValue);
            Console.WriteLine("Double Min: {0}, Double Max: {1}.", double.MinValue, double.MaxValue);
            Console.WriteLine("Decimal Min: {0}, Decimal Max: {1}.", decimal.MinValue, decimal.MaxValue);

            Console.ReadLine();

            // Del 3 

            float newFloat = 0;
            double newDouble = 0;
            decimal newDecimal = 0;

            newFloat = (float)Math.PI;
            newDouble = (double)Math.PI;
            newDecimal = (decimal)Math.PI;

            Console.WriteLine("Float PI: {0}.", newFloat);
            Console.WriteLine("Double PI: {0}.", newDouble);
            Console.WriteLine("Decimal PI: {0}.", newDecimal);

            Console.ReadLine();

        }
    }
}
