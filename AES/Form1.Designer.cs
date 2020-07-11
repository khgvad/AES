namespace AES
{
    partial class AES
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOriginalText = new System.Windows.Forms.TextBox();
            this.tbKeyEnc = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEncrypt = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEncryptResult = new System.Windows.Forms.TextBox();
            this.tbEncRoundKeys = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.tpDecrypt = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDecryptResult = new System.Windows.Forms.TextBox();
            this.tbCypherText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDecRoundKeys = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.tbDecKey = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpEncrypt.SuspendLayout();
            this.tpDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOriginalText
            // 
            this.tbOriginalText.Location = new System.Drawing.Point(108, 20);
            this.tbOriginalText.Name = "tbOriginalText";
            this.tbOriginalText.Size = new System.Drawing.Size(506, 20);
            this.tbOriginalText.TabIndex = 0;
            // 
            // tbKeyEnc
            // 
            this.tbKeyEnc.Location = new System.Drawing.Point(108, 46);
            this.tbKeyEnc.Name = "tbKeyEnc";
            this.tbKeyEnc.Size = new System.Drawing.Size(506, 20);
            this.tbKeyEnc.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEncrypt);
            this.tabControl1.Controls.Add(this.tpDecrypt);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 429);
            this.tabControl1.TabIndex = 2;
            // 
            // tpEncrypt
            // 
            this.tpEncrypt.BackColor = System.Drawing.SystemColors.Control;
            this.tpEncrypt.Controls.Add(this.label4);
            this.tpEncrypt.Controls.Add(this.label3);
            this.tpEncrypt.Controls.Add(this.label2);
            this.tpEncrypt.Controls.Add(this.label1);
            this.tpEncrypt.Controls.Add(this.tbEncryptResult);
            this.tpEncrypt.Controls.Add(this.tbEncRoundKeys);
            this.tpEncrypt.Controls.Add(this.buttonEncrypt);
            this.tpEncrypt.Controls.Add(this.tbOriginalText);
            this.tpEncrypt.Controls.Add(this.tbKeyEnc);
            this.tpEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tpEncrypt.Name = "tpEncrypt";
            this.tpEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tpEncrypt.Size = new System.Drawing.Size(633, 403);
            this.tpEncrypt.TabIndex = 0;
            this.tpEncrypt.Text = "Зашифрование";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат зашифрования";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ключи раундов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ключ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходный текст";
            // 
            // tbEncryptResult
            // 
            this.tbEncryptResult.BackColor = System.Drawing.SystemColors.Window;
            this.tbEncryptResult.Location = new System.Drawing.Point(108, 299);
            this.tbEncryptResult.Multiline = true;
            this.tbEncryptResult.Name = "tbEncryptResult";
            this.tbEncryptResult.ReadOnly = true;
            this.tbEncryptResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEncryptResult.Size = new System.Drawing.Size(506, 79);
            this.tbEncryptResult.TabIndex = 4;
            // 
            // tbEncRoundKeys
            // 
            this.tbEncRoundKeys.BackColor = System.Drawing.SystemColors.Window;
            this.tbEncRoundKeys.Location = new System.Drawing.Point(108, 114);
            this.tbEncRoundKeys.Multiline = true;
            this.tbEncRoundKeys.Name = "tbEncRoundKeys";
            this.tbEncRoundKeys.ReadOnly = true;
            this.tbEncRoundKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEncRoundKeys.Size = new System.Drawing.Size(506, 155);
            this.tbEncRoundKeys.TabIndex = 3;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(527, 72);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(87, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // tpDecrypt
            // 
            this.tpDecrypt.BackColor = System.Drawing.SystemColors.Control;
            this.tpDecrypt.Controls.Add(this.label8);
            this.tpDecrypt.Controls.Add(this.tbDecryptResult);
            this.tpDecrypt.Controls.Add(this.tbCypherText);
            this.tpDecrypt.Controls.Add(this.label5);
            this.tpDecrypt.Controls.Add(this.label6);
            this.tpDecrypt.Controls.Add(this.label7);
            this.tpDecrypt.Controls.Add(this.tbDecRoundKeys);
            this.tpDecrypt.Controls.Add(this.buttonDecrypt);
            this.tpDecrypt.Controls.Add(this.tbDecKey);
            this.tpDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tpDecrypt.Name = "tpDecrypt";
            this.tpDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecrypt.Size = new System.Drawing.Size(633, 403);
            this.tpDecrypt.TabIndex = 1;
            this.tpDecrypt.Text = "Расшифрование";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Исходный текст";
            // 
            // tbDecryptResult
            // 
            this.tbDecryptResult.Location = new System.Drawing.Point(108, 355);
            this.tbDecryptResult.Name = "tbDecryptResult";
            this.tbDecryptResult.Size = new System.Drawing.Size(506, 20);
            this.tbDecryptResult.TabIndex = 19;
            // 
            // tbCypherText
            // 
            this.tbCypherText.BackColor = System.Drawing.SystemColors.Window;
            this.tbCypherText.Location = new System.Drawing.Point(108, 22);
            this.tbCypherText.Multiline = true;
            this.tbCypherText.Name = "tbCypherText";
            this.tbCypherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCypherText.Size = new System.Drawing.Size(506, 79);
            this.tbCypherText.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Шифртекст";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ключи раундов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ключ";
            // 
            // tbDecRoundKeys
            // 
            this.tbDecRoundKeys.BackColor = System.Drawing.SystemColors.Window;
            this.tbDecRoundKeys.Location = new System.Drawing.Point(108, 179);
            this.tbDecRoundKeys.Multiline = true;
            this.tbDecRoundKeys.Name = "tbDecRoundKeys";
            this.tbDecRoundKeys.ReadOnly = true;
            this.tbDecRoundKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDecRoundKeys.Size = new System.Drawing.Size(506, 155);
            this.tbDecRoundKeys.TabIndex = 12;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(516, 133);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(98, 23);
            this.buttonDecrypt.TabIndex = 11;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // tbDecKey
            // 
            this.tbDecKey.Location = new System.Drawing.Point(108, 107);
            this.tbDecKey.Name = "tbDecKey";
            this.tbDecKey.Size = new System.Drawing.Size(506, 20);
            this.tbDecKey.TabIndex = 10;
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 429);
            this.Controls.Add(this.tabControl1);
            this.Name = "AES";
            this.Text = "AES";
            this.tabControl1.ResumeLayout(false);
            this.tpEncrypt.ResumeLayout(false);
            this.tpEncrypt.PerformLayout();
            this.tpDecrypt.ResumeLayout(false);
            this.tpDecrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbOriginalText;
        private System.Windows.Forms.TextBox tbKeyEnc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEncrypt;
        private System.Windows.Forms.TabPage tpDecrypt;
        private System.Windows.Forms.TextBox tbEncRoundKeys;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEncryptResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDecRoundKeys;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox tbDecKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDecryptResult;
        private System.Windows.Forms.TextBox tbCypherText;
    }
}

