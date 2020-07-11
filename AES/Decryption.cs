using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    class Decryption : Operations
    {
        // инверсия словаря замены для операции InvSubBytes
        private static Dictionary<string, string> InvertSubDictionary()
        {
            return Word.subDictionary.ToDictionary(x => x.Value, x => x.Key);
        }

        // массив для смешивания байтов InvMixColumns
        private static string[][] invMc = new string[4][]
        {
            new string[4] { "0e", "0b", "0d", "09" },
            new string[4] { "09", "0e", "0b", "0d" },
            new string[4] { "0d", "09", "0e", "0b" },
            new string[4] { "0b", "0d", "09", "0e" }
        };

        // операция расшифрования одного блока
        private static string DecryptBlock(string block, string key)
        {
            string[,] result = GetState(block);

            result = AddRoundKey(result, key, 10);

            for (int i = 9; i >= 0; i--)
            {
                result = ShiftRows(result, true);
                SubBytes(ref result, InvertSubDictionary());
                result = AddRoundKey(result, key, i);

                if (i > 0)
                {
                    result = MixColumns(result, invMc);
                }
            }
            
            return CollectBlock(result);
        }

        // операция расшифрования текста
        public static string DecryptText(string text, string key)
        {
            string[] blocks = Word.Split(text, 32);
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = DecryptBlock(blocks[i], key);
            }

            string result = Word.GetText(blocks);
            return result;
        }
    }
}
