using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AES
{
    class Errors
    {
        // текст ошибки
        public static string errorText = string.Empty;

        // определение валидности введенного ключа
        protected static bool InvalidKeyError(string key)
        {
            Regex rgx = new Regex(@"^[a-fA-F\d]+$");
            if (!rgx.IsMatch(key.Trim()) | key.Trim().Length != 32)
            {
                errorText += "Вы ввели недопустимый ключ!";
                return true;
            }
            return false;
        }
    }
}
