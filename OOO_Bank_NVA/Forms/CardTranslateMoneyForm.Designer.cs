namespace OOO_Bank_NVA.Forms
{
    partial class CardTranslateMoneyForm
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
            this.maskedTextBoxCard = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxCard
            // 
            this.maskedTextBoxCard.Location = new System.Drawing.Point(102, 59);
            this.maskedTextBoxCard.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxCard.Name = "maskedTextBoxCard";
            this.maskedTextBoxCard.ReadOnly = true;
            this.maskedTextBoxCard.Size = new System.Drawing.Size(544, 40);
            this.maskedTextBoxCard.TabIndex = 0;
            this.maskedTextBoxCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxBalance);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedTextBoxCard);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(37, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 313);
            this.panel1.TabIndex = 1;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(102, 242);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(544, 40);
            this.textBoxBalance.TabIndex = 5;
            this.textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Со счета:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(102, 155);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(544, 40);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пополнить на";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер карты";
            // 
            // butAdd
            // 
            this.butAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butAdd.Depth = 0;
            this.butAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAdd.Enabled = false;
            this.butAdd.HighEmphasis = true;
            this.butAdd.Icon = null;
            this.butAdd.Location = new System.Drawing.Point(37, 421);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAdd.Name = "butAdd";
            this.butAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butAdd.Size = new System.Drawing.Size(113, 36);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Пополнить";
            this.butAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butAdd.UseAccentColor = false;
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(653, 421);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(82, 36);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "Отмена";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // CardTranslateMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.panel1);
            this.Name = "CardTranslateMoneyForm";
            this.Text = "Перевод средств";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton butAdd;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}