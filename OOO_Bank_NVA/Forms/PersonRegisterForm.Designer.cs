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
            this.label1 = new System.Windows.Forms.Label();
            this.butCreate = new MaterialSkin.Controls.MaterialButton();
            this.butCancel = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskPhoneText = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.logoCollegePictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.genderMaleRadio = new System.Windows.Forms.RadioButton();
            this.genderFemaleRadio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCollegePictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(39, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Телефон";
            // 
            // butCreate
            // 
            this.butCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butCreate.Depth = 0;
            this.butCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCreate.Enabled = false;
            this.butCreate.HighEmphasis = true;
            this.butCreate.Icon = null;
            this.butCreate.Location = new System.Drawing.Point(54, 6);
            this.butCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.butCreate.Name = "butCreate";
            this.butCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butCreate.Size = new System.Drawing.Size(202, 52);
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
            this.butCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCancel.HighEmphasis = true;
            this.butCancel.Icon = null;
            this.butCancel.Location = new System.Drawing.Point(390, 6);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.butCancel.Name = "butCancel";
            this.butCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butCancel.Size = new System.Drawing.Size(211, 52);
            this.butCancel.TabIndex = 14;
            this.butCancel.Text = "Закрыть";
            this.butCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butCancel.UseAccentColor = true;
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(365, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(188, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "*Обязательно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(188, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "*Обязательно";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(188, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "*Обязательно";
            // 
            // maskPhoneText
            // 
            this.maskPhoneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.maskPhoneText.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskPhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maskPhoneText.Location = new System.Drawing.Point(42, 424);
            this.maskPhoneText.Mask = "(000)-000-00-00";
            this.maskPhoneText.Name = "maskPhoneText";
            this.maskPhoneText.Size = new System.Drawing.Size(290, 44);
            this.maskPhoneText.SkipLiterals = false;
            this.maskPhoneText.TabIndex = 7;
            this.maskPhoneText.TextChanged += new System.EventHandler(this.maskPhoneText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(188, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "*Обязательно";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.genderFemaleRadio);
            this.panel1.Controls.Add(this.genderMaleRadio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskPhoneText);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.surnameBox);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Menu;
            this.panel1.Location = new System.Drawing.Point(3, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 625);
            this.panel1.TabIndex = 21;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Salmon;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.logoCollegePictureBox);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(657, 104);
            this.panelHeader.TabIndex = 21;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(179, 35);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(442, 36);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Информация об пользователе";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoCollegePictureBox
            // 
            this.logoCollegePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoCollegePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoCollegePictureBox.Image = global::OOO_Bank_NVA.Properties.Resources.usersInfo;
            this.logoCollegePictureBox.Location = new System.Drawing.Point(15, 8);
            this.logoCollegePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoCollegePictureBox.Name = "logoCollegePictureBox";
            this.logoCollegePictureBox.Size = new System.Drawing.Size(123, 82);
            this.logoCollegePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoCollegePictureBox.TabIndex = 0;
            this.logoCollegePictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.656968F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.15926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.29556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.53752F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.19755F));
            this.tableLayoutPanel1.Controls.Add(this.butCancel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.butCreate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 723);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 64);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(39, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = "Пароль";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(45, 546);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(567, 44);
            this.passwordBox.TabIndex = 23;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // genderMaleRadio
            // 
            this.genderMaleRadio.AutoSize = true;
            this.genderMaleRadio.Checked = true;
            this.genderMaleRadio.Location = new System.Drawing.Point(457, 387);
            this.genderMaleRadio.Name = "genderMaleRadio";
            this.genderMaleRadio.Size = new System.Drawing.Size(164, 40);
            this.genderMaleRadio.TabIndex = 24;
            this.genderMaleRadio.Text = "Мужской";
            this.genderMaleRadio.UseVisualStyleBackColor = true;
            this.genderMaleRadio.CheckedChanged += new System.EventHandler(this.genderMaleRadio_CheckedChanged);
            // 
            // genderFemaleRadio
            // 
            this.genderFemaleRadio.AutoSize = true;
            this.genderFemaleRadio.Location = new System.Drawing.Point(457, 457);
            this.genderFemaleRadio.Name = "genderFemaleRadio";
            this.genderFemaleRadio.Size = new System.Drawing.Size(162, 40);
            this.genderFemaleRadio.TabIndex = 25;
            this.genderFemaleRadio.Text = "Женский";
            this.genderFemaleRadio.UseVisualStyleBackColor = true;
            this.genderFemaleRadio.CheckedChanged += new System.EventHandler(this.genderFemaleRadio_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(39, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 36);
            this.label8.TabIndex = 26;
            this.label8.Text = "Имя";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(45, 291);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(574, 44);
            this.nameBox.TabIndex = 27;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Menu;
            this.label9.Location = new System.Drawing.Point(39, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 36);
            this.label9.TabIndex = 28;
            this.label9.Text = "Фамилия";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(45, 175);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(574, 44);
            this.surnameBox.TabIndex = 29;
            this.surnameBox.TextChanged += new System.EventHandler(this.surnameBox_TextChanged);
            // 
            // PersonRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(659, 790);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCollegePictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton butCreate;
        private MaterialSkin.Controls.MaterialButton butCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskPhoneText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox logoCollegePictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton genderFemaleRadio;
        private System.Windows.Forms.RadioButton genderMaleRadio;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
    }
}