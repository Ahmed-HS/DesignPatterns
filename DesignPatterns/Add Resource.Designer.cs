namespace DesignPatterns
{
    partial class AddResourceForm
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
            this.ResourceNameLbl = new System.Windows.Forms.Label();
            this.ResourceNameTxtBox = new System.Windows.Forms.TextBox();
            this.OptionalGroupBox = new System.Windows.Forms.GroupBox();
            this.TaskIDCmbBox = new System.Windows.Forms.ComboBox();
            this.TaskIDLbl = new System.Windows.Forms.Label();
            this.AddResourceBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OptionalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResourceNameLbl
            // 
            this.ResourceNameLbl.AutoSize = true;
            this.ResourceNameLbl.Location = new System.Drawing.Point(139, 35);
            this.ResourceNameLbl.Name = "ResourceNameLbl";
            this.ResourceNameLbl.Size = new System.Drawing.Size(110, 17);
            this.ResourceNameLbl.TabIndex = 0;
            this.ResourceNameLbl.Text = "Resource Name";
            // 
            // ResourceNameTxtBox
            // 
            this.ResourceNameTxtBox.Location = new System.Drawing.Point(98, 78);
            this.ResourceNameTxtBox.Name = "ResourceNameTxtBox";
            this.ResourceNameTxtBox.Size = new System.Drawing.Size(192, 22);
            this.ResourceNameTxtBox.TabIndex = 1;
            // 
            // OptionalGroupBox
            // 
            this.OptionalGroupBox.Controls.Add(this.TaskIDCmbBox);
            this.OptionalGroupBox.Controls.Add(this.TaskIDLbl);
            this.OptionalGroupBox.Location = new System.Drawing.Point(32, 139);
            this.OptionalGroupBox.Name = "OptionalGroupBox";
            this.OptionalGroupBox.Size = new System.Drawing.Size(322, 165);
            this.OptionalGroupBox.TabIndex = 2;
            this.OptionalGroupBox.TabStop = false;
            this.OptionalGroupBox.Text = "Optional";
            // 
            // TaskIDCmbBox
            // 
            this.TaskIDCmbBox.FormattingEnabled = true;
            this.TaskIDCmbBox.Location = new System.Drawing.Point(66, 89);
            this.TaskIDCmbBox.Name = "TaskIDCmbBox";
            this.TaskIDCmbBox.Size = new System.Drawing.Size(192, 24);
            this.TaskIDCmbBox.TabIndex = 1;
            // 
            // TaskIDLbl
            // 
            this.TaskIDLbl.AutoSize = true;
            this.TaskIDLbl.Location = new System.Drawing.Point(132, 43);
            this.TaskIDLbl.Name = "TaskIDLbl";
            this.TaskIDLbl.Size = new System.Drawing.Size(52, 17);
            this.TaskIDLbl.TabIndex = 0;
            this.TaskIDLbl.Text = "TaskID";
            // 
            // AddResourceBtn
            // 
            this.AddResourceBtn.Location = new System.Drawing.Point(128, 407);
            this.AddResourceBtn.Name = "AddResourceBtn";
            this.AddResourceBtn.Size = new System.Drawing.Size(132, 31);
            this.AddResourceBtn.TabIndex = 3;
            this.AddResourceBtn.Text = "Add Resource";
            this.AddResourceBtn.UseVisualStyleBackColor = true;
            this.AddResourceBtn.Click += new System.EventHandler(this.AddResourceBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(128, 370);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(132, 31);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddResourceBtn);
            this.Controls.Add(this.OptionalGroupBox);
            this.Controls.Add(this.ResourceNameTxtBox);
            this.Controls.Add(this.ResourceNameLbl);
            this.Name = "AddResourceForm";
            this.Text = "Add Resource";
            this.Load += new System.EventHandler(this.AddResourceForm_Load);
            this.OptionalGroupBox.ResumeLayout(false);
            this.OptionalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResourceNameLbl;
        private System.Windows.Forms.TextBox ResourceNameTxtBox;
        private System.Windows.Forms.GroupBox OptionalGroupBox;
        private System.Windows.Forms.ComboBox TaskIDCmbBox;
        private System.Windows.Forms.Label TaskIDLbl;
        private System.Windows.Forms.Button AddResourceBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}