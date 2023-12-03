namespace OOO_Bank_NVA.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butView = new System.Windows.Forms.Button();
            this.butTranslate = new System.Windows.Forms.Button();
            this.butSend = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDataGridUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.butStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.butStripSend = new System.Windows.Forms.ToolStripMenuItem();
            this.butStripTranslate = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTovars = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butEdit = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridTovar = new System.Windows.Forms.DataGridView();
            this.panelInfoTovar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.pictureBoxTovar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.butTovarView = new System.Windows.Forms.Button();
            this.tabBasket = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.butSortWithFiltr = new System.Windows.Forms.Button();
            this.ColumnTitile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.contextMenuStripDataGridUsers.SuspendLayout();
            this.tabTovars.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTovar)).BeginInit();
            this.panelInfoTovar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabUsers);
            this.materialTabControl1.Controls.Add(this.tabTovars);
            this.materialTabControl1.Controls.Add(this.tabBasket);
            this.materialTabControl1.Controls.Add(this.tabSettings);
            this.materialTabControl1.Controls.Add(this.tabProfile);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1500, 707);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tableLayoutPanel1);
            this.tabUsers.Controls.Add(this.dataGridUsers);
            this.tabUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabUsers.ImageKey = "Users.png";
            this.tabUsers.Location = new System.Drawing.Point(4, 39);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1492, 698);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Пользователи";
            this.tabUsers.ToolTipText = "Привет";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.butView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.butTranslate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.butSend, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 576);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1486, 89);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // butView
            // 
            this.butView.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.butView.Location = new System.Drawing.Point(3, 3);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(489, 83);
            this.butView.TabIndex = 2;
            this.butView.Text = "Просмотреть профиль";
            this.butView.UseVisualStyleBackColor = true;
            // 
            // butTranslate
            // 
            this.butTranslate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.butTranslate.Location = new System.Drawing.Point(993, 3);
            this.butTranslate.Name = "butTranslate";
            this.butTranslate.Size = new System.Drawing.Size(490, 83);
            this.butTranslate.TabIndex = 4;
            this.butTranslate.Text = "Передать деньги";
            this.butTranslate.UseVisualStyleBackColor = true;
            // 
            // butSend
            // 
            this.butSend.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.butSend.Location = new System.Drawing.Point(498, 3);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(489, 83);
            this.butSend.TabIndex = 3;
            this.butSend.Text = "Отправить сообщение";
            this.butSend.UseVisualStyleBackColor = true;
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
            this.ColumnRole});
            this.dataGridUsers.ContextMenuStrip = this.contextMenuStripDataGridUsers;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersWidth = 62;
            this.dataGridUsers.RowTemplate.Height = 28;
            this.dataGridUsers.Size = new System.Drawing.Size(1486, 573);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.SelectionChanged += new System.EventHandler(this.dataGridUsers_SelectionChanged);
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
            this.ColumnGender.Width = 94;
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
            this.ColumnStatus.Width = 132;
            // 
            // ColumnRole
            // 
            this.ColumnRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnRole.DataPropertyName = "Role";
            this.ColumnRole.HeaderText = "Права";
            this.ColumnRole.MinimumWidth = 8;
            this.ColumnRole.Name = "ColumnRole";
            this.ColumnRole.ReadOnly = true;
            this.ColumnRole.Width = 124;
            // 
            // contextMenuStripDataGridUsers
            // 
            this.contextMenuStripDataGridUsers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripDataGridUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butStripView,
            this.butStripSend,
            this.butStripTranslate});
            this.contextMenuStripDataGridUsers.Name = "contextMenuStripDataGridUsers";
            this.contextMenuStripDataGridUsers.Size = new System.Drawing.Size(272, 100);
            // 
            // butStripView
            // 
            this.butStripView.Name = "butStripView";
            this.butStripView.Size = new System.Drawing.Size(271, 32);
            this.butStripView.Text = "Просмотреть профиль";
            // 
            // butStripSend
            // 
            this.butStripSend.Name = "butStripSend";
            this.butStripSend.Size = new System.Drawing.Size(271, 32);
            this.butStripSend.Text = "Отправить сообщение";
            // 
            // butStripTranslate
            // 
            this.butStripTranslate.Name = "butStripTranslate";
            this.butStripTranslate.Size = new System.Drawing.Size(271, 32);
            this.butStripTranslate.Text = "Передать деньги";
            // 
            // tabTovars
            // 
            this.tabTovars.Controls.Add(this.tableLayoutPanel4);
            this.tabTovars.Controls.Add(this.tableLayoutPanel2);
            this.tabTovars.Controls.Add(this.panel2);
            this.tabTovars.Controls.Add(this.panelInfoTovar);
            this.tabTovars.ImageKey = "Tovar.png";
            this.tabTovars.Location = new System.Drawing.Point(4, 39);
            this.tabTovars.Name = "tabTovars";
            this.tabTovars.Padding = new System.Windows.Forms.Padding(3);
            this.tabTovars.Size = new System.Drawing.Size(1492, 664);
            this.tabTovars.TabIndex = 1;
            this.tabTovars.Text = "Товары";
            this.tabTovars.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30907F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.18544F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.40578F));
            this.tableLayoutPanel2.Controls.Add(this.butEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.butAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butDelete, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 497);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1003, 86);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // butEdit
            // 
            this.butEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butEdit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEdit.Location = new System.Drawing.Point(307, 3);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(377, 80);
            this.butEdit.TabIndex = 1;
            this.butEdit.Text = "Изменить";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAdd.Location = new System.Drawing.Point(3, 3);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(298, 80);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butDelete.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDelete.Location = new System.Drawing.Point(690, 3);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(310, 80);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridTovar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 494);
            this.panel2.TabIndex = 2;
            // 
            // dataGridTovar
            // 
            this.dataGridTovar.AllowUserToAddRows = false;
            this.dataGridTovar.AllowUserToDeleteRows = false;
            this.dataGridTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTovar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitile,
            this.ColumnPrice,
            this.ColumnMaxCount,
            this.ColumnDesc,
            this.ColumnPhoto,
            this.ColumnId});
            this.dataGridTovar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTovar.Location = new System.Drawing.Point(0, 0);
            this.dataGridTovar.Name = "dataGridTovar";
            this.dataGridTovar.ReadOnly = true;
            this.dataGridTovar.RowHeadersWidth = 62;
            this.dataGridTovar.RowTemplate.Height = 28;
            this.dataGridTovar.Size = new System.Drawing.Size(1003, 494);
            this.dataGridTovar.TabIndex = 0;
            this.dataGridTovar.SelectionChanged += new System.EventHandler(this.dataGridTovar_SelectionChanged);
            // 
            // panelInfoTovar
            // 
            this.panelInfoTovar.Controls.Add(this.label1);
            this.panelInfoTovar.Controls.Add(this.textBoxDesc);
            this.panelInfoTovar.Controls.Add(this.pictureBoxTovar);
            this.panelInfoTovar.Controls.Add(this.tableLayoutPanel3);
            this.panelInfoTovar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfoTovar.Location = new System.Drawing.Point(1006, 3);
            this.panelInfoTovar.Name = "panelInfoTovar";
            this.panelInfoTovar.Size = new System.Drawing.Size(483, 658);
            this.panelInfoTovar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Описание";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(17, 236);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.ReadOnly = true;
            this.textBoxDesc.Size = new System.Drawing.Size(450, 246);
            this.textBoxDesc.TabIndex = 3;
            this.textBoxDesc.Text = "Пример: ыуадываывжаолыущзаолыузаузыщалзуыоазылзщаылозазыщаолзщы";
            // 
            // pictureBoxTovar
            // 
            this.pictureBoxTovar.Location = new System.Drawing.Point(45, 17);
            this.pictureBoxTovar.Name = "pictureBoxTovar";
            this.pictureBoxTovar.Size = new System.Drawing.Size(388, 183);
            this.pictureBoxTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTovar.TabIndex = 1;
            this.pictureBoxTovar.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.butTovarView, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 497);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.2795F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.7205F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(483, 161);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // butTovarView
            // 
            this.butTovarView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butTovarView.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTovarView.Location = new System.Drawing.Point(123, 3);
            this.butTovarView.Name = "butTovarView";
            this.butTovarView.Size = new System.Drawing.Size(235, 83);
            this.butTovarView.TabIndex = 5;
            this.butTovarView.Text = "Посмотреть";
            this.butTovarView.UseVisualStyleBackColor = true;
            this.butTovarView.Click += new System.EventHandler(this.butTovarView_Click);
            // 
            // tabBasket
            // 
            this.tabBasket.ImageKey = "Basket.png";
            this.tabBasket.Location = new System.Drawing.Point(4, 39);
            this.tabBasket.Name = "tabBasket";
            this.tabBasket.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasket.Size = new System.Drawing.Size(1492, 698);
            this.tabBasket.TabIndex = 3;
            this.tabBasket.Text = "Корзина";
            this.tabBasket.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.ImageKey = "Settings.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1492, 698);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Настройки";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.ImageKey = "User.png";
            this.tabProfile.Location = new System.Drawing.Point(4, 39);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(1492, 698);
            this.tabProfile.TabIndex = 4;
            this.tabProfile.Text = "Профиль";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User.png");
            this.imageList1.Images.SetKeyName(1, "Tovar.png");
            this.imageList1.Images.SetKeyName(2, "Basket.png");
            this.imageList1.Images.SetKeyName(3, "Settings.png");
            this.imageList1.Images.SetKeyName(4, "Users.png");
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(3, 771);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(1500, 34);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(231, 27);
            this.toolStripStatusLabel1.Text = "Статус: Пользователь";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.2333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.73579F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.03091F));
            this.tableLayoutPanel4.Controls.Add(this.butSortWithFiltr, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 583);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1003, 82);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // butSortWithFiltr
            // 
            this.butSortWithFiltr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butSortWithFiltr.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSortWithFiltr.Location = new System.Drawing.Point(226, 3);
            this.butSortWithFiltr.Name = "butSortWithFiltr";
            this.butSortWithFiltr.Size = new System.Drawing.Size(543, 76);
            this.butSortWithFiltr.TabIndex = 3;
            this.butSortWithFiltr.Text = "Фильтровать/Сортировать";
            this.butSortWithFiltr.UseVisualStyleBackColor = true;
            this.butSortWithFiltr.Click += new System.EventHandler(this.butSortWithFiltr_Click);
            // 
            // ColumnTitile
            // 
            this.ColumnTitile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTitile.DataPropertyName = "Title";
            this.ColumnTitile.HeaderText = "Название";
            this.ColumnTitile.MinimumWidth = 8;
            this.ColumnTitile.Name = "ColumnTitile";
            this.ColumnTitile.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrice.DataPropertyName = "Price";
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.MinimumWidth = 8;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnMaxCount
            // 
            this.ColumnMaxCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMaxCount.DataPropertyName = "MaxCount";
            this.ColumnMaxCount.HeaderText = "Макс. кол-во";
            this.ColumnMaxCount.MinimumWidth = 8;
            this.ColumnMaxCount.Name = "ColumnMaxCount";
            this.ColumnMaxCount.ReadOnly = true;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.DataPropertyName = "Description";
            this.ColumnDesc.HeaderText = "Описание";
            this.ColumnDesc.MinimumWidth = 8;
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Visible = false;
            this.ColumnDesc.Width = 150;
            // 
            // ColumnPhoto
            // 
            this.ColumnPhoto.DataPropertyName = "Photo";
            this.ColumnPhoto.HeaderText = "Фото";
            this.ColumnPhoto.MinimumWidth = 8;
            this.ColumnPhoto.Name = "ColumnPhoto";
            this.ColumnPhoto.ReadOnly = true;
            this.ColumnPhoto.Visible = false;
            this.ColumnPhoto.Width = 150;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 808);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.statusStrip);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1506, 808);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1506, 808);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOO Банк NVA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.contextMenuStripDataGridUsers.ResumeLayout(false);
            this.tabTovars.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTovar)).EndInit();
            this.panelInfoTovar.ResumeLayout(false);
            this.panelInfoTovar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabTovars;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabBasket;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRole;
        private System.Windows.Forms.Button butTranslate;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridUsers;
        private System.Windows.Forms.ToolStripMenuItem butStripView;
        private System.Windows.Forms.ToolStripMenuItem butStripSend;
        private System.Windows.Forms.ToolStripMenuItem butStripTranslate;
        private System.Windows.Forms.DataGridView dataGridTovar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInfoTovar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBoxTovar;
        private System.Windows.Forms.Button butTovarView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button butSortWithFiltr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaxCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
    }
}