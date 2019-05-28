namespace Decoder_RSA
{
    partial class RSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA));
            this.SourceText = new System.Windows.Forms.RichTextBox();
            this.CipherText = new System.Windows.Forms.RichTextBox();
            this.DecipherText = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.OpenedKeyText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ClosedKeyText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.CipherFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DecipherFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoadFromFileFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoadFromFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(12, 73);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(380, 138);
            this.SourceText.TabIndex = 0;
            this.SourceText.Text = "Зашифруй меня!";
            // 
            // CipherText
            // 
            this.CipherText.Location = new System.Drawing.Point(398, 73);
            this.CipherText.Name = "CipherText";
            this.CipherText.Size = new System.Drawing.Size(380, 138);
            this.CipherText.TabIndex = 3;
            this.CipherText.Text = "";
            // 
            // DecipherText
            // 
            this.DecipherText.Location = new System.Drawing.Point(12, 269);
            this.DecipherText.Name = "DecipherText";
            this.DecipherText.Size = new System.Drawing.Size(380, 138);
            this.DecipherText.TabIndex = 4;
            this.DecipherText.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(140, 214);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Исходный текст";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(563, 214);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Шифр";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(112, 410);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(181, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Расшифрованный текст";
            // 
            // OpenedKeyText
            // 
            this.OpenedKeyText.Depth = 0;
            this.OpenedKeyText.Hint = "";
            this.OpenedKeyText.Location = new System.Drawing.Point(549, 269);
            this.OpenedKeyText.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenedKeyText.Name = "OpenedKeyText";
            this.OpenedKeyText.PasswordChar = '\0';
            this.OpenedKeyText.SelectedText = "";
            this.OpenedKeyText.SelectionLength = 0;
            this.OpenedKeyText.SelectionStart = 0;
            this.OpenedKeyText.Size = new System.Drawing.Size(98, 23);
            this.OpenedKeyText.TabIndex = 15;
            this.OpenedKeyText.UseSystemPasswordChar = false;
            // 
            // ClosedKeyText
            // 
            this.ClosedKeyText.Depth = 0;
            this.ClosedKeyText.Hint = "";
            this.ClosedKeyText.Location = new System.Drawing.Point(549, 304);
            this.ClosedKeyText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClosedKeyText.Name = "ClosedKeyText";
            this.ClosedKeyText.PasswordChar = '\0';
            this.ClosedKeyText.SelectedText = "";
            this.ClosedKeyText.SelectionLength = 0;
            this.ClosedKeyText.SelectionStart = 0;
            this.ClosedKeyText.Size = new System.Drawing.Size(98, 23);
            this.ClosedKeyText.TabIndex = 16;
            this.ClosedKeyText.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(411, 269);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(132, 23);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Открытый ключ";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(411, 304);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(132, 23);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Закрытый ключ";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CipherFlatButton
            // 
            this.CipherFlatButton.AutoSize = true;
            this.CipherFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CipherFlatButton.Depth = 0;
            this.CipherFlatButton.Location = new System.Drawing.Point(414, 370);
            this.CipherFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CipherFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CipherFlatButton.Name = "CipherFlatButton";
            this.CipherFlatButton.Primary = false;
            this.CipherFlatButton.Size = new System.Drawing.Size(116, 36);
            this.CipherFlatButton.TabIndex = 19;
            this.CipherFlatButton.Text = "Зашифровать";
            this.CipherFlatButton.UseVisualStyleBackColor = true;
            this.CipherFlatButton.Click += new System.EventHandler(this.CipherFlatButton_Click);
            // 
            // DecipherFlatButton
            // 
            this.DecipherFlatButton.AutoSize = true;
            this.DecipherFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DecipherFlatButton.Depth = 0;
            this.DecipherFlatButton.Location = new System.Drawing.Point(538, 370);
            this.DecipherFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DecipherFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DecipherFlatButton.Name = "DecipherFlatButton";
            this.DecipherFlatButton.Primary = false;
            this.DecipherFlatButton.Size = new System.Drawing.Size(126, 36);
            this.DecipherFlatButton.TabIndex = 20;
            this.DecipherFlatButton.Text = "Расшифровать";
            this.DecipherFlatButton.UseVisualStyleBackColor = true;
            this.DecipherFlatButton.Click += new System.EventHandler(this.DecipherFlatButton_Click);
            // 
            // LoadFromFileFlatButton
            // 
            this.LoadFromFileFlatButton.AutoSize = true;
            this.LoadFromFileFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadFromFileFlatButton.Depth = 0;
            this.LoadFromFileFlatButton.Location = new System.Drawing.Point(672, 370);
            this.LoadFromFileFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadFromFileFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadFromFileFlatButton.Name = "LoadFromFileFlatButton";
            this.LoadFromFileFlatButton.Primary = false;
            this.LoadFromFileFlatButton.Size = new System.Drawing.Size(81, 36);
            this.LoadFromFileFlatButton.TabIndex = 21;
            this.LoadFromFileFlatButton.Text = "Загрузка";
            this.LoadFromFileFlatButton.UseVisualStyleBackColor = true;
            this.LoadFromFileFlatButton.Click += new System.EventHandler(this.LoadFromFileFlatButton_Click);
            // 
            // LoadFromFile
            // 
            this.LoadFromFile.FileName = "LoadFromFile";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 443);
            this.Controls.Add(this.LoadFromFileFlatButton);
            this.Controls.Add(this.DecipherFlatButton);
            this.Controls.Add(this.CipherFlatButton);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.ClosedKeyText);
            this.Controls.Add(this.OpenedKeyText);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.DecipherText);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.SourceText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSA";
            this.Text = "Алгоритм RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SourceText;
        private System.Windows.Forms.RichTextBox CipherText;
        private System.Windows.Forms.RichTextBox DecipherText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField OpenedKeyText;
        private MaterialSkin.Controls.MaterialSingleLineTextField ClosedKeyText;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton CipherFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton DecipherFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton LoadFromFileFlatButton;
        private System.Windows.Forms.OpenFileDialog LoadFromFile;
    }
}

