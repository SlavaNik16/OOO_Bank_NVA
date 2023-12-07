namespace OOO_Bank_NVA.Forms
{
    partial class FiltrAndSortTovarForm
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
            this.dataGridViewTovar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.butViewAll = new MaterialSkin.Controls.MaterialButton();
            this.butOk = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butSearch = new System.Windows.Forms.Button();
            this.butFiltr = new System.Windows.Forms.Button();
            this.butExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSort
            // 
            this.listBoxSort.FormattingEnabled = true;
            this.listBoxSort.ItemHeight = 27;
            this.listBoxSort.Items.AddRange(new object[] {
            "Название",
            "Цена",
            "Макс. кол-во"});
            this.listBoxSort.Location = new System.Drawing.Point(4, 34);
            this.listBoxSort.Name = "listBoxSort";
            this.listBoxSort.Size = new System.Drawing.Size(337, 247);
            this.listBoxSort.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.radioDesc);
            this.groupBox1.Controls.Add(this.radioAsc);
            this.groupBox1.Controls.Add(this.listBoxSort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(930, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 498);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 430);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 65);
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
            this.butSort.Location = new System.Drawing.Point(4, 6);
            this.butSort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.butSort.Name = "butSort";
            this.butSort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butSort.Size = new System.Drawing.Size(336, 53);
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
            this.radioDesc.Location = new System.Drawing.Point(8, 365);
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
            this.radioAsc.Checked = true;
            this.radioAsc.Depth = 0;
            this.radioAsc.Location = new System.Drawing.Point(8, 306);
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
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewTovar);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1288, 505);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridViewTovar
            // 
            this.dataGridViewTovar.AllowUserToAddRows = false;
            this.dataGridViewTovar.AllowUserToDeleteRows = false;
            this.dataGridViewTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTovar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewTovar.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTovar.Name = "dataGridViewTovar";
            this.dataGridViewTovar.ReadOnly = true;
            this.dataGridViewTovar.RowHeadersWidth = 62;
            this.dataGridViewTovar.RowTemplate.Height = 28;
            this.dataGridViewTovar.Size = new System.Drawing.Size(921, 494);
            this.dataGridViewTovar.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaxCount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Макс. кол-во";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Photo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фото";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "№";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(18, 642);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по названию";
            // 
            // searchBox
            // 
            this.searchBox.AnimateReadOnly = false;
            this.searchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBox.Depth = 0;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox.HideSelection = true;
            this.searchBox.Hint = "Поиск по всем столбцам";
            this.searchBox.LeadingIcon = null;
            this.searchBox.Location = new System.Drawing.Point(239, 630);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.MaxLength = 80;
            this.searchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PrefixSuffixText = null;
            this.searchBox.ReadOnly = false;
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(331, 48);
            this.searchBox.TabIndex = 7;
            this.searchBox.TabStop = false;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.TrailingIcon = null;
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // butViewAll
            // 
            this.butViewAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butViewAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butViewAll.Depth = 0;
            this.butViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butViewAll.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.butViewAll.HighEmphasis = true;
            this.butViewAll.Icon = null;
            this.butViewAll.Location = new System.Drawing.Point(6, 9);
            this.butViewAll.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.butViewAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.butViewAll.Name = "butViewAll";
            this.butViewAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butViewAll.Size = new System.Drawing.Size(346, 80);
            this.butViewAll.TabIndex = 11;
            this.butViewAll.Text = "Показать все";
            this.butViewAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butViewAll.UseAccentColor = false;
            this.butViewAll.UseVisualStyleBackColor = true;
            this.butViewAll.Click += new System.EventHandler(this.butViewAll_Click);
            // 
            // butOk
            // 
            this.butOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butOk.BackColor = System.Drawing.Color.Red;
            this.butOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butOk.Depth = 0;
            this.butOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butOk.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.butOk.HighEmphasis = false;
            this.butOk.Icon = null;
            this.butOk.Location = new System.Drawing.Point(6, 107);
            this.butOk.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.butOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.butOk.Name = "butOk";
            this.butOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butOk.Size = new System.Drawing.Size(346, 81);
            this.butOk.TabIndex = 12;
            this.butOk.Text = "Подтвердить";
            this.butOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.butOk.UseAccentColor = false;
            this.butOk.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(18, 749);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Цена в пределах";
            // 
            // priceBox
            // 
            this.priceBox.AnimateReadOnly = false;
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceBox.Depth = 0;
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceBox.LeadingIcon = null;
            this.priceBox.Location = new System.Drawing.Point(239, 736);
            this.priceBox.MaxLength = 7;
            this.priceBox.MouseState = MaterialSkin.MouseState.OUT;
            this.priceBox.Multiline = false;
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(331, 50);
            this.priceBox.TabIndex = 19;
            this.priceBox.Text = "";
            this.priceBox.TrailingIcon = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.butViewAll, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butOk, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(936, 615);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 197);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // butSearch
            // 
            this.butSearch.Enabled = false;
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.butSearch.Location = new System.Drawing.Point(614, 631);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(153, 48);
            this.butSearch.TabIndex = 21;
            this.butSearch.Text = "Найти";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butFiltr
            // 
            this.butFiltr.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.butFiltr.Location = new System.Drawing.Point(604, 738);
            this.butFiltr.Name = "butFiltr";
            this.butFiltr.Size = new System.Drawing.Size(163, 48);
            this.butFiltr.TabIndex = 22;
            this.butFiltr.Text = "Фильтровать";
            this.butFiltr.UseVisualStyleBackColor = true;
            // 
            // butExport
            // 
            this.butExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butExport.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.butExport.Location = new System.Drawing.Point(783, 669);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(141, 82);
            this.butExport.TabIndex = 23;
            this.butExport.Text = "Экспорт данных";
            this.butExport.UseVisualStyleBackColor = false;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // FiltrAndSortTovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 818);
            this.Controls.Add(this.butExport);
            this.Controls.Add(this.butFiltr);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 818);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 818);
            this.Name = "FiltrAndSortTovarForm";
            this.Padding = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка и фильтрация данных товара";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 searchBox;
        private MaterialSkin.Controls.MaterialButton butViewAll;
        private MaterialSkin.Controls.MaterialButton butOk;
        private System.Windows.Forms.DataGridView dataGridViewTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox priceBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butFiltr;
        private System.Windows.Forms.Button butExport;
    }
}