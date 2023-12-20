namespace OOO_Bank_NVA.Forms
{
    partial class PersonEnterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butEnter = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskPhoneText = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Телефон";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.butEnter);
            this.panel1.Controls.Add(this.butCancel);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskPhoneText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Menu;
            this.panel1.Location = new System.Drawing.Point(2, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 196);
            this.panel1.TabIndex = 0;
            // 
            // butEnter
            // 
            this.butEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butEnter.Enabled = false;
            this.butEnter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.butEnter.Location = new System.Drawing.Point(22, 140);
            this.butEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(142, 39);
            this.butEnter.TabIndex = 2;
            this.butEnter.Text = "Подтвердить";
            this.butEnter.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.butCancel.Location = new System.Drawing.Point(199, 140);
            this.butCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(140, 39);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Отменить";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(151, 82);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.Size = new System.Drawing.Size(179, 32);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Пароль";
            // 
            // maskPhoneText
            // 
            this.maskPhoneText.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskPhoneText.Location = new System.Drawing.Point(151, 25);
            this.maskPhoneText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskPhoneText.Mask = "(000)-000-00-00";
            this.maskPhoneText.Name = "maskPhoneText";
            this.maskPhoneText.Size = new System.Drawing.Size(179, 32);
            this.maskPhoneText.TabIndex = 0;
            this.maskPhoneText.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // PersonEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(367, 260);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonEnterForm";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskPhoneText;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
    }
}