namespace DesignPatterns
{
    partial class RemoveTaskForm
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
            this.TaskIDLbl = new System.Windows.Forms.Label();
            this.TaskIDCmbBox = new System.Windows.Forms.ComboBox();
            this.RemoveTaskBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskIDLbl
            // 
            this.TaskIDLbl.AutoSize = true;
            this.TaskIDLbl.Location = new System.Drawing.Point(277, 132);
            this.TaskIDLbl.Name = "TaskIDLbl";
            this.TaskIDLbl.Size = new System.Drawing.Size(56, 17);
            this.TaskIDLbl.TabIndex = 0;
            this.TaskIDLbl.Text = "Task ID";
            // 
            // TaskIDCmbBox
            // 
            this.TaskIDCmbBox.FormattingEnabled = true;
            this.TaskIDCmbBox.Location = new System.Drawing.Point(280, 181);
            this.TaskIDCmbBox.Name = "TaskIDCmbBox";
            this.TaskIDCmbBox.Size = new System.Drawing.Size(223, 24);
            this.TaskIDCmbBox.TabIndex = 1;
            // 
            // RemoveTaskBtn
            // 
            this.RemoveTaskBtn.Location = new System.Drawing.Point(675, 409);
            this.RemoveTaskBtn.Name = "RemoveTaskBtn";
            this.RemoveTaskBtn.Size = new System.Drawing.Size(113, 29);
            this.RemoveTaskBtn.TabIndex = 2;
            this.RemoveTaskBtn.Text = "Remove Task";
            this.RemoveTaskBtn.UseVisualStyleBackColor = true;
            this.RemoveTaskBtn.Click += new System.EventHandler(this.RemoveTaskBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(556, 409);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(113, 29);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RemoveTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RemoveTaskBtn);
            this.Controls.Add(this.TaskIDCmbBox);
            this.Controls.Add(this.TaskIDLbl);
            this.Name = "RemoveTaskForm";
            this.Text = "Remove Task";
            this.Load += new System.EventHandler(this.RemoveTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskIDLbl;
        private System.Windows.Forms.ComboBox TaskIDCmbBox;
        private System.Windows.Forms.Button RemoveTaskBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}