namespace OOO_Bank_NVA.Forms
{
    partial class FiltrAndSortForm
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
            this.listBoxSort = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butSort = new MaterialSkin.Controls.MaterialButton();
            this.radioDesc = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioAsc = new MaterialSkin.Controls.MaterialRadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewNew = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNew)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSort
            // 
            this.listBoxSort.FormattingEnabled = true;
            this.listBoxSort.ItemHeight = 19;
            this.listBoxSort.Location = new System.Drawing.Point(3, 22);
            this.listBoxSort.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSort.Name = "listBoxSort";
            this.listBoxSort.Size = new System.Drawing.Size(226, 175);
            this.listBoxSort.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.radioDesc);
            this.groupBox1.Controls.Add(this.radioAsc);
            this.groupBox1.Controls.Add(this.listBoxSort);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(624, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(233, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.butSort, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 280);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 42);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // butSort
            // 
            this.butSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butSort.Depth = 0;
            this.butSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butSort.HighEmphasis = true;
            this.butSort.Icon = null;
            this.butSort.Location = new System.Drawing.Point(3, 4);
            this.butSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.butSort.Name = "butSort";
            this.butSort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butSort.Size = new System.Drawing.Size(223, 34);
            this.butSort.TabIndex = 4;
            this.butSort.Text = "Сортировать";
            this.butSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butSort.UseAccentColor = false;
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // radioDesc
            // 
            this.radioDesc.AutoSize = true;
            this.radioDesc.Depth = 0;
            this.radioDesc.Location = new System.Drawing.Point(5, 248);
            this.radioDesc.Margin = new System.Windows.Forms.Padding(0);
            this.radioDesc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioDesc.Name = "radioDesc";
            this.radioDesc.Ripple = true;
            this.radioDesc.Size = new System.Drawing.Size(137, 37);
            this.radioDesc.TabIndex = 3;
            this.radioDesc.TabStop = true;
            this.radioDesc.Text = "По убыванию";
            this.radioDesc.UseVisualStyleBackColor = true;
            // 
            // radioAsc
            // 
            this.radioAsc.AutoSize = true;
            this.radioAsc.Depth = 0;
            this.radioAsc.Location = new System.Drawing.Point(4, 213);
            this.radioAsc.Margin = new System.Windows.Forms.Padding(0);
            this.radioAsc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioAsc.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioAsc.Name = "radioAsc";
            this.radioAsc.Ripple = true;
            this.radioAsc.Size = new System.Drawing.Size(159, 37);
            this.radioAsc.TabIndex = 2;
            this.radioAsc.TabStop = true;
            this.radioAsc.Text = "По возрастанию";
            this.radioAsc.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewNew);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 70);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(859, 328);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridViewNew
            // 
            this.dataGridViewNew.AllowUserToAddRows = false;
            this.dataGridViewNew.AllowUserToDeleteRows = false;
            this.dataGridViewNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNew.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewNew.Name = "dataGridViewNew";
            this.dataGridViewNew.ReadOnly = true;
            this.dataGridViewNew.Size = new System.Drawing.Size(616, 324);
            this.dataGridViewNew.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(5, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фильтрация";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Привет",
            "Тест",
            "Как выглдишь"});
            this.materialComboBox1.Location = new System.Drawing.Point(154, 403);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(304, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(5, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по названию";
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "Поиск по всем столбцам";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(154, 469);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(304, 48);
            this.materialTextBox21.TabIndex = 7;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(485, 444);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(129, 36);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "Показать все";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BackColor = System.Drawing.Color.Red;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.materialButton3.HighEmphasis = false;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(707, 474);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(90, 36);
            this.materialButton3.TabIndex = 12;
            this.materialButton3.Text = "Закрыть";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = false;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.BackColor = System.Drawing.Color.Red;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(707, 416);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(89, 36);
            this.materialButton4.TabIndex = 13;
            this.materialButton4.Text = "Экспорт";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = false;
            // 
            // FiltrAndSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 532);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialTextBox21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(867, 532);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(867, 532);
            this.Name = "FiltrAndSortForm";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка и фильтрация данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton butSort;
        private MaterialSkin.Controls.MaterialRadioButton radioDesc;
        private MaterialSkin.Controls.MaterialRadioButton radioAsc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private System.Windows.Forms.DataGridView dataGridViewNew;
    }
}