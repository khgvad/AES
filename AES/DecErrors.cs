using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    class DecErrors : Errors
    {
        // проверка ошибок при расшифровании
        public static bool CheckErrors(string ct, string key)
        {
            errorText = string.Empty;
            return InvalidCyphertextError(ct) | InvalidKeyError(key);
        }

        // проверка валидности шифртекста
        private static bool InvalidCyphertextError(string ct)
        {
            if (ct.Trim().Length % 32 != 0 || ct.Trim() == string.Empty)
            {
                errorText += $"Вы ввели недопустимый шифртекст!\r\n";
                return true;
            }
            return false;
        }
    }
}
