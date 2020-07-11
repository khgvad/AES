using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    class Operations
    {
        // формирование массива state
        protected static string[,] GetState(string block)
        {
            string[] bytes = Word.Split(block, 2);
            string[,] state = new string[4, 4];

            int ind = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    state[i, j] = bytes[ind];
                    ind++;
                }
            }
            return state;
        }

        // замена байтов в массиве state
        protected static void SubBytes(ref string[,] state, Dictionary<string, string> substitutions)
        {
            for (int i = 0; i < state.GetLength(0); i++)
            {
                for (int j = 0; j < state.GetLength(1); j++)
                {
                    Word.SubByte(ref state[i, j], substitutions);
                }
            }
        }

        // смешивание байтов в столбцах массива state
        protected static string[,] MixColumns(string[,] state, string[][] mc)
        {
            string[,] result = new string[4, 4];
            string[][] columns = new string[4][];

            for (int i = 0; i < 4; i++)
            {
                string[] temp = new string[4];
                for (int j = 0; j < 4; j++)
                {
                    temp[j] = state[j, i];
                }
                columns[i] = temp;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result[j, i] = Arithmetics.Mix(columns[i], mc[j]);
                }
            }

            return result;
        }

        // циклический сдвиг байтов в массиве state
        protected static string[,] ShiftRows(string[,] state, bool inv)
        {
            string[,] result = new string[4, 4];

            for (int i = 0; i < 4; i++)
            {
                string[] temp = new string[4];
                for (int j = 0; j < 4; j++)
                {
                    temp[j] = state[i, j];
                }
                temp = inv ? Word.RightShift(temp, i) : Word.LeftShift(temp, i);

                for (int j = 0; j < 4; j++)
                {
                    result[i, j] = temp[j];
                }
            }
            return result;
        }

        // добавление раундового ключа к массиву state
        protected static string[,] AddRoundKey(string[,] state, string key, int round)
        {
            string[,] roundKey = KeyManager.GetRoundKey(key, round);
            string[,] result = new string[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result[i, j] = Convert.ToString(Convert.ToInt32(state[i, j], 16) ^ Convert.ToInt32(roundKey[i, j], 16), 16).PadLeft(2, '0');
                }
            }
            return result;
        }

        // формирование блока текста из массива state
        protected static string CollectBlock(string[,] bytes)
        {
            string block = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    block += bytes[j, i];
                }
            }
            return block;
        }
    }
}
