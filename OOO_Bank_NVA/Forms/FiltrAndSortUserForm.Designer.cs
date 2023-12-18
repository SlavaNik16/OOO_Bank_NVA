namespace OOO_Bank_NVA.Forms
{
    partial class FiltrAndSortUsersForm
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
            this.radioDesc = new System.Windows.Forms.RadioButton();
            this.radioAsc = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butSort = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.butViewAll = new MaterialSkin.Controls.MaterialButton();
            this.butOk = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butSearch = new System.Windows.Forms.Button();
            this.butFiltr = new System.Windows.Forms.Button();
            this.butExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSort
            // 
            this.listBoxSort.FormattingEnabled = true;
            this.listBoxSort.ItemHeight = 27;
            this.listBoxSort.Items.AddRange(new object[] {
            "Телефон",
            "Фамилия",
            "Имя",
            "Пол"});
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
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Location = new System.Drawing.Point(930, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 498);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioDesc
            // 
            this.radioDesc.AutoSize = true;
            this.radioDesc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioDesc.Location = new System.Drawing.Point(7, 371);
            this.radioDesc.Name = "radioDesc";
            this.radioDesc.Size = new System.Drawing.Size(202, 37);
            this.radioDesc.TabIndex = 8;
            this.radioDesc.Text = "По убыванию";
            this.radioDesc.UseVisualStyleBackColor = true;
            // 
            // radioAsc
            // 
            this.radioAsc.AutoSize = true;
            this.radioAsc.Checked = true;
            this.radioAsc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioAsc.Location = new System.Drawing.Point(7, 305);
            this.radioAsc.Name = "radioAsc";
            this.radioAsc.Size = new System.Drawing.Size(231, 37);
            this.radioAsc.TabIndex = 7;
            this.radioAsc.TabStop = true;
            this.radioAsc.Text = "По возрастанию";
            this.radioAsc.UseVisualStyleBackColor = true;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridUsers);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1288, 505);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeColumns = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPhone,
            this.ColumnSurname,
            this.ColumnName,
            this.ColumnGender,
            this.ColumnCardName,
            this.ColumnStatus,
            this.ColumnRole,
            this.ColumnId});
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersWidth = 62;
            this.dataGridUsers.RowTemplate.Height = 28;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(921, 498);
            this.dataGridUsers.TabIndex = 1;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPhone.DataPropertyName = "Phone";
            this.ColumnPhone.HeaderText = "Телефон";
            this.ColumnPhone.MinimumWidth = 8;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSurname.DataPropertyName = "Surname";
            this.ColumnSurname.HeaderText = "Фамилия";
            this.ColumnSurname.MinimumWidth = 8;
            this.ColumnSurname.Name = "ColumnSurname";
            this.ColumnSurname.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnGender
            // 
            this.ColumnGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnGender.DataPropertyName = "Gender";
            this.ColumnGender.HeaderText = "Пол";
            this.ColumnGender.MinimumWidth = 8;
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.ReadOnly = true;
            this.ColumnGender.Width = 72;
            // 
            // ColumnCardName
            // 
            this.ColumnCardName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCardName.DataPropertyName = "CardName";
            this.ColumnCardName.HeaderText = "Номер карты";
            this.ColumnCardName.MinimumWidth = 8;
            this.ColumnCardName.Name = "ColumnCardName";
            this.ColumnCardName.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnStatus.DataPropertyName = "Status";
            this.ColumnStatus.HeaderText = "Статус";
            this.ColumnStatus.MinimumWidth = 8;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 91;
            // 
            // ColumnRole
            // 
            this.ColumnRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnRole.DataPropertyName = "Role";
            this.ColumnRole.HeaderText = "Права";
            this.ColumnRole.MinimumWidth = 8;
            this.ColumnRole.Name = "ColumnRole";
            this.ColumnRole.ReadOnly = true;
            this.ColumnRole.Width = 86;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "№";
            this.ColumnId.MinimumWidth = 8;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(20, 536);
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
            this.butOk.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.butViewAll, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butOk, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(936, 511);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(577, 506);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(353, 203);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxStatus, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxRole, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(23, 610);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(538, 89);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(274, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 43);
            this.label3.TabIndex = 26;
            this.label3.Text = "Статус";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 43);
            this.label1.TabIndex = 24;
            this.label1.Text = "Роль";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(273, 46);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(262, 41);
            this.comboBoxStatus.TabIndex = 25;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(3, 46);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(264, 41);
            this.comboBoxRole.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 716);
            this.panel1.TabIndex = 23;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(136, 533);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(422, 40);
            this.searchBox.TabIndex = 23;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // FiltrAndSortUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 818);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 818);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 818);
            this.Name = "FiltrAndSortUsersForm";
            this.Padding = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка и фильтрация данных товара";
            this.Load += new System.EventHandler(this.FiltrAndSortUsersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butFiltr;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioDesc;
        private System.Windows.Forms.RadioButton radioAsc;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}