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
            this.butEnter = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.maskDataEnd = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.maskedTextBoxNomer = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCVCCode = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // butEnter
            // 
            this.butEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEnter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butEnter.Depth = 0;
            this.butEnter.Enabled = false;
            this.butEnter.HighEmphasis = true;
            this.butEnter.Icon = null;
            this.butEnter.Location = new System.Drawing.Point(36, 286);
            this.butEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.butEnter.Name = "butEnter";
            this.butEnter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butEnter.Size = new System.Drawing.Size(129, 36);
            this.butEnter.TabIndex = 0;
            this.butEnter.Text = "Подтвердить";
            this.butEnter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butEnter.UseAccentColor = false;
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(289, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "CVC код";
            // 
            // maskDataEnd
            // 
            this.maskDataEnd.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.maskDataEnd.Location = new System.Drawing.Point(46, 232);
            this.maskDataEnd.Mask = "00/00";
            this.maskDataEnd.Name = "maskDataEnd";
            this.maskDataEnd.Size = new System.Drawing.Size(132, 35);
            this.maskDataEnd.TabIndex = 14;
            this.maskDataEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskDataEnd.TextChanged += new System.EventHandler(this.maskDataEnd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата окончания";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(317, 286);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(82, 36);
            this.materialButton2.TabIndex = 17;
            this.materialButton2.Text = "Отмена";
            this.materialButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxNomer
            // 
            this.maskedTextBoxNomer.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.maskedTextBoxNomer.Location = new System.Drawing.Point(56, 131);
            this.maskedTextBoxNomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxNomer.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxNomer.Name = "maskedTextBoxNomer";
            this.maskedTextBoxNomer.Size = new System.Drawing.Size(343, 35);
            this.maskedTextBoxNomer.TabIndex = 18;
            this.maskedTextBoxNomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxNomer.TextChanged += new System.EventHandler(this.maskedTextBoxNomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Номер карты";
            // 
            // maskedTextBoxCVCCode
            // 
            this.maskedTextBoxCVCCode.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.maskedTextBoxCVCCode.Location = new System.Drawing.Point(267, 232);
            this.maskedTextBoxCVCCode.Mask = "000";
            this.maskedTextBoxCVCCode.Name = "maskedTextBoxCVCCode";
            this.maskedTextBoxCVCCode.Size = new System.Drawing.Size(132, 35);
            this.maskedTextBoxCVCCode.TabIndex = 20;
            this.maskedTextBoxCVCCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxCVCCode.TextChanged += new System.EventHandler(this.maskedTextBoxCVCCode_TextChanged);
            // 
            // CardValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 350);
            this.Controls.Add(this.maskedTextBoxCVCCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxNomer);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskDataEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butEnter);
            this.Name = "CardValidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение карты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton butEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskDataEnd;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCVCCode;
    }
}