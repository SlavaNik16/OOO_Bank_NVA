namespace OOO_Bank_NVA.Forms
{
    partial class CardValidateForm
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.textBoxCVCCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskDataEnd = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(44, 238);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(129, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Подтвердить";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxCVCCode
            // 
            this.textBoxCVCCode.Location = new System.Drawing.Point(266, 162);
            this.textBoxCVCCode.MaxLength = 3;
            this.textBoxCVCCode.Name = "textBoxCVCCode";
            this.textBoxCVCCode.PasswordChar = '*';
            this.textBoxCVCCode.Size = new System.Drawing.Size(116, 26);
            this.textBoxCVCCode.TabIndex = 16;
            this.textBoxCVCCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "CVC код";
            // 
            // maskDataEnd
            // 
            this.maskDataEnd.Location = new System.Drawing.Point(40, 162);
            this.maskDataEnd.Mask = "00/00";
            this.maskDataEnd.Name = "maskDataEnd";
            this.maskDataEnd.Size = new System.Drawing.Size(132, 26);
            this.maskDataEnd.TabIndex = 14;
            this.maskDataEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата окончания";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(253, 238);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(129, 36);
            this.materialButton2.TabIndex = 17;
            this.materialButton2.Text = "Отмена";
            this.materialButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // CardValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 300);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.textBoxCVCCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskDataEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialButton1);
            this.Name = "CardValidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение карты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.TextBox textBoxCVCCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskDataEnd;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}