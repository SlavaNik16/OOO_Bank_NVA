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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewTovar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.butViewAll = new MaterialSkin.Controls.MaterialButton();
            this.butOk = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butSearch = new System.Windows.Forms.Button();
            this.butFiltr = new System.Windows.Forms.Button();
            this.butExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.radioAsc = new System.Windows.Forms.RadioButton();
            this.radioDesc = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.radioDesc);
            this.groupBox1.Controls.Add(this.radioAsc);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.listBoxSort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Menu;
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
            this.butSort.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.butSort.UseCompatibleTextRendering = true;
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewTovar);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1288, 505);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridViewTovar
            // 
            this.dataGridViewTovar.AllowUserToAddRows = false;
            this.dataGridViewTovar.AllowUserToDeleteRows = false;
            this.dataGridViewTovar.ColumnHeadersHeight = 34;
            this.dataGridViewTovar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewTovar.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTovar.MultiSelect = false;
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
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(21, 579);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск ";
            // 
            // butViewAll
            // 
            this.butViewAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butViewAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butViewAll.Depth = 0;
            this.butViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butViewAll.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.butOk.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butOk.HighEmphasis = true;
            this.butOk.Icon = null;
            this.butOk.Location = new System.Drawing.Point(6, 107);
            this.butOk.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.butOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.butOk.Name = "butOk";
            this.butOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butOk.Size = new System.Drawing.Size(346, 81);
            this.butOk.TabIndex = 12;
            this.butOk.Text = "Подтвердить";
            this.butOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butOk.UseAccentColor = true;
            this.butOk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(21, 682);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Цена";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.butViewAll, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butOk, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(930, 550);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 197);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // butSearch
            // 
            this.butSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butSearch.Enabled = false;
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.butSearch.Location = new System.Drawing.Point(3, 3);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(347, 61);
            this.butSearch.TabIndex = 21;
            this.butSearch.Text = "Найти";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butFiltr
            // 
            this.butFiltr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butFiltr.Enabled = false;
            this.butFiltr.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.butFiltr.Location = new System.Drawing.Point(3, 137);
            this.butFiltr.Name = "butFiltr";
            this.butFiltr.Size = new System.Drawing.Size(347, 63);
            this.butFiltr.TabIndex = 22;
            this.butFiltr.Text = "Фильтровать";
            this.butFiltr.UseVisualStyleBackColor = true;
            this.butFiltr.Click += new System.EventHandler(this.butFiltr_Click);
            // 
            // butExport
            // 
            this.butExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butExport.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.butExport.Location = new System.Drawing.Point(3, 70);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(347, 61);
            this.butExport.TabIndex = 23;
            this.butExport.Text = "Экспорт данных";
            this.butExport.UseVisualStyleBackColor = false;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.butSearch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.butExport, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.butFiltr, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(574, 545);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(353, 203);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 750);
            this.panel1.TabIndex = 22;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(145, 572);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(422, 40);
            this.searchBox.TabIndex = 22;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceBox.Location = new System.Drawing.Point(145, 675);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(422, 40);
            this.priceBox.TabIndex = 23;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // radioAsc
            // 
            this.radioAsc.AutoSize = true;
            this.radioAsc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioAsc.Location = new System.Drawing.Point(8, 300);
            this.radioAsc.Name = "radioAsc";
            this.radioAsc.Size = new System.Drawing.Size(231, 37);
            this.radioAsc.TabIndex = 5;
            this.radioAsc.TabStop = true;
            this.radioAsc.Text = "По возрастанию";
            this.radioAsc.UseVisualStyleBackColor = true;
            // 
            // radioDesc
            // 
            this.radioDesc.AutoSize = true;
            this.radioDesc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioDesc.Location = new System.Drawing.Point(8, 366);
            this.radioDesc.Name = "radioDesc";
            this.radioDesc.Size = new System.Drawing.Size(202, 37);
            this.radioDesc.TabIndex = 6;
            this.radioDesc.TabStop = true;
            this.radioDesc.Text = "По убыванию";
            this.radioDesc.UseVisualStyleBackColor = true;
            // 
            // FiltrAndSortTovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 818);
            this.Controls.Add(this.panel1);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton butSort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butFiltr;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioAsc;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.RadioButton radioDesc;
    }
}