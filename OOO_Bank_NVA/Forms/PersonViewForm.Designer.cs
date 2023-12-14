namespace OOO_Bank_NVA.Forms
{
    partial class PersonViewForm
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.butBan = new MaterialSkin.Controls.MaterialButton();
            this.textBoxGender = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxSurname = new MaterialSkin.Controls.MaterialTextBox2();
            this.panelEditProfile = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskTextBoxCardName = new System.Windows.Forms.MaskedTextBox();
            this.maskTextBoxPhone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butTranslate = new MaterialSkin.Controls.MaterialButton();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panelEditProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.textBoxGender);
            this.panel10.Controls.Add(this.textBoxName);
            this.panel10.Controls.Add(this.textBoxSurname);
            this.panel10.Controls.Add(this.panelEditProfile);
            this.panel10.Controls.Add(this.maskTextBoxPhone);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel10.Location = new System.Drawing.Point(4, 98);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(483, 598);
            this.panel10.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Location = new System.Drawing.Point(278, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 46);
            this.panel1.TabIndex = 9;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(0, 0);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(178, 46);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Назад";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.butBan);
            this.panel13.Location = new System.Drawing.Point(21, 526);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(234, 46);
            this.panel13.TabIndex = 8;
            // 
            // butBan
            // 
            this.butBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butBan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butBan.Depth = 0;
            this.butBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBan.HighEmphasis = true;
            this.butBan.Icon = null;
            this.butBan.Location = new System.Drawing.Point(0, 0);
            this.butBan.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.butBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.butBan.Name = "butBan";
            this.butBan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butBan.Size = new System.Drawing.Size(234, 46);
            this.butBan.TabIndex = 0;
            this.butBan.Text = "Забанить аккаунт";
            this.butBan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butBan.UseAccentColor = false;
            this.butBan.UseVisualStyleBackColor = true;
            this.butBan.Click += new System.EventHandler(this.butBan_Click);
            // 
            // textBoxGender
            // 
            this.textBoxGender.AnimateReadOnly = true;
            this.textBoxGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxGender.Depth = 0;
            this.textBoxGender.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBoxGender.HideSelection = true;
            this.textBoxGender.Hint = "Пол";
            this.textBoxGender.LeadingIcon = null;
            this.textBoxGender.Location = new System.Drawing.Point(28, 255);
            this.textBoxGender.MaxLength = 32767;
            this.textBoxGender.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.PasswordChar = '\0';
            this.textBoxGender.PrefixSuffixText = null;
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxGender.SelectedText = "";
            this.textBoxGender.SelectionLength = 0;
            this.textBoxGender.SelectionStart = 0;
            this.textBoxGender.ShortcutsEnabled = true;
            this.textBoxGender.Size = new System.Drawing.Size(428, 48);
            this.textBoxGender.TabIndex = 4;
            this.textBoxGender.TabStop = false;
            this.textBoxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxGender.TrailingIcon = null;
            this.textBoxGender.UseSystemPasswordChar = false;
            // 
            // textBoxName
            // 
            this.textBoxName.AnimateReadOnly = true;
            this.textBoxName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxName.Depth = 0;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBoxName.HideSelection = true;
            this.textBoxName.Hint = "Имя";
            this.textBoxName.LeadingIcon = null;
            this.textBoxName.Location = new System.Drawing.Point(28, 105);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PrefixSuffixText = null;
            this.textBoxName.ReadOnly = true;
            this.textBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.ShortcutsEnabled = true;
            this.textBoxName.Size = new System.Drawing.Size(428, 48);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TabStop = false;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TrailingIcon = null;
            this.textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.AnimateReadOnly = true;
            this.textBoxSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSurname.Depth = 0;
            this.textBoxSurname.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBoxSurname.HideSelection = true;
            this.textBoxSurname.Hint = "Фамилия";
            this.textBoxSurname.LeadingIcon = null;
            this.textBoxSurname.Location = new System.Drawing.Point(28, 28);
            this.textBoxSurname.MaxLength = 32767;
            this.textBoxSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PasswordChar = '\0';
            this.textBoxSurname.PrefixSuffixText = null;
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSurname.SelectedText = "";
            this.textBoxSurname.SelectionLength = 0;
            this.textBoxSurname.SelectionStart = 0;
            this.textBoxSurname.ShortcutsEnabled = false;
            this.textBoxSurname.Size = new System.Drawing.Size(428, 48);
            this.textBoxSurname.TabIndex = 0;
            this.textBoxSurname.TabStop = false;
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSurname.TrailingIcon = null;
            this.textBoxSurname.UseSystemPasswordChar = false;
            // 
            // panelEditProfile
            // 
            this.panelEditProfile.Controls.Add(this.panel2);
            this.panelEditProfile.Controls.Add(this.groupBox1);
            this.panelEditProfile.Location = new System.Drawing.Point(21, 323);
            this.panelEditProfile.Name = "panelEditProfile";
            this.panelEditProfile.Size = new System.Drawing.Size(435, 168);
            this.panelEditProfile.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskTextBoxCardName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Карта";
            // 
            // maskTextBoxCardName
            // 
            this.maskTextBoxCardName.Location = new System.Drawing.Point(10, 38);
            this.maskTextBoxCardName.Mask = "0000-0000-0000-0000";
            this.maskTextBoxCardName.Name = "maskTextBoxCardName";
            this.maskTextBoxCardName.ReadOnly = true;
            this.maskTextBoxCardName.Size = new System.Drawing.Size(388, 40);
            this.maskTextBoxCardName.TabIndex = 11;
            this.maskTextBoxCardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskTextBoxPhone
            // 
            this.maskTextBoxPhone.AllowPromptAsInput = true;
            this.maskTextBoxPhone.AnimateReadOnly = true;
            this.maskTextBoxPhone.AsciiOnly = false;
            this.maskTextBoxPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maskTextBoxPhone.BeepOnError = false;
            this.maskTextBoxPhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.maskTextBoxPhone.Depth = 0;
            this.maskTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maskTextBoxPhone.HidePromptOnLeave = true;
            this.maskTextBoxPhone.HideSelection = true;
            this.maskTextBoxPhone.Hint = "Телефон";
            this.maskTextBoxPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.maskTextBoxPhone.LeadingIcon = null;
            this.maskTextBoxPhone.Location = new System.Drawing.Point(28, 182);
            this.maskTextBoxPhone.Mask = "(000)-000-00-00";
            this.maskTextBoxPhone.MaxLength = 32767;
            this.maskTextBoxPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.maskTextBoxPhone.Name = "maskTextBoxPhone";
            this.maskTextBoxPhone.PasswordChar = '\0';
            this.maskTextBoxPhone.PrefixSuffixText = null;
            this.maskTextBoxPhone.PromptChar = '_';
            this.maskTextBoxPhone.ReadOnly = true;
            this.maskTextBoxPhone.RejectInputOnFirstFailure = false;
            this.maskTextBoxPhone.ResetOnPrompt = true;
            this.maskTextBoxPhone.ResetOnSpace = true;
            this.maskTextBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskTextBoxPhone.SelectedText = "";
            this.maskTextBoxPhone.SelectionLength = 0;
            this.maskTextBoxPhone.SelectionStart = 15;
            this.maskTextBoxPhone.ShortcutsEnabled = true;
            this.maskTextBoxPhone.Size = new System.Drawing.Size(428, 48);
            this.maskTextBoxPhone.SkipLiterals = true;
            this.maskTextBoxPhone.TabIndex = 7;
            this.maskTextBoxPhone.TabStop = false;
            this.maskTextBoxPhone.Text = "(000)-000-00-00";
            this.maskTextBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskTextBoxPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.maskTextBoxPhone.TrailingIcon = null;
            this.maskTextBoxPhone.UseSystemPasswordChar = false;
            this.maskTextBoxPhone.ValidatingType = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butTranslate);
            this.panel2.Location = new System.Drawing.Point(109, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 46);
            this.panel2.TabIndex = 9;
            // 
            // butTranslate
            // 
            this.butTranslate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butTranslate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butTranslate.Depth = 0;
            this.butTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butTranslate.HighEmphasis = true;
            this.butTranslate.Icon = null;
            this.butTranslate.Location = new System.Drawing.Point(0, 0);
            this.butTranslate.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.butTranslate.MouseState = MaterialSkin.MouseState.HOVER;
            this.butTranslate.Name = "butTranslate";
            this.butTranslate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butTranslate.Size = new System.Drawing.Size(234, 46);
            this.butTranslate.TabIndex = 0;
            this.butTranslate.Text = "Перевести деньги";
            this.butTranslate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butTranslate.UseAccentColor = false;
            this.butTranslate.UseVisualStyleBackColor = true;
            this.butTranslate.Click += new System.EventHandler(this.butTranslate_Click);
            // 
            // PersonViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 701);
            this.Controls.Add(this.panel10);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(486, 701);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 701);
            this.Name = "PersonViewForm";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль пользователя";
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panelEditProfile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxGender;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxSurname;
        private System.Windows.Forms.Panel panelEditProfile;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskTextBoxCardName;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskTextBoxPhone;
        private MaterialSkin.Controls.MaterialButton butBan;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton butTranslate;
    }
}