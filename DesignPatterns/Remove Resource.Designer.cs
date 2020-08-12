namespace DesignPatterns
{
    partial class RemoveResourceForm
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
            this.ResourceIDLbl = new System.Windows.Forms.Label();
            this.ResourceCmbBox = new System.Windows.Forms.ComboBox();
            this.RemoveResourceBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResourceIDLbl
            // 
            this.ResourceIDLbl.AutoSize = true;
            this.ResourceIDLbl.Location = new System.Drawing.Point(32, 53);
            this.ResourceIDLbl.Name = "ResourceIDLbl";
            this.ResourceIDLbl.Size = new System.Drawing.Size(86, 17);
            this.ResourceIDLbl.TabIndex = 0;
            this.ResourceIDLbl.Text = "Resource ID";
            // 
            // ResourceCmbBox
            // 
            this.ResourceCmbBox.FormattingEnabled = true;
            this.ResourceCmbBox.Location = new System.Drawing.Point(35, 108);
            this.ResourceCmbBox.Name = "ResourceCmbBox";
            this.ResourceCmbBox.Size = new System.Drawing.Size(207, 24);
            this.ResourceCmbBox.TabIndex = 1;
            // 
            // RemoveResourceBtn
            // 
            this.RemoveResourceBtn.Location = new System.Drawing.Point(66, 272);
            this.RemoveResourceBtn.Name = "RemoveResourceBtn";
            this.RemoveResourceBtn.Size = new System.Drawing.Size(133, 31);
            this.RemoveResourceBtn.TabIndex = 4;
            this.RemoveResourceBtn.Text = "Remove Resource";
            this.RemoveResourceBtn.UseVisualStyleBackColor = true;
            this.RemoveResourceBtn.Click += new System.EventHandler(this.RemoveResourceBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(67, 235);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(132, 31);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RemoveResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 315);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RemoveResourceBtn);
            this.Controls.Add(this.ResourceCmbBox);
            this.Controls.Add(this.ResourceIDLbl);
            this.Name = "RemoveResourceForm";
            this.Text = "Remove Resource";
            this.Load += new System.EventHandler(this.RemoveResourceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResourceIDLbl;
        private System.Windows.Forms.ComboBox ResourceCmbBox;
        private System.Windows.Forms.Button RemoveResourceBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}