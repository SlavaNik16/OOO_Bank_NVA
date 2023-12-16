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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butEnter
            // 
            this.butEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEnter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butEnter.Depth = 0;
            this.butEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butEnter.Enabled = false;
            this.butEnter.HighEmphasis = true;
            this.butEnter.Icon = null;
            this.butEnter.Location = new System.Drawing.Point(46, 6);
            this.butEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.butEnter.Name = "butEnter";
            this.butEnter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butEnter.Size = new System.Drawing.Size(122, 46);
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
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(275, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "CVC код";
            // 
            // maskDataEnd
            // 
            this.maskDataEnd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskDataEnd.Location = new System.Drawing.Point(46, 232);
            this.maskDataEnd.Mask = "00/00";
            this.maskDataEnd.Name = "maskDataEnd";
            this.maskDataEnd.Size = new System.Drawing.Size(132, 40);
            this.maskDataEnd.TabIndex = 14;
            this.maskDataEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskDataEnd.TextChanged += new System.EventHandler(this.maskDataEnd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата окончания";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(264, 6);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(127, 46);
            this.materialButton2.TabIndex = 17;
            this.materialButton2.Text = "Отмена";
            this.materialButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxNomer
            // 
            this.maskedTextBoxNomer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxNomer.Location = new System.Drawing.Point(56, 131);
            this.maskedTextBoxNomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxNomer.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxNomer.Name = "maskedTextBoxNomer";
            this.maskedTextBoxNomer.Size = new System.Drawing.Size(343, 40);
            this.maskedTextBoxNomer.TabIndex = 18;
            this.maskedTextBoxNomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxNomer.TextChanged += new System.EventHandler(this.maskedTextBoxNomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Номер карты";
            // 
            // maskedTextBoxCVCCode
            // 
            this.maskedTextBoxCVCCode.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxCVCCode.Location = new System.Drawing.Point(267, 232);
            this.maskedTextBoxCVCCode.Mask = "000";
            this.maskedTextBoxCVCCode.Name = "maskedTextBoxCVCCode";
            this.maskedTextBoxCVCCode.Size = new System.Drawing.Size(132, 40);
            this.maskedTextBoxCVCCode.TabIndex = 20;
            this.maskedTextBoxCVCCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxCVCCode.TextChanged += new System.EventHandler(this.maskedTextBoxCVCCode_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Menu;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 295);
            this.panel1.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Controls.Add(this.materialButton2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.butEnter, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 237);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 58);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // CardValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 362);
            this.Controls.Add(this.maskedTextBoxCVCCode);
            this.Controls.Add(this.maskedTextBoxNomer);
            this.Controls.Add(this.maskDataEnd);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(466, 362);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(466, 362);
            this.Name = "CardValidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение карты";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}