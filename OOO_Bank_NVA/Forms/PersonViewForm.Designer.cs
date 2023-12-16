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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.butBan = new MaterialSkin.Controls.MaterialButton();
            this.panelEditProfile = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butTranslate = new MaterialSkin.Controls.MaterialButton();
            this.maskTextBoxCardName = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10.SuspendLayout();
            this.panelEditProfile.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.panel10.Controls.Add(this.tableLayoutPanel1);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.textBoxGender);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.maskTextBoxPhone);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.textBoxName);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.textBoxSurname);
            this.panel10.Controls.Add(this.panelEditProfile);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel10.ForeColor = System.Drawing.SystemColors.Menu;
            this.panel10.Location = new System.Drawing.Point(4, 98);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(483, 682);
            this.panel10.TabIndex = 1;
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
            this.materialButton1.Location = new System.Drawing.Point(318, 9);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(126, 41);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Назад";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // butBan
            // 
            this.butBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butBan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butBan.Depth = 0;
            this.butBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBan.HighEmphasis = true;
            this.butBan.Icon = null;
            this.butBan.Location = new System.Drawing.Point(28, 9);
            this.butBan.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.butBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.butBan.Name = "butBan";
            this.butBan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butBan.Size = new System.Drawing.Size(188, 41);
            this.butBan.TabIndex = 6;
            this.butBan.Text = "Забанить аккаунт";
            this.butBan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butBan.UseAccentColor = false;
            this.butBan.UseVisualStyleBackColor = true;
            this.butBan.Click += new System.EventHandler(this.butBan_Click);
            // 
            // panelEditProfile
            // 
            this.panelEditProfile.Controls.Add(this.maskTextBoxCardName);
            this.panelEditProfile.Controls.Add(this.label5);
            this.panelEditProfile.Controls.Add(this.panel2);
            this.panelEditProfile.ForeColor = System.Drawing.SystemColors.Menu;
            this.panelEditProfile.Location = new System.Drawing.Point(20, 413);
            this.panelEditProfile.Name = "panelEditProfile";
            this.panelEditProfile.Size = new System.Drawing.Size(435, 177);
            this.panelEditProfile.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butTranslate);
            this.panel2.Location = new System.Drawing.Point(109, 122);
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
            this.butTranslate.TabIndex = 5;
            this.butTranslate.Text = "Перевести деньги";
            this.butTranslate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butTranslate.UseAccentColor = false;
            this.butTranslate.UseVisualStyleBackColor = true;
            this.butTranslate.Click += new System.EventHandler(this.butTranslate_Click);
            // 
            // maskTextBoxCardName
            // 
            this.maskTextBoxCardName.Location = new System.Drawing.Point(26, 61);
            this.maskTextBoxCardName.Mask = "0000-0000-0000-0000";
            this.maskTextBoxCardName.Name = "maskTextBoxCardName";
            this.maskTextBoxCardName.ReadOnly = true;
            this.maskTextBoxCardName.Size = new System.Drawing.Size(388, 40);
            this.maskTextBoxCardName.TabIndex = 4;
            this.maskTextBoxCardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(28, 49);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(428, 40);
            this.textBoxSurname.TabIndex = 10;
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(28, 136);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(428, 40);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(25, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Телефон";
            // 
            // maskTextBoxPhone
            // 
            this.maskTextBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.maskTextBoxPhone.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.maskTextBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maskTextBoxPhone.Location = new System.Drawing.Point(28, 243);
            this.maskTextBoxPhone.Mask = "(000)-000-00-00";
            this.maskTextBoxPhone.Name = "maskTextBoxPhone";
            this.maskTextBoxPhone.Size = new System.Drawing.Size(428, 40);
            this.maskTextBoxPhone.SkipLiterals = false;
            this.maskTextBoxPhone.TabIndex = 14;
            this.maskTextBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Пол";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(27, 337);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(428, 40);
            this.textBoxGender.TabIndex = 16;
            this.textBoxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "Номер карты";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.554865F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.40787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.63354F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.625259F));
            this.tableLayoutPanel1.Controls.Add(this.materialButton1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.butBan, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 623);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 59);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // PersonViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 785);
            this.Controls.Add(this.panel10);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonViewForm";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль пользователя";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelEditProfile.ResumeLayout(false);
            this.panelEditProfile.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelEditProfile;
        private System.Windows.Forms.MaskedTextBox maskTextBoxCardName;
        private MaterialSkin.Controls.MaterialButton butBan;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton butTranslate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskTextBoxPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
    }
}