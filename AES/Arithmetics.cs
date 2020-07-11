using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    static class Arithmetics
    {
        // произведение двух элементов по правилам полиномиальной арифметики
        private static byte GMul(string a, string b)
        {
            byte first = Convert.ToByte(a, 16);
            byte second = Convert.ToByte(b, 16);

            byte p = 0;
            for (int counter = 0; counter < 8; counter++)
            {
                if ((second & 1) != 0)
                {
                    p ^= first;
                }

                bool hi_bit_set = (first & 0x80) != 0;
                first <<= 1;
                if (hi_bit_set)
                {
                    first ^= 0x1B;
                }
                second >>= 1;
            }

            return p;
        }

        // взятие остатка
        private static string GetRemainder(string a, string b)
        {
            int product = GMul(a, b);
            int result;

            if (product < 0b100011011)
            {
                result = product;
            }
            else
            {
                result = product ^ 0b100011011;
            }

            return Convert.ToString(result, 2);
        }

        // смешивание байтов в столбце state
        public static string Mix(string[] a, string[] b)
        {
            string[] remainders = new string[4];
            int result = 0;

            for (int i = 0; i < 4; i++)
            {
                remainders[i] = GetRemainder(a[i], b[i]);
                result ^= Convert.ToInt32(remainders[i], 2);
            }
            return Convert.ToString(result, 16).PadLeft(2, '0');
        }
    }
}
