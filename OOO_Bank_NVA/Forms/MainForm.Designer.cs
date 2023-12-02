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
            this.butView = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTovars = new System.Windows.Forms.TabPage();
            this.tabBasket = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.butSend = new System.Windows.Forms.Button();
            this.butTranslate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialTabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabUsers);
            this.materialTabControl1.Controls.Add(this.tabTovars);
            this.materialTabControl1.Controls.Add(this.tabBasket);
            this.materialTabControl1.Controls.Add(this.tabSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1500, 741);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tableLayoutPanel1);
            this.tabUsers.Controls.Add(this.dataGridUsers);
            this.tabUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabUsers.ImageKey = "User.png";
            this.tabUsers.Location = new System.Drawing.Point(4, 39);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1492, 698);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Пользователи";
            this.tabUsers.ToolTipText = "Привет";
            this.tabUsers.UseVisualStyleBackColor = true;
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
            this.butView.Click += new System.EventHandler(this.butView_Click);
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
            // tabTovars
            // 
            this.tabTovars.ImageKey = "Tovar.png";
            this.tabTovars.Location = new System.Drawing.Point(4, 39);
            this.tabTovars.Name = "tabTovars";
            this.tabTovars.Padding = new System.Windows.Forms.Padding(3);
            this.tabTovars.Size = new System.Drawing.Size(1506, 856);
            this.tabTovars.TabIndex = 1;
            this.tabTovars.Text = "Товары";
            this.tabTovars.UseVisualStyleBackColor = true;
            // 
            // tabBasket
            // 
            this.tabBasket.ImageKey = "Basket.png";
            this.tabBasket.Location = new System.Drawing.Point(4, 39);
            this.tabBasket.Name = "tabBasket";
            this.tabBasket.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasket.Size = new System.Drawing.Size(1506, 856);
            this.tabBasket.TabIndex = 3;
            this.tabBasket.Text = "Корзина";
            this.tabBasket.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.ImageKey = "Settings.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1506, 856);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Настройки";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User.png");
            this.imageList1.Images.SetKeyName(1, "Tovar.png");
            this.imageList1.Images.SetKeyName(2, "Basket.png");
            this.imageList1.Images.SetKeyName(3, "Settings.png");
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 808);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.materialTabControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
    }
}