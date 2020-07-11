using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    class EncErrors : Errors
    {
        // проверка ошибок при зашифровании
        public static bool CheckErrors(string text, string key)
        {
            errorText = string.Empty;
            return EmptySourceTextError(text) | InvalidKeyError(key);
        }

        // проверка исходного текста на пустоту
        private static bool EmptySourceTextError(string text)
        {
            if (text.Trim().Length == 0)
            {
                errorText += $"Вы не ввели исходный текст!\r\n";
                return true;
            }
            return false;
        }
    }
}
