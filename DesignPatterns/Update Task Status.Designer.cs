namespace DesignPatterns
{
    partial class UpdateTaskStatus
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
            this.TaskStatusLbl = new System.Windows.Forms.Label();
            this.TaskIDLbl = new System.Windows.Forms.Label();
            this.StatusCmbBox = new System.Windows.Forms.ComboBox();
            this.TaskIDCmbBox = new System.Windows.Forms.ComboBox();
            this.UpdateStatusBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CurrentStatusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskStatusLbl
            // 
            this.TaskStatusLbl.AutoSize = true;
            this.TaskStatusLbl.Location = new System.Drawing.Point(323, 62);
            this.TaskStatusLbl.Name = "TaskStatusLbl";
            this.TaskStatusLbl.Size = new System.Drawing.Size(119, 17);
            this.TaskStatusLbl.TabIndex = 0;
            this.TaskStatusLbl.Text = "Update Status To";
            // 
            // TaskIDLbl
            // 
            this.TaskIDLbl.AutoSize = true;
            this.TaskIDLbl.Location = new System.Drawing.Point(35, 62);
            this.TaskIDLbl.Name = "TaskIDLbl";
            this.TaskIDLbl.Size = new System.Drawing.Size(56, 17);
            this.TaskIDLbl.TabIndex = 1;
            this.TaskIDLbl.Text = "Task ID";
            // 
            // StatusCmbBox
            // 
            this.StatusCmbBox.FormattingEnabled = true;
            this.StatusCmbBox.Location = new System.Drawing.Point(326, 125);
            this.StatusCmbBox.Name = "StatusCmbBox";
            this.StatusCmbBox.Size = new System.Drawing.Size(199, 24);
            this.StatusCmbBox.TabIndex = 2;
            // 
            // TaskIDCmbBox
            // 
            this.TaskIDCmbBox.FormattingEnabled = true;
            this.TaskIDCmbBox.Location = new System.Drawing.Point(38, 125);
            this.TaskIDCmbBox.Name = "TaskIDCmbBox";
            this.TaskIDCmbBox.Size = new System.Drawing.Size(199, 24);
            this.TaskIDCmbBox.TabIndex = 3;
            this.TaskIDCmbBox.SelectedIndexChanged += new System.EventHandler(this.TaskIDCmbBox_SelectedIndexChanged);
            // 
            // UpdateStatusBtn
            // 
            this.UpdateStatusBtn.Location = new System.Drawing.Point(405, 294);
            this.UpdateStatusBtn.Name = "UpdateStatusBtn";
            this.UpdateStatusBtn.Size = new System.Drawing.Size(144, 43);
            this.UpdateStatusBtn.TabIndex = 4;
            this.UpdateStatusBtn.Text = "Update Status";
            this.UpdateStatusBtn.UseVisualStyleBackColor = true;
            this.UpdateStatusBtn.Click += new System.EventHandler(this.UpdateStatusBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(255, 294);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(144, 43);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CurrentStatusLbl
            // 
            this.CurrentStatusLbl.AutoSize = true;
            this.CurrentStatusLbl.Location = new System.Drawing.Point(38, 212);
            this.CurrentStatusLbl.Name = "CurrentStatusLbl";
            this.CurrentStatusLbl.Size = new System.Drawing.Size(103, 17);
            this.CurrentStatusLbl.TabIndex = 6;
            this.CurrentStatusLbl.Text = "Current Status:";
            this.CurrentStatusLbl.Visible = false;
            // 
            // UpdateTaskStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 349);
            this.Controls.Add(this.CurrentStatusLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.UpdateStatusBtn);
            this.Controls.Add(this.TaskIDCmbBox);
            this.Controls.Add(this.StatusCmbBox);
            this.Controls.Add(this.TaskIDLbl);
            this.Controls.Add(this.TaskStatusLbl);
            this.Name = "UpdateTaskStatus";
            this.Text = "Update Task Status";
            this.Load += new System.EventHandler(this.UpdateTaskStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskStatusLbl;
        private System.Windows.Forms.Label TaskIDLbl;
        private System.Windows.Forms.ComboBox StatusCmbBox;
        private System.Windows.Forms.ComboBox TaskIDCmbBox;
        private System.Windows.Forms.Button UpdateStatusBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label CurrentStatusLbl;
    }
}