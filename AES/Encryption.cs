using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    class Encryption : Operations
    {
        // массив для операции смешивания байтов MixColumns
        private static string[][] mc = new string[4][]
        {
            new string[4] { "02", "03", "01", "01" },
            new string[4] { "01", "02", "03", "01" },
            new string[4] { "01", "01", "02", "03" },
            new string[4] { "03", "01", "01", "02" }
        };

        // операция зашифрования одного блока
        private static string EncryptBlock(string block, string key)
        {
            string[,] result = GetState(block);
            result = AddRoundKey(result, key, 0);

            for (int i = 1; i <= 10; i++)
            {
                SubBytes(ref result, Word.subDictionary);
                result = ShiftRows(result, false);

                if (i < 10)
                {
                    result = MixColumns(result, mc);
                }

                result = AddRoundKey(result, key, i);
            }

            return CollectBlock(result);
        }

        // операция зашифрования текста
        public static string EncryptText(string text, string key)
        {
            string[] blocks = Word.GetBlocks(text);
            string result = string.Empty;

            for (int i = 0; i < blocks.Length; i++)
            {
                result += EncryptBlock(blocks[i], key);
            }

            return result;
        }
    }
}
