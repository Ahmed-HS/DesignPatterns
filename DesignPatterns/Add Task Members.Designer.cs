namespace DesignPatterns
{
    partial class AddTaskMembersForm
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
            this.AddMembersLbl = new System.Windows.Forms.Label();
            this.MemberIDLbl = new System.Windows.Forms.Label();
            this.MemberIDCmbBox = new System.Windows.Forms.ComboBox();
            this.TaskIDCmbBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveMemberLbl = new System.Windows.Forms.Label();
            this.RemoveMemberCmbBox = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddMembersTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TaskIDLbl
            // 
            this.TaskIDLbl.AutoSize = true;
            this.TaskIDLbl.Location = new System.Drawing.Point(58, 62);
            this.TaskIDLbl.Name = "TaskIDLbl";
            this.TaskIDLbl.Size = new System.Drawing.Size(56, 17);
            this.TaskIDLbl.TabIndex = 0;
            this.TaskIDLbl.Text = "Task ID";
            // 
            // AddMembersLbl
            // 
            this.AddMembersLbl.AutoSize = true;
            this.AddMembersLbl.Location = new System.Drawing.Point(58, 196);
            this.AddMembersLbl.Name = "AddMembersLbl";
            this.AddMembersLbl.Size = new System.Drawing.Size(163, 17);
            this.AddMembersLbl.TabIndex = 1;
            this.AddMembersLbl.Text = "Member ID To Be Added";
            // 
            // MemberIDLbl
            // 
            this.MemberIDLbl.AutoSize = true;
            this.MemberIDLbl.Location = new System.Drawing.Point(371, 62);
            this.MemberIDLbl.Name = "MemberIDLbl";
            this.MemberIDLbl.Size = new System.Drawing.Size(83, 17);
            this.MemberIDLbl.TabIndex = 2;
            this.MemberIDLbl.Text = "Member IDs";
            // 
            // MemberIDCmbBox
            // 
            this.MemberIDCmbBox.FormattingEnabled = true;
            this.MemberIDCmbBox.Location = new System.Drawing.Point(374, 106);
            this.MemberIDCmbBox.Name = "MemberIDCmbBox";
            this.MemberIDCmbBox.Size = new System.Drawing.Size(194, 24);
            this.MemberIDCmbBox.TabIndex = 3;
            this.MemberIDCmbBox.SelectedIndexChanged += new System.EventHandler(this.MemberIDCmbBox_SelectedIndexChanged);
            // 
            // TaskIDCmbBox
            // 
            this.TaskIDCmbBox.FormattingEnabled = true;
            this.TaskIDCmbBox.Location = new System.Drawing.Point(61, 106);
            this.TaskIDCmbBox.Name = "TaskIDCmbBox";
            this.TaskIDCmbBox.Size = new System.Drawing.Size(194, 24);
            this.TaskIDCmbBox.TabIndex = 4;
            this.TaskIDCmbBox.SelectedIndexChanged += new System.EventHandler(this.TaskIDCmbBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(469, 315);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(158, 47);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add Members";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveMemberLbl
            // 
            this.RemoveMemberLbl.AutoSize = true;
            this.RemoveMemberLbl.Location = new System.Drawing.Point(371, 196);
            this.RemoveMemberLbl.Name = "RemoveMemberLbl";
            this.RemoveMemberLbl.Size = new System.Drawing.Size(115, 17);
            this.RemoveMemberLbl.TabIndex = 6;
            this.RemoveMemberLbl.Text = "Remove Member";
            // 
            // RemoveMemberCmbBox
            // 
            this.RemoveMemberCmbBox.FormattingEnabled = true;
            this.RemoveMemberCmbBox.Location = new System.Drawing.Point(374, 240);
            this.RemoveMemberCmbBox.Name = "RemoveMemberCmbBox";
            this.RemoveMemberCmbBox.Size = new System.Drawing.Size(194, 24);
            this.RemoveMemberCmbBox.TabIndex = 7;
            this.RemoveMemberCmbBox.SelectedIndexChanged += new System.EventHandler(this.RemoveMemberCmbBox_SelectedIndexChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(305, 315);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(158, 47);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddMembersTxtBox
            // 
            this.AddMembersTxtBox.Location = new System.Drawing.Point(61, 241);
            this.AddMembersTxtBox.Name = "AddMembersTxtBox";
            this.AddMembersTxtBox.Size = new System.Drawing.Size(194, 22);
            this.AddMembersTxtBox.TabIndex = 10;
            // 
            // AddTaskMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 374);
            this.Controls.Add(this.AddMembersTxtBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RemoveMemberCmbBox);
            this.Controls.Add(this.RemoveMemberLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TaskIDCmbBox);
            this.Controls.Add(this.MemberIDCmbBox);
            this.Controls.Add(this.MemberIDLbl);
            this.Controls.Add(this.AddMembersLbl);
            this.Controls.Add(this.TaskIDLbl);
            this.Name = "AddTaskMembersForm";
            this.Text = "Add Task Member";
            this.Load += new System.EventHandler(this.UpdateMembersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskIDLbl;
        private System.Windows.Forms.Label AddMembersLbl;
        private System.Windows.Forms.Label MemberIDLbl;
        private System.Windows.Forms.ComboBox MemberIDCmbBox;
        private System.Windows.Forms.ComboBox TaskIDCmbBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label RemoveMemberLbl;
        private System.Windows.Forms.ComboBox RemoveMemberCmbBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox AddMembersTxtBox;
    }
}