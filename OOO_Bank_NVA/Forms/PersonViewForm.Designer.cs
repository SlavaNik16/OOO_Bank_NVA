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
            this.textBoxGender = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxSurname = new MaterialSkin.Controls.MaterialTextBox2();
            this.panelEditProfile = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.butChangeCard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskTextBoxCardName = new System.Windows.Forms.MaskedTextBox();
            this.maskTextBoxPhone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel10.SuspendLayout();
            this.panelEditProfile.SuspendLayout();
            this.panel13.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.textBoxGender);
            this.panel10.Controls.Add(this.textBoxName);
            this.panel10.Controls.Add(this.textBoxSurname);
            this.panel10.Controls.Add(this.panelEditProfile);
            this.panel10.Controls.Add(this.maskTextBoxPhone);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel10.Location = new System.Drawing.Point(3, 64);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(323, 366);
            this.panel10.TabIndex = 1;
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
            this.textBoxGender.Location = new System.Drawing.Point(19, 166);
            this.textBoxGender.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBoxGender.Size = new System.Drawing.Size(275, 48);
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
            this.textBoxName.Location = new System.Drawing.Point(19, 68);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBoxName.Size = new System.Drawing.Size(275, 48);
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
            this.textBoxSurname.Location = new System.Drawing.Point(19, 18);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBoxSurname.Size = new System.Drawing.Size(275, 48);
            this.textBoxSurname.TabIndex = 0;
            this.textBoxSurname.TabStop = false;
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSurname.TrailingIcon = null;
            this.textBoxSurname.UseSystemPasswordChar = false;
            // 
            // panelEditProfile
            // 
            this.panelEditProfile.Controls.Add(this.panel13);
            this.panelEditProfile.Controls.Add(this.groupBox1);
            this.panelEditProfile.Location = new System.Drawing.Point(14, 233);
            this.panelEditProfile.Margin = new System.Windows.Forms.Padding(2);
            this.panelEditProfile.Name = "panelEditProfile";
            this.panelEditProfile.Size = new System.Drawing.Size(290, 121);
            this.panelEditProfile.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.butChangeCard);
            this.panel13.Location = new System.Drawing.Point(10, 79);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(271, 30);
            this.panel13.TabIndex = 8;
            // 
            // butChangeCard
            // 
            this.butChangeCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butChangeCard.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butChangeCard.Location = new System.Drawing.Point(0, 0);
            this.butChangeCard.Margin = new System.Windows.Forms.Padding(2);
            this.butChangeCard.Name = "butChangeCard";
            this.butChangeCard.Size = new System.Drawing.Size(271, 30);
            this.butChangeCard.TabIndex = 8;
            this.butChangeCard.Text = "Поменять карту";
            this.butChangeCard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskTextBoxCardName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(271, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Карта";
            // 
            // maskTextBoxCardName
            // 
            this.maskTextBoxCardName.Location = new System.Drawing.Point(7, 25);
            this.maskTextBoxCardName.Margin = new System.Windows.Forms.Padding(2);
            this.maskTextBoxCardName.Mask = "0000-0000-0000-0000";
            this.maskTextBoxCardName.Name = "maskTextBoxCardName";
            this.maskTextBoxCardName.ReadOnly = true;
            this.maskTextBoxCardName.Size = new System.Drawing.Size(260, 29);
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
            this.maskTextBoxPhone.Location = new System.Drawing.Point(19, 118);
            this.maskTextBoxPhone.Margin = new System.Windows.Forms.Padding(2);
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
            this.maskTextBoxPhone.Size = new System.Drawing.Size(275, 48);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(326, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 366);
            this.panel1.TabIndex = 2;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(102, 312);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(162, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Удалить аккаунт";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // PersonViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Name = "PersonViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль пользователя";
            this.panel10.ResumeLayout(false);
            this.panelEditProfile.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxGender;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxSurname;
        private System.Windows.Forms.Panel panelEditProfile;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button butChangeCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskTextBoxCardName;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskTextBoxPhone;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}