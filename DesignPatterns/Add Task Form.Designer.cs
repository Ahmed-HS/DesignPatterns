namespace DesignPatterns
{
    partial class AddTaskForm
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
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ProjectIDLbl = new System.Windows.Forms.Label();
            this.ToDateLbl = new System.Windows.Forms.Label();
            this.FromDateLbl = new System.Windows.Forms.Label();
            this.StatusCmbBox = new System.Windows.Forms.ComboBox();
            this.ProjectIDCmbBox = new System.Windows.Forms.ComboBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(104, 110);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(79, 17);
            this.DescriptionLbl.TabIndex = 0;
            this.DescriptionLbl.Text = "Description";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(554, 253);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(48, 17);
            this.StatusLbl.TabIndex = 1;
            this.StatusLbl.Text = "Status";
            // 
            // ProjectIDLbl
            // 
            this.ProjectIDLbl.AutoSize = true;
            this.ProjectIDLbl.Location = new System.Drawing.Point(157, 253);
            this.ProjectIDLbl.Name = "ProjectIDLbl";
            this.ProjectIDLbl.Size = new System.Drawing.Size(69, 17);
            this.ProjectIDLbl.TabIndex = 2;
            this.ProjectIDLbl.Text = "Project ID";
            // 
            // ToDateLbl
            // 
            this.ToDateLbl.AutoSize = true;
            this.ToDateLbl.Location = new System.Drawing.Point(647, 110);
            this.ToDateLbl.Name = "ToDateLbl";
            this.ToDateLbl.Size = new System.Drawing.Size(25, 17);
            this.ToDateLbl.TabIndex = 3;
            this.ToDateLbl.Text = "To";
            // 
            // FromDateLbl
            // 
            this.FromDateLbl.AutoSize = true;
            this.FromDateLbl.Location = new System.Drawing.Point(383, 110);
            this.FromDateLbl.Name = "FromDateLbl";
            this.FromDateLbl.Size = new System.Drawing.Size(40, 17);
            this.FromDateLbl.TabIndex = 4;
            this.FromDateLbl.Text = "From";
            // 
            // StatusCmbBox
            // 
            this.StatusCmbBox.FormattingEnabled = true;
            this.StatusCmbBox.Location = new System.Drawing.Point(481, 293);
            this.StatusCmbBox.Name = "StatusCmbBox";
            this.StatusCmbBox.Size = new System.Drawing.Size(200, 24);
            this.StatusCmbBox.TabIndex = 5;
            // 
            // ProjectIDCmbBox
            // 
            this.ProjectIDCmbBox.FormattingEnabled = true;
            this.ProjectIDCmbBox.Location = new System.Drawing.Point(94, 293);
            this.ProjectIDCmbBox.Name = "ProjectIDCmbBox";
            this.ProjectIDCmbBox.Size = new System.Drawing.Size(200, 24);
            this.ProjectIDCmbBox.TabIndex = 6;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(45, 157);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(200, 22);
            this.DescriptionTxtBox.TabIndex = 7;
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Location = new System.Drawing.Point(298, 155);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(200, 22);
            this.FromDatePicker.TabIndex = 8;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Location = new System.Drawing.Point(557, 155);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(200, 22);
            this.ToDatePicker.TabIndex = 9;
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Location = new System.Drawing.Point(614, 390);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(143, 37);
            this.AddTaskBtn.TabIndex = 10;
            this.AddTaskBtn.Text = "Add Task";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTaskBtn);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.ProjectIDCmbBox);
            this.Controls.Add(this.StatusCmbBox);
            this.Controls.Add(this.FromDateLbl);
            this.Controls.Add(this.ToDateLbl);
            this.Controls.Add(this.ProjectIDLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Name = "AddTaskForm";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label ProjectIDLbl;
        private System.Windows.Forms.Label ToDateLbl;
        private System.Windows.Forms.Label FromDateLbl;
        private System.Windows.Forms.ComboBox StatusCmbBox;
        private System.Windows.Forms.ComboBox ProjectIDCmbBox;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.Button AddTaskBtn;
    }
}