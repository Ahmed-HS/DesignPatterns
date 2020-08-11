namespace DesignPatterns
{
    partial class Add_Department
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.add_dept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(53, 12);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // add_dept
            // 
            this.add_dept.Location = new System.Drawing.Point(126, 42);
            this.add_dept.Name = "add_dept";
            this.add_dept.Size = new System.Drawing.Size(113, 23);
            this.add_dept.TabIndex = 2;
            this.add_dept.Text = "Add Department";
            this.add_dept.UseVisualStyleBackColor = true;
            this.add_dept.Click += new System.EventHandler(this.Add_dept_Click);
            // 
            // Add_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 77);
            this.Controls.Add(this.add_dept);
            this.Controls.Add(this.name);
            this.Controls.Add(this.name_textbox);
            this.Name = "Add_Department";
            this.Text = "Add_Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button add_dept;
    }
}