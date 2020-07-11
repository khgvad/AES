using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    static class KeyManager
    {
        // инициализация раундовой константы RCon
        private static string[] RCon(int ind)
        {
            string[][] result = new string[10][];
                     
            for (int i = 0; i < result.Length; i++)
            {
                string[] column = new string[4];

                if (i == 0)
                {
                    column[0] = "01";
                }
                else
                {
                    int temp = Convert.ToInt32(result[i - 1][0], 16);
                    int temp1 = 2 * temp;
                    if (temp >= 128)
                    {
                        temp1 ^= 27;
                    }

                    column[0] = Convert.ToString(temp1 % 256, 16).PadLeft(2, '0');
                }

                for (int j = 1; j <= 3; j++)
                {
                    column[j] = "00";
                }

                result[i] = column;
            }
            return result[ind];            
        }

        // получение вспомогательного элемента t для формирования ключевых элементов
        private static int GetAdditionalElem(string word, int rConInd)
        {
            string temp1 = RotWord(word);
            string temp2 = Word.SubWord(temp1);
            string temp3 = Word.Collect(RCon(rConInd));

            int result = Convert.ToInt32(temp2, 16) ^ Convert.ToInt32(temp3, 16);
            return result;
        }

        // формирование ключевых элементов
        private static string[] KeyExpansion(string key)
        {
            string[] keyElems = new string[44];
            string[] init = Word.Split(key, 8);

            for (int i = 0; i <= 3; i++)
            {
                keyElems[i] = init[i];
            }

            for (int i = 4; i <= 43; i++)
            {
                int next = new int();
                if (i%4 == 0)
                {
                    next = GetAdditionalElem(keyElems[i - 1], i/4 - 1) ^ Convert.ToInt32(keyElems[i - 4], 16);
                }
                else
                {
                    next = Convert.ToInt32(keyElems[i - 1], 16) ^ Convert.ToInt32(keyElems[i - 4], 16);
                }
                keyElems[i] = Convert.ToString(next, 16).PadLeft(8, '0');
            }

            return keyElems;
        }

        // разбиение ключевых элементов на массивы размерностью [4, 4]
        // (вспомогательная операция для формирования раундовых ключей)
        private static string[,] SplitKeyElems(string[] keyElems)
        {
            string[,] result = new string[4, 44];

            for (int j = 0; j < keyElems.Length; j++)
            {
                string[] temp = Word.Split(keyElems[j], 2);
                for (int i = 0; i < 4; i++)
                {
                    result[i, j] = temp[i];
                }
            }
            return result;
        }

        // формирование раундового ключа
        public static string[,] GetRoundKey(string key, int round)
        {
            string[] keyElems = KeyExpansion(key);
            string[,] splittedElems = SplitKeyElems(keyElems);

            string[,] roundKey = new string[4,4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int temp = round*4 + j;
                    roundKey[i, j] = splittedElems[i, round * 4 + j];
                }
            }
            return roundKey;
        }

        // получение всех раундовых ключей
        public static string[][,] GetAllRoundKeys(string key)
        {
            string[][,] result = new string[11][,];
            for (int i = 0; i <= 10; i++)
            {
                result[i] = GetRoundKey(key, i);
            }

            return result;
        }

        // циклический сдвиг в слове на 1 байт влево
        private static string RotWord(string word)
        {
            return word.Substring(6, 2) + word.Substring(0, 6);
        }       
    }
}