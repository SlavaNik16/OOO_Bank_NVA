namespace OOO_Bank_NVA.Forms
{
    partial class RegCardBankForm
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
            this.maskedTextBoxNomer = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butEnter = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.maskedTextBoxPinCode = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxNomer
            // 
            this.maskedTextBoxNomer.Location = new System.Drawing.Point(52, 42);
            this.maskedTextBoxNomer.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxNomer.Name = "maskedTextBoxNomer";
            this.maskedTextBoxNomer.Size = new System.Drawing.Size(402, 29);
            this.maskedTextBoxNomer.TabIndex = 0;
            this.maskedTextBoxNomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxNomer.TextChanged += new System.EventHandler(this.maskedTextBoxNomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Придумайте номер карты";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskedTextBoxPinCode);
            this.panel1.Controls.Add(this.maskedTextBoxNomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 150);
            this.panel1.TabIndex = 2;
            // 
            // butEnter
            // 
            this.butEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEnter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butEnter.Depth = 0;
            this.butEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butEnter.Enabled = false;
            this.butEnter.HighEmphasis = true;
            this.butEnter.Icon = null;
            this.butEnter.Location = new System.Drawing.Point(24, 11);
            this.butEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.butEnter.Name = "butEnter";
            this.butEnter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butEnter.Size = new System.Drawing.Size(129, 36);
            this.butEnter.TabIndex = 3;
            this.butEnter.Text = "Подтвердить";
            this.butEnter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butEnter.UseAccentColor = false;
            this.butEnter.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.butEnter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 62);
            this.panel2.TabIndex = 4;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(387, 11);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(101, 36);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "Отменить";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPinCode
            // 
            this.maskedTextBoxPinCode.Location = new System.Drawing.Point(52, 112);
            this.maskedTextBoxPinCode.Mask = "0-0-0-0";
            this.maskedTextBoxPinCode.Name = "maskedTextBoxPinCode";
            this.maskedTextBoxPinCode.Size = new System.Drawing.Size(402, 29);
            this.maskedTextBoxPinCode.TabIndex = 3;
            this.maskedTextBoxPinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxPinCode.TextChanged += new System.EventHandler(this.maskedTextBoxPinCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Придумайте пин-код";
            // 
            // RegCardBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 218);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegCardBankForm";
            this.Text = "Регистрация карты";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxNomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton butEnter;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPinCode;
    }
}