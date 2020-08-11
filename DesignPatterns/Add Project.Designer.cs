namespace DesignPatterns
{
    partial class Add_Project
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
            this.name = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.deptID_textbox = new System.Windows.Forms.TextBox();
            this.dept_id = new System.Windows.Forms.Label();
            this.add_pro = new System.Windows.Forms.Button();
            this.managerID_textbox = new System.Windows.Forms.TextBox();
            this.manager_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(27, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(79, 41);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 3;
            // 
            // deptID_textbox
            // 
            this.deptID_textbox.Location = new System.Drawing.Point(79, 67);
            this.deptID_textbox.Name = "deptID_textbox";
            this.deptID_textbox.Size = new System.Drawing.Size(100, 20);
            this.deptID_textbox.TabIndex = 4;
            // 
            // dept_id
            // 
            this.dept_id.AutoSize = true;
            this.dept_id.Location = new System.Drawing.Point(27, 70);
            this.dept_id.Name = "dept_id";
            this.dept_id.Size = new System.Drawing.Size(42, 13);
            this.dept_id.TabIndex = 5;
            this.dept_id.Text = "Dept Id";
            // 
            // add_pro
            // 
            this.add_pro.Location = new System.Drawing.Point(216, 121);
            this.add_pro.Name = "add_pro";
            this.add_pro.Size = new System.Drawing.Size(75, 23);
            this.add_pro.TabIndex = 6;
            this.add_pro.Text = "Add Project";
            this.add_pro.UseVisualStyleBackColor = true;
            this.add_pro.Click += new System.EventHandler(this.Add_pro_Click);
            // 
            // managerID_textbox
            // 
            this.managerID_textbox.Location = new System.Drawing.Point(79, 93);
            this.managerID_textbox.Name = "managerID_textbox";
            this.managerID_textbox.Size = new System.Drawing.Size(100, 20);
            this.managerID_textbox.TabIndex = 7;
            // 
            // manager_id
            // 
            this.manager_id.AutoSize = true;
            this.manager_id.Location = new System.Drawing.Point(12, 96);
            this.manager_id.Name = "manager_id";
            this.manager_id.Size = new System.Drawing.Size(61, 13);
            this.manager_id.TabIndex = 8;
            this.manager_id.Text = "Manager Id";
            this.manager_id.Click += new System.EventHandler(this.Manager_id_Click);
            // 
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 156);
            this.Controls.Add(this.manager_id);
            this.Controls.Add(this.managerID_textbox);
            this.Controls.Add(this.add_pro);
            this.Controls.Add(this.dept_id);
            this.Controls.Add(this.deptID_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.name);
            this.Name = "Add_Project";
            this.Text = "Add_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox deptID_textbox;
        private System.Windows.Forms.Label dept_id;
        private System.Windows.Forms.Button add_pro;
        private System.Windows.Forms.TextBox managerID_textbox;
        private System.Windows.Forms.Label manager_id;
    }
}