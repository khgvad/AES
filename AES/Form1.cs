using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class AES : Form
    {
        public AES()
        {
            InitializeComponent();           
        }

        // заполнение раундовых ключей
        private void FillRoundKeys(string key, TextBox tb, bool inv)
        {
            tb.Text = string.Empty;
            string[][,] roundKeys = KeyManager.GetAllRoundKeys(key);

            if (inv)
            {
                Array.Reverse(roundKeys);
            }

            for (int i = 0; i < roundKeys.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        tb.Text += roundKeys[i][j, k];
                    }
                    tb.Text += "\r\n";
                }
                tb.Text += "\r\n";
            }
        }

        // зашифрование текста
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {            
            string text = tbOriginalText.Text.Trim();
            string key = tbKeyEnc.Text.Trim();

            if (!EncErrors.CheckErrors(text, key))
            {
                FillRoundKeys(key, tbEncRoundKeys, false);
                tbEncryptResult.Text = Encryption.EncryptText(text, key);
            }
            else
            {
                MessageBox.Show(Errors.errorText, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // расшифрование текста
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string text = tbCypherText.Text.Trim();
            string key = tbDecKey.Text.Trim();

            if (!DecErrors.CheckErrors(text, key))
            {
                FillRoundKeys(key, tbDecRoundKeys, true);
                tbDecryptResult.Text = Decryption.DecryptText(text, key);
            }
            else
            {
                MessageBox.Show(Errors.errorText, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
