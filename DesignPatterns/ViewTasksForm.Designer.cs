namespace DesignPatterns
{
    partial class ViewTasksForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.taskTitle,
            this.fromDate,
            this.toDate,
            this.projectName,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "TaskID";
            this.TaskID.Name = "TaskID";
            // 
            // taskTitle
            // 
            this.taskTitle.HeaderText = "taskTitle";
            this.taskTitle.Name = "taskTitle";
            // 
            // fromDate
            // 
            this.fromDate.HeaderText = "From date";
            this.fromDate.Name = "fromDate";
            // 
            // toDate
            // 
            this.toDate.HeaderText = "To Date";
            this.toDate.Name = "toDate";
            // 
            // projectName
            // 
            this.projectName.HeaderText = "Project name";
            this.projectName.Name = "projectName";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // ViewTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewTasksForm";
            this.Text = "ViewTasks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}