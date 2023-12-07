namespace OOO_Bank_NVA.Forms
{
    partial class PersonEnterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.butCancel = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.maskPhoneText = new System.Windows.Forms.MaskedTextBox();
            this.butEnter = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Телефон";
            // 
            // butCancel
            // 
            this.butCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butCancel.Depth = 0;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.HighEmphasis = true;
            this.butCancel.Icon = null;
            this.butCancel.Location = new System.Drawing.Point(576, 334);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.butCancel.Name = "butCancel";
            this.butCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butCancel.Size = new System.Drawing.Size(101, 36);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "Отменить";
            this.butCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.butCancel.UseAccentColor = false;
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.maskPhoneText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 206);
            this.panel1.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.AnimateReadOnly = false;
            this.passwordBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordBox.Depth = 0;
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.HideSelection = true;
            this.passwordBox.Hint = "Пароль";
            this.passwordBox.LeadingIcon = null;
            this.passwordBox.Location = new System.Drawing.Point(39, 123);
            this.passwordBox.MaxLength = 20;
            this.passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PrefixSuffixText = null;
            this.passwordBox.ReadOnly = false;
            this.passwordBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(701, 48);
            this.passwordBox.TabIndex = 23;
            this.passwordBox.TabStop = false;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordBox.TrailingIcon = null;
            this.passwordBox.UseSystemPasswordChar = false;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // maskPhoneText
            // 
            this.maskPhoneText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskPhoneText.Location = new System.Drawing.Point(39, 62);
            this.maskPhoneText.Mask = "(000)-000-00-00";
            this.maskPhoneText.Name = "maskPhoneText";
            this.maskPhoneText.Size = new System.Drawing.Size(701, 37);
            this.maskPhoneText.TabIndex = 22;
            this.maskPhoneText.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // butEnter
            // 
            this.butEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEnter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butEnter.Depth = 0;
            this.butEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butEnter.Enabled = false;
            this.butEnter.HighEmphasis = true;
            this.butEnter.Icon = null;
            this.butEnter.Location = new System.Drawing.Point(67, 334);
            this.butEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.butEnter.Name = "butEnter";
            this.butEnter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butEnter.Size = new System.Drawing.Size(129, 36);
            this.butEnter.TabIndex = 6;
            this.butEnter.Text = "Подтвердить";
            this.butEnter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butEnter.UseAccentColor = false;
            this.butEnter.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(558, 325);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(166, 53);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Отменить";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // PersonEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.butEnter);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butEnter);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "PersonEnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton butCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskPhoneText;
        private MaterialSkin.Controls.MaterialButton butEnter;
        private MaterialSkin.Controls.MaterialTextBox2 passwordBox;
    }
}