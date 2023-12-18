namespace OOO_Bank_NVA.Forms
{
    partial class AddTovarForm
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
            this.pictureBoxTovar = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butAdd = new MaterialSkin.Controls.MaterialButton();
            this.butCancel = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTittle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTovar
            // 
            this.pictureBoxTovar.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxTovar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTovar.ErrorImage = global::OOO_Bank_NVA.Properties.Resources.photoEmpty;
            this.pictureBoxTovar.Image = global::OOO_Bank_NVA.Properties.Resources.photoEmpty;
            this.pictureBoxTovar.Location = new System.Drawing.Point(137, 18);
            this.pictureBoxTovar.Name = "pictureBoxTovar";
            this.pictureBoxTovar.Size = new System.Drawing.Size(373, 226);
            this.pictureBoxTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTovar.TabIndex = 0;
            this.pictureBoxTovar.TabStop = false;
            this.pictureBoxTovar.Click += new System.EventHandler(this.pictureBoxTovar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = " Изображение (*.png)|*.png|Изображение (*.jpeg)|*.jpeg";
            this.openFileDialog.InitialDirectory = "C://";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCount.Location = new System.Drawing.Point(224, 323);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(102, 40);
            this.numericUpDownCount.TabIndex = 3;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(37, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Макс. кол-во";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDesc.Location = new System.Drawing.Point(34, 435);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(560, 121);
            this.textBoxDesc.TabIndex = 5;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(37, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание";
            // 
            // butAdd
            // 
            this.butAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butAdd.Depth = 0;
            this.butAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butAdd.Enabled = false;
            this.butAdd.HighEmphasis = true;
            this.butAdd.Icon = null;
            this.butAdd.Location = new System.Drawing.Point(42, 6);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAdd.Name = "butAdd";
            this.butAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butAdd.Size = new System.Drawing.Size(205, 50);
            this.butAdd.TabIndex = 9;
            this.butAdd.Text = "Добавить";
            this.butAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butAdd.UseAccentColor = false;
            this.butAdd.UseVisualStyleBackColor = true;
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
            this.butCancel.Size = new System.Drawing.Size(194, 50);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "Отмена";
            this.butCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butCancel.UseAccentColor = true;
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.pictureBoxTovar);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxTittle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxDesc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(3, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 648);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(37, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Наименование";
            // 
            // textBoxTittle
            // 
            this.textBoxTittle.Location = new System.Drawing.Point(224, 261);
            this.textBoxTittle.Name = "textBoxTittle";
            this.textBoxTittle.Size = new System.Drawing.Size(367, 40);
            this.textBoxTittle.TabIndex = 12;
            this.textBoxTittle.TextChanged += new System.EventHandler(this.textBoxTittle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(437, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(342, 380);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(249, 40);
            this.textBoxPrice.TabIndex = 14;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.070288F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.02556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.56549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.26837F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.910543F));
            this.tableLayoutPanel1.Controls.Add(this.butAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butCancel, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 586);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 62);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // AddTovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 761);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTovarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTovar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton butAdd;
        private MaterialSkin.Controls.MaterialButton butCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTittle;
        private System.Windows.Forms.Label label3;
    }
}