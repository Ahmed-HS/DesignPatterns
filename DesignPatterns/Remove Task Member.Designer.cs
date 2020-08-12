namespace DesignPatterns
{
    partial class RemoveTaskMemberForm
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
            this.RemoveMemberCmbBox = new System.Windows.Forms.ComboBox();
            this.RemoveMemberLbl = new System.Windows.Forms.Label();
            this.RemoveMemberBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskIDLbl
            // 
            this.TaskIDLbl.AutoSize = true;
            this.TaskIDLbl.Location = new System.Drawing.Point(61, 51);
            this.TaskIDLbl.Name = "TaskIDLbl";
            this.TaskIDLbl.Size = new System.Drawing.Size(56, 17);
            this.TaskIDLbl.TabIndex = 0;
            this.TaskIDLbl.Text = "Task ID";
            // 
            // TaskIDCmbBox
            // 
            this.TaskIDCmbBox.FormattingEnabled = true;
            this.TaskIDCmbBox.Location = new System.Drawing.Point(64, 108);
            this.TaskIDCmbBox.Name = "TaskIDCmbBox";
            this.TaskIDCmbBox.Size = new System.Drawing.Size(214, 24);
            this.TaskIDCmbBox.TabIndex = 1;
            this.TaskIDCmbBox.SelectedIndexChanged += new System.EventHandler(this.TaskIDCmbBox_SelectedIndexChanged);
            // 
            // RemoveMemberCmbBox
            // 
            this.RemoveMemberCmbBox.FormattingEnabled = true;
            this.RemoveMemberCmbBox.Location = new System.Drawing.Point(64, 215);
            this.RemoveMemberCmbBox.Name = "RemoveMemberCmbBox";
            this.RemoveMemberCmbBox.Size = new System.Drawing.Size(214, 24);
            this.RemoveMemberCmbBox.TabIndex = 2;
            // 
            // RemoveMemberLbl
            // 
            this.RemoveMemberLbl.AutoSize = true;
            this.RemoveMemberLbl.Location = new System.Drawing.Point(61, 158);
            this.RemoveMemberLbl.Name = "RemoveMemberLbl";
            this.RemoveMemberLbl.Size = new System.Drawing.Size(115, 17);
            this.RemoveMemberLbl.TabIndex = 3;
            this.RemoveMemberLbl.Text = "Remove Member";
            // 
            // RemoveMemberBtn
            // 
            this.RemoveMemberBtn.Location = new System.Drawing.Point(117, 348);
            this.RemoveMemberBtn.Name = "RemoveMemberBtn";
            this.RemoveMemberBtn.Size = new System.Drawing.Size(126, 33);
            this.RemoveMemberBtn.TabIndex = 4;
            this.RemoveMemberBtn.Text = "Remove Member";
            this.RemoveMemberBtn.UseVisualStyleBackColor = true;
            this.RemoveMemberBtn.Click += new System.EventHandler(this.RemoveMemberBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(117, 309);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(126, 33);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RemoveTaskMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 393);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RemoveMemberBtn);
            this.Controls.Add(this.RemoveMemberLbl);
            this.Controls.Add(this.RemoveMemberCmbBox);
            this.Controls.Add(this.TaskIDCmbBox);
            this.Controls.Add(this.TaskIDLbl);
            this.Name = "RemoveTaskMemberForm";
            this.Text = "Remove Task Member";
            this.Load += new System.EventHandler(this.RemoveTaskMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskIDLbl;
        private System.Windows.Forms.ComboBox TaskIDCmbBox;
        private System.Windows.Forms.ComboBox RemoveMemberCmbBox;
        private System.Windows.Forms.Label RemoveMemberLbl;
        private System.Windows.Forms.Button RemoveMemberBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}