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
            this.textBoxTittle = new MaterialSkin.Controls.MaterialTextBox2();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.butAdd = new MaterialSkin.Controls.MaterialButton();
            this.butCancel = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTovar
            // 
            this.pictureBoxTovar.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxTovar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTovar.Location = new System.Drawing.Point(37, 118);
            this.pictureBoxTovar.Name = "pictureBoxTovar";
            this.pictureBoxTovar.Size = new System.Drawing.Size(560, 226);
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
            // textBoxTittle
            // 
            this.textBoxTittle.AnimateReadOnly = false;
            this.textBoxTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxTittle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxTittle.Depth = 0;
            this.textBoxTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTittle.HideSelection = true;
            this.textBoxTittle.Hint = "Наименование";
            this.textBoxTittle.LeadingIcon = null;
            this.textBoxTittle.Location = new System.Drawing.Point(37, 374);
            this.textBoxTittle.MaxLength = 80;
            this.textBoxTittle.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTittle.Name = "textBoxTittle";
            this.textBoxTittle.PasswordChar = '\0';
            this.textBoxTittle.PrefixSuffixText = null;
            this.textBoxTittle.ReadOnly = false;
            this.textBoxTittle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTittle.SelectedText = "";
            this.textBoxTittle.SelectionLength = 0;
            this.textBoxTittle.SelectionStart = 0;
            this.textBoxTittle.ShortcutsEnabled = true;
            this.textBoxTittle.Size = new System.Drawing.Size(560, 48);
            this.textBoxTittle.TabIndex = 1;
            this.textBoxTittle.TabStop = false;
            this.textBoxTittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTittle.TrailingIcon = null;
            this.textBoxTittle.UseSystemPasswordChar = false;
            this.textBoxTittle.TextChanged += new System.EventHandler(this.textBoxTittle_TextChanged);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(170, 472);
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
            this.numericUpDownCount.Size = new System.Drawing.Size(145, 26);
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
            this.label1.Location = new System.Drawing.Point(44, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Макс. кол-во";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(37, 554);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(560, 126);
            this.textBoxDesc.TabIndex = 5;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AnimateReadOnly = false;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Depth = 0;
            this.textBoxPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPrice.Hint = "Цена";
            this.textBoxPrice.LeadingIcon = null;
            this.textBoxPrice.Location = new System.Drawing.Point(336, 460);
            this.textBoxPrice.MaxLength = 50;
            this.textBoxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPrice.Multiline = false;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(261, 50);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.Text = "";
            this.textBoxPrice.TrailingIcon = null;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
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
            this.butAdd.Location = new System.Drawing.Point(37, 706);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAdd.Name = "butAdd";
            this.butAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butAdd.Size = new System.Drawing.Size(100, 36);
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
            this.butCancel.HighEmphasis = true;
            this.butCancel.Icon = null;
            this.butCancel.Location = new System.Drawing.Point(497, 706);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.butCancel.Name = "butCancel";
            this.butCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butCancel.Size = new System.Drawing.Size(82, 36);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "Отмена";
            this.butCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.butCancel.UseAccentColor = false;
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // AddTovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 779);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.textBoxTittle);
            this.Controls.Add(this.pictureBoxTovar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTovarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTovar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxTittle;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox textBoxPrice;
        private MaterialSkin.Controls.MaterialButton butAdd;
        private MaterialSkin.Controls.MaterialButton butCancel;
    }
}