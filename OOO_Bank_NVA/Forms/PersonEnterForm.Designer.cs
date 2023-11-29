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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butEnter = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 206);
            this.panel1.TabIndex = 0;
            // 
            // butEnter
            // 
            this.butEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butEnter.Location = new System.Drawing.Point(45, 325);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(166, 53);
            this.butEnter.TabIndex = 1;
            this.butEnter.Text = "Подтвердить";
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
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butEnter);
            this.Controls.Add(this.panel1);
            this.Name = "PersonEnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonEnterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Button butCancel;
    }
}