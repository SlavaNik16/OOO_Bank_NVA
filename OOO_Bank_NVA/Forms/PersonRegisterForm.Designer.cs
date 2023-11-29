namespace OOO_Bank_NVA.Forms
{
    partial class PersonRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.surnameBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.maskNumberCardText = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genderMaleRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.genderFemaleRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.butCreate = new MaterialSkin.Controls.MaterialButton();
            this.butCancel = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskPhoneText = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.AnimateReadOnly = false;
            this.nameBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameBox.Depth = 0;
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.HideSelection = true;
            this.nameBox.Hint = "Имя";
            this.nameBox.LeadingIcon = null;
            this.nameBox.Location = new System.Drawing.Point(97, 281);
            this.nameBox.MaxLength = 75;
            this.nameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.PrefixSuffixText = null;
            this.nameBox.ReadOnly = false;
            this.nameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameBox.SelectedText = "";
            this.nameBox.SelectionLength = 0;
            this.nameBox.SelectionStart = 0;
            this.nameBox.ShortcutsEnabled = true;
            this.nameBox.Size = new System.Drawing.Size(571, 48);
            this.nameBox.TabIndex = 2;
            this.nameBox.TabStop = false;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameBox.TrailingIcon = null;
            this.nameBox.UseSystemPasswordChar = false;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBox.AnimateReadOnly = false;
            this.surnameBox.BackColor = System.Drawing.SystemColors.Control;
            this.surnameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.surnameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.surnameBox.Depth = 0;
            this.surnameBox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.HideSelection = true;
            this.surnameBox.Hint = "Фамилия";
            this.surnameBox.LeadingIcon = null;
            this.surnameBox.Location = new System.Drawing.Point(97, 141);
            this.surnameBox.MaxLength = 75;
            this.surnameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.PasswordChar = '\0';
            this.surnameBox.PrefixSuffixText = null;
            this.surnameBox.ReadOnly = false;
            this.surnameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.surnameBox.SelectedText = "";
            this.surnameBox.SelectionLength = 0;
            this.surnameBox.SelectionStart = 0;
            this.surnameBox.ShortcutsEnabled = true;
            this.surnameBox.Size = new System.Drawing.Size(571, 48);
            this.surnameBox.TabIndex = 4;
            this.surnameBox.TabStop = false;
            this.surnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.surnameBox.TrailingIcon = null;
            this.surnameBox.UseSystemPasswordChar = false;
            this.surnameBox.TextChanged += new System.EventHandler(this.surnameBox_TextChanged);
            // 
            // maskNumberCardText
            // 
            this.maskNumberCardText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.maskNumberCardText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maskNumberCardText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maskNumberCardText.Location = new System.Drawing.Point(97, 598);
            this.maskNumberCardText.Mask = "0000-0000-0000-0000";
            this.maskNumberCardText.Name = "maskNumberCardText";
            this.maskNumberCardText.Size = new System.Drawing.Size(571, 23);
            this.maskNumberCardText.SkipLiterals = false;
            this.maskNumberCardText.TabIndex = 8;
            this.maskNumberCardText.TextChanged += new System.EventHandler(this.maskNumberCardText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(94, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(94, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер карты";
            // 
            // genderMaleRadio
            // 
            this.genderMaleRadio.AutoSize = true;
            this.genderMaleRadio.Checked = true;
            this.genderMaleRadio.Depth = 0;
            this.genderMaleRadio.Location = new System.Drawing.Point(320, 356);
            this.genderMaleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.genderMaleRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.genderMaleRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.genderMaleRadio.Name = "genderMaleRadio";
            this.genderMaleRadio.Ripple = true;
            this.genderMaleRadio.Size = new System.Drawing.Size(104, 37);
            this.genderMaleRadio.TabIndex = 11;
            this.genderMaleRadio.TabStop = true;
            this.genderMaleRadio.Text = "Мужской";
            this.genderMaleRadio.UseVisualStyleBackColor = true;
            this.genderMaleRadio.CheckedChanged += new System.EventHandler(this.genderMaleRadio_CheckedChanged);
            // 
            // genderFemaleRadio
            // 
            this.genderFemaleRadio.AutoSize = true;
            this.genderFemaleRadio.Depth = 0;
            this.genderFemaleRadio.Location = new System.Drawing.Point(320, 416);
            this.genderFemaleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.genderFemaleRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.genderFemaleRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.genderFemaleRadio.Name = "genderFemaleRadio";
            this.genderFemaleRadio.Ripple = true;
            this.genderFemaleRadio.Size = new System.Drawing.Size(102, 37);
            this.genderFemaleRadio.TabIndex = 12;
            this.genderFemaleRadio.TabStop = true;
            this.genderFemaleRadio.Text = "Женский";
            this.genderFemaleRadio.UseVisualStyleBackColor = true;
            this.genderFemaleRadio.CheckedChanged += new System.EventHandler(this.genderFemaleRadio_CheckedChanged);
            // 
            // butCreate
            // 
            this.butCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butCreate.Depth = 0;
            this.butCreate.Enabled = false;
            this.butCreate.HighEmphasis = true;
            this.butCreate.Icon = null;
            this.butCreate.Location = new System.Drawing.Point(142, 780);
            this.butCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.butCreate.Name = "butCreate";
            this.butCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butCreate.Size = new System.Drawing.Size(89, 36);
            this.butCreate.TabIndex = 13;
            this.butCreate.Text = "Создать";
            this.butCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butCreate.UseAccentColor = false;
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // butCancel
            // 
            this.butCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butCancel.Depth = 0;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.HighEmphasis = true;
            this.butCancel.Icon = null;
            this.butCancel.Location = new System.Drawing.Point(509, 780);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.butCancel.Name = "butCancel";
            this.butCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butCancel.Size = new System.Drawing.Size(90, 36);
            this.butCancel.TabIndex = 14;
            this.butCancel.Text = "Закрыть";
            this.butCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.butCancel.UseAccentColor = false;
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(249, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(100, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "*Обязательно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(94, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "*Обязательно";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(209, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "*Обязательно";
            // 
            // maskPhoneText
            // 
            this.maskPhoneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.maskPhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maskPhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maskPhoneText.Location = new System.Drawing.Point(97, 513);
            this.maskPhoneText.Mask = "(000)-000-00-00";
            this.maskPhoneText.Name = "maskPhoneText";
            this.maskPhoneText.Size = new System.Drawing.Size(571, 23);
            this.maskPhoneText.SkipLiterals = false;
            this.maskPhoneText.TabIndex = 7;
            this.maskPhoneText.TextChanged += new System.EventHandler(this.maskPhoneText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(94, 659);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "*Обязательно";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.AnimateReadOnly = false;
            this.passwordBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordBox.Depth = 0;
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.HideSelection = true;
            this.passwordBox.Hint = "Пароль";
            this.passwordBox.LeadingIcon = null;
            this.passwordBox.Location = new System.Drawing.Point(97, 697);
            this.passwordBox.MaxLength = 20;
            this.passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PrefixSuffixText = null;
            this.passwordBox.ReadOnly = false;
            this.passwordBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(571, 48);
            this.passwordBox.TabIndex = 19;
            this.passwordBox.TabStop = false;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordBox.TrailingIcon = null;
            this.passwordBox.UseSystemPasswordChar = false;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // PersonRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 846);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.genderFemaleRadio);
            this.Controls.Add(this.genderMaleRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskNumberCardText);
            this.Controls.Add(this.maskPhoneText);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 846);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 846);
            this.Name = "PersonRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 nameBox;
        private MaterialSkin.Controls.MaterialTextBox2 surnameBox;
        private System.Windows.Forms.MaskedTextBox maskNumberCardText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRadioButton genderMaleRadio;
        private MaterialSkin.Controls.MaterialRadioButton genderFemaleRadio;
        private MaterialSkin.Controls.MaterialButton butCreate;
        private MaterialSkin.Controls.MaterialButton butCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskPhoneText;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox2 passwordBox;
    }
}