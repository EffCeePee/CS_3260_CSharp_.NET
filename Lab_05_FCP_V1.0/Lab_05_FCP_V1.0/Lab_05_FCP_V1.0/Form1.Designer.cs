namespace Employee_Form
{
    partial class Form_Employee
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
            this.lbl_empName = new System.Windows.Forms.Label();
            this.txt_empName = new System.Windows.Forms.TextBox();
            this.lbl_empId = new System.Windows.Forms.Label();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.lbl_empType = new System.Windows.Forms.Label();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.txt_info1 = new System.Windows.Forms.TextBox();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.txt_info2 = new System.Windows.Forms.TextBox();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.txt_info3 = new System.Windows.Forms.TextBox();
            this.btn_TestData = new System.Windows.Forms.Button();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tab_pg2 = new System.Windows.Forms.TabControl();
            this.tab_employee = new System.Windows.Forms.TabPage();
            this.dbox_empType = new System.Windows.Forms.ComboBox();
            this.tab_pg2.SuspendLayout();
            this.tab_employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Location = new System.Drawing.Point(6, 14);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(87, 13);
            this.lbl_empName.TabIndex = 0;
            this.lbl_empName.Text = "Employee Name:";
            // 
            // txt_empName
            // 
            this.txt_empName.Location = new System.Drawing.Point(135, 14);
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.Size = new System.Drawing.Size(194, 20);
            this.txt_empName.TabIndex = 1;
            // 
            // lbl_empId
            // 
            this.lbl_empId.AutoSize = true;
            this.lbl_empId.Location = new System.Drawing.Point(6, 40);
            this.lbl_empId.Name = "lbl_empId";
            this.lbl_empId.Size = new System.Drawing.Size(70, 13);
            this.lbl_empId.TabIndex = 0;
            this.lbl_empId.Text = "Employee ID:";
            // 
            // txt_empID
            // 
            this.txt_empID.Location = new System.Drawing.Point(135, 40);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(194, 20);
            this.txt_empID.TabIndex = 2;
            // 
            // lbl_empType
            // 
            this.lbl_empType.AutoSize = true;
            this.lbl_empType.Location = new System.Drawing.Point(6, 66);
            this.lbl_empType.Name = "lbl_empType";
            this.lbl_empType.Size = new System.Drawing.Size(83, 13);
            this.lbl_empType.TabIndex = 0;
            this.lbl_empType.Text = "Employee Type:";
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(6, 92);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(33, 13);
            this.lbl_info1.TabIndex = 0;
            this.lbl_info1.Text = "info1:";
            // 
            // txt_info1
            // 
            this.txt_info1.Location = new System.Drawing.Point(135, 92);
            this.txt_info1.Name = "txt_info1";
            this.txt_info1.Size = new System.Drawing.Size(194, 20);
            this.txt_info1.TabIndex = 4;
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Location = new System.Drawing.Point(6, 118);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(36, 13);
            this.lbl_info2.TabIndex = 0;
            this.lbl_info2.Text = "info 2:";
            // 
            // txt_info2
            // 
            this.txt_info2.Location = new System.Drawing.Point(135, 118);
            this.txt_info2.Name = "txt_info2";
            this.txt_info2.Size = new System.Drawing.Size(194, 20);
            this.txt_info2.TabIndex = 5;
            // 
            // lbl_info3
            // 
            this.lbl_info3.AutoSize = true;
            this.lbl_info3.Location = new System.Drawing.Point(6, 144);
            this.lbl_info3.Name = "lbl_info3";
            this.lbl_info3.Size = new System.Drawing.Size(36, 13);
            this.lbl_info3.TabIndex = 0;
            this.lbl_info3.Text = "info 3:";
            // 
            // txt_info3
            // 
            this.txt_info3.Location = new System.Drawing.Point(135, 144);
            this.txt_info3.Name = "txt_info3";
            this.txt_info3.Size = new System.Drawing.Size(194, 20);
            this.txt_info3.TabIndex = 6;
            // 
            // btn_TestData
            // 
            this.btn_TestData.Location = new System.Drawing.Point(135, 204);
            this.btn_TestData.Name = "btn_TestData";
            this.btn_TestData.Size = new System.Drawing.Size(92, 23);
            this.btn_TestData.TabIndex = 2;
            this.btn_TestData.Text = "Test Data";
            this.btn_TestData.UseVisualStyleBackColor = true;
            this.btn_TestData.Click += new System.EventHandler(this.btn_TestData_Click);
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Location = new System.Drawing.Point(185, 170);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(91, 28);
            this.btn_AddEmployee.TabIndex = 3;
            this.btn_AddEmployee.Text = "Add Employee";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(237, 204);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(92, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tab_pg2
            // 
            this.tab_pg2.Controls.Add(this.tab_employee);
            this.tab_pg2.Location = new System.Drawing.Point(12, 12);
            this.tab_pg2.Name = "tab_pg2";
            this.tab_pg2.SelectedIndex = 0;
            this.tab_pg2.Size = new System.Drawing.Size(398, 278);
            this.tab_pg2.TabIndex = 5;
            // 
            // tab_employee
            // 
            this.tab_employee.Controls.Add(this.dbox_empType);
            this.tab_employee.Controls.Add(this.lbl_info2);
            this.tab_employee.Controls.Add(this.lbl_empName);
            this.tab_employee.Controls.Add(this.txt_empID);
            this.tab_employee.Controls.Add(this.btn_Clear);
            this.tab_employee.Controls.Add(this.lbl_info3);
            this.tab_employee.Controls.Add(this.txt_info3);
            this.tab_employee.Controls.Add(this.txt_info1);
            this.tab_employee.Controls.Add(this.lbl_empType);
            this.tab_employee.Controls.Add(this.btn_AddEmployee);
            this.tab_employee.Controls.Add(this.lbl_empId);
            this.tab_employee.Controls.Add(this.lbl_info1);
            this.tab_employee.Controls.Add(this.txt_info2);
            this.tab_employee.Controls.Add(this.txt_empName);
            this.tab_employee.Controls.Add(this.btn_TestData);
            this.tab_employee.Location = new System.Drawing.Point(4, 22);
            this.tab_employee.Name = "tab_employee";
            this.tab_employee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_employee.Size = new System.Drawing.Size(390, 252);
            this.tab_employee.TabIndex = 0;
            this.tab_employee.Text = "Employee";
            this.tab_employee.UseVisualStyleBackColor = true;
            // 
            // dbox_empType
            // 
            this.dbox_empType.FormattingEnabled = true;
            this.dbox_empType.Items.AddRange(new object[] {
            "Contract",
            "Hourly",
            "Salary",
            "Sales"});
            this.dbox_empType.Location = new System.Drawing.Point(135, 63);
            this.dbox_empType.Name = "dbox_empType";
            this.dbox_empType.Size = new System.Drawing.Size(121, 21);
            this.dbox_empType.TabIndex = 3;
            this.dbox_empType.SelectedIndexChanged += new System.EventHandler(this.dbox_empType_SelectedIndexChanged);
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 308);
            this.Controls.Add(this.tab_pg2);
            this.Name = "Form_Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form_Employee_Load);
            this.tab_pg2.ResumeLayout(false);
            this.tab_employee.ResumeLayout(false);
            this.tab_employee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.TextBox txt_empName;
        private System.Windows.Forms.Label lbl_empId;
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.Label lbl_empType;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.TextBox txt_info1;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.TextBox txt_info2;
        private System.Windows.Forms.Label lbl_info3;
        private System.Windows.Forms.TextBox txt_info3;
        private System.Windows.Forms.Button btn_TestData;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TabControl tab_pg2;
        private System.Windows.Forms.TabPage tab_employee;
        private System.Windows.Forms.ComboBox dbox_empType;
    }
}

