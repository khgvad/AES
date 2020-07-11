using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    static class Word
    {
        // словарь замены для SubWord, SubBytes
        public static Dictionary<string, string> subDictionary = new Dictionary<string, string>()
            {
                ["00"] = "63", ["01"] = "7c", ["02"] = "77", ["03"] = "7b", ["04"] = "f2", ["05"] = "6b", ["06"] = "6f", ["07"] = "c5",
                ["08"] = "30", ["09"] = "01", ["0a"] = "67", ["0b"] = "2b", ["0c"] = "fe", ["0d"] = "d7", ["0e"] = "ab", ["0f"] = "76",

                ["10"] = "ca", ["11"] = "82", ["12"] = "c9", ["13"] = "7d", ["14"] = "fa", ["15"] = "59", ["16"] = "47", ["17"] = "f0",
                ["18"] = "ad", ["19"] = "d4", ["1a"] = "a2", ["1b"] = "af", ["1c"] = "9c", ["1d"] = "a4", ["1e"] = "72", ["1f"] = "c0",

                ["20"] = "b7", ["21"] = "fd", ["22"] = "93", ["23"] = "26", ["24"] = "36", ["25"] = "3f", ["26"] = "f7", ["27"] = "cc",
                ["28"] = "34", ["29"] = "a5", ["2a"] = "e5", ["2b"] = "f1", ["2c"] = "71", ["2d"] = "d8", ["2e"] = "31", ["2f"] = "15",

                ["30"] = "04", ["31"] = "c7", ["32"] = "23", ["33"] = "c3", ["34"] = "18", ["35"] = "96", ["36"] = "05", ["37"] = "9a",
                ["38"] = "07", ["39"] = "12", ["3a"] = "80", ["3b"] = "e2", ["3c"] = "eb", ["3d"] = "27", ["3e"] = "b2", ["3f"] = "75",

                ["40"] = "09", ["41"] = "83", ["42"] = "2c", ["43"] = "1a", ["44"] = "1b", ["45"] = "6e", ["46"] = "5a", ["47"] = "a0",
                ["48"] = "52", ["49"] = "3b", ["4a"] = "d6", ["4b"] = "b3", ["4c"] = "29", ["4d"] = "e3", ["4e"] = "2f", ["4f"] = "84",

                ["50"] = "53", ["51"] = "d1", ["52"] = "00", ["53"] = "ed", ["54"] = "20", ["55"] = "fc", ["56"] = "b1", ["57"] = "5b",
                ["58"] = "6a", ["59"] = "cb", ["5a"] = "be", ["5b"] = "39", ["5c"] = "4a", ["5d"] = "4c", ["5e"] = "58", ["5f"] = "cf",

                ["60"] = "d0", ["61"] = "ef", ["62"] = "aa", ["63"] = "fb", ["64"] = "43", ["65"] = "4d", ["66"] = "33", ["67"] = "85",
                ["68"] = "45", ["69"] = "f9", ["6a"] = "02", ["6b"] = "7f", ["6c"] = "50", ["6d"] = "3c", ["6e"] = "9f", ["6f"] = "a8",

                ["70"] = "51", ["71"] = "a3", ["72"] = "40", ["73"] = "8f", ["74"] = "92", ["75"] = "9d", ["76"] = "38", ["77"] = "f5",
                ["78"] = "bc", ["79"] = "b6", ["7a"] = "da", ["7b"] = "21", ["7c"] = "10", ["7d"] = "ff", ["7e"] = "f3", ["7f"] = "d2",

                ["80"] = "cd", ["81"] = "0c", ["82"] = "13", ["83"] = "ec", ["84"] = "5f", ["85"] = "97", ["86"] = "44", ["87"] = "17",
                ["88"] = "c4", ["89"] = "a7", ["8a"] = "7e", ["8b"] = "3d", ["8c"] = "64", ["8d"] = "5d", ["8e"] = "19", ["8f"] = "73",

                ["90"] = "60", ["91"] = "81", ["92"] = "4f", ["93"] = "dc", ["94"] = "22", ["95"] = "2a", ["96"] = "90", ["97"] = "88",
                ["98"] = "46", ["99"] = "ee", ["9a"] = "b8", ["9b"] = "14", ["9c"] = "de", ["9d"] = "5e", ["9e"] = "0b", ["9f"] = "db",

                ["a0"] = "e0", ["a1"] = "32", ["a2"] = "3a", ["a3"] = "0a", ["a4"] = "49", ["a5"] = "06", ["a6"] = "24", ["a7"] = "5c",
                ["a8"] = "c2", ["a9"] = "d3", ["aa"] = "ac", ["ab"] = "62", ["ac"] = "91", ["ad"] = "95", ["ae"] = "e4", ["af"] = "79",

                ["b0"] = "e7", ["b1"] = "c8", ["b2"] = "37", ["b3"] = "6d", ["b4"] = "8d", ["b5"] = "d5", ["b6"] = "4e", ["b7"] = "a9",
                ["b8"] = "6c", ["b9"] = "56", ["ba"] = "f4", ["bb"] = "ea", ["bc"] = "65", ["bd"] = "7a", ["be"] = "ae", ["bf"] = "08",

                ["c0"] = "ba", ["c1"] = "78", ["c2"] = "25", ["c3"] = "2e", ["c4"] = "1c", ["c5"] = "a6", ["c6"] = "b4", ["c7"] = "c6",
                ["c8"] = "e8", ["c9"] = "dd", ["ca"] = "74", ["cb"] = "1f", ["cc"] = "4b", ["cd"] = "bd", ["ce"] = "8b", ["cf"] = "8a",

                ["d0"] = "70", ["d1"] = "3e", ["d2"] = "b5", ["d3"] = "66", ["d4"] = "48", ["d5"] = "03", ["d6"] = "f6", ["d7"] = "0e",
                ["d8"] = "61", ["d9"] = "35", ["da"] = "57", ["db"] = "b9", ["dc"] = "86", ["dd"] = "c1", ["de"] = "1d", ["df"] = "9e",

                ["e0"] = "e1", ["e1"] = "f8", ["e2"] = "98", ["e3"] = "11", ["e4"] = "69", ["e5"] = "d9", ["e6"] = "8e", ["e7"] = "94",
                ["e8"] = "9b", ["e9"] = "1e", ["ea"] = "87", ["eb"] = "e9", ["ec"] = "ce", ["ed"] = "55", ["ee"] = "28", ["ef"] = "df",

                ["f0"] = "8c", ["f1"] = "a1", ["f2"] = "89", ["f3"] = "0d", ["f4"] = "bf", ["f5"] = "e6", ["f6"] = "42", ["f7"] = "68",
                ["f8"] = "41", ["f9"] = "99", ["fa"] = "2d", ["fb"] = "0f", ["fc"] = "b0", ["fd"] = "54", ["fe"] = "bb", ["ff"] = "16"
            };

        // разделение строки на несколько подстрок
        public static string[] Split(string word, int pieceLength)
        {
            int count = word.Length / pieceLength;
            string[] pieces = new string[count];

            for (int i = 0; i < count; i++)
            {
                pieces[i] = word.Substring(i * pieceLength, pieceLength);
            }
            return pieces;
        }

        // сбор нескольких подстрок в одну строку
        public static string Collect(string[] bytes)
        {
            string word = string.Empty;
            foreach (string b in bytes)
            {
                word += b;
            }
            return word;
        }

        // добавление длины образа шифруемого сообщения до кратной 32
        private static string Supplement(string word)
        {           
            string newWord = word + '8';

            while (newWord.Length % 32 != 0)
            {
                newWord += '0';
            }
            return newWord;
        }

        // получение текста из шестнадцетирчных блоков
        public static string GetText(string[] blocks)
        {
            List<byte> bytes = new List<byte>();
            int length = blocks.Length;

            for (int i = 0; i < length; i++)
            {
                string block = blocks[i];

                if (i == length - 1)
                {
                    block = block.Substring(0, block.Length - GetSuplLength(block));
                }

                string[] temp = Split(block, 2);

                foreach (string s in temp)
                {
                    bytes.Add(Convert.ToByte(s, 16));
                }
            }

            string result = Encoding.UTF8.GetString(bytes.ToArray());
            return result;
        }

        // вычисление количества добавочных символов
        // (необходимо для преобразования блоков в исходный текст)
        private static int GetSuplLength(string text)
        {
            int result = 1;

            for (int i = text.Length-1; text[i] != '8'; i--)
            {
                result++;
            }
            return result;
        }

        // получение шестнадцетиричных блоков из строки текста
        public static string[] GetBlocks(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            string word = string.Empty;

            foreach (byte b in bytes)
            {
                word += Convert.ToString(b, 16);
            }

            word = Supplement(word);
            string[] blocks = new string[word.Length / 32];

            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = word.Substring(i * 32, 32);
            }
            return blocks;
        }

        // замена всех байтов в слове
        public static string SubWord(string word)
        {
            string[] bytes = Split(word, 2);
            for (int i = 0; i < bytes.Length; i++)
            {
                SubByte(ref bytes[i], subDictionary);
            }
            return Collect(bytes);
        }

        // замена байта в соответствии со словарем
        public static void SubByte(ref string initByte, Dictionary<string, string> substitutions)
        {
            if (substitutions.TryGetValue(initByte, out string value))
            {
                initByte = value;
            }
        }

        // циклический сдвиг байтов на count байтов влево
        public static string[] LeftShift(string[] bytes, int count)
        {
            string[] result = new string[4];

            int k = 0;
            for (int i = count; i < result.Length; i++)
            {
                result[k] = bytes[i];
                k++;
            }

            for (int i = 0; i < count; i++)
            {
                result[k] = bytes[i];
                k++;
            }
            return result;
        }

        // циклический сдвиг байтов на count байтов вправо
        public static string[] RightShift(string[] bytes, int count)
        {
            string[] result = new string[4];
            int k = 0;

            for (int i = count; i < result.Length; i++)
            {
                result[i] = bytes[k];
                k++;
            }

            for (int i = 0; i < count; i++)
            {
                result[i] = bytes[k];
                k++;
            }

            return result;
        }
    }
}
