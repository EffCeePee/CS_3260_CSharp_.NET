﻿namespace Employee_Form
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
            this.tab_pg2 = new System.Windows.Forms.TabControl();
            this.tab_employee = new System.Windows.Forms.TabPage();
            this._chBoxOvertime = new System.Windows.Forms.CheckBox();
            this._chBoxEDUBenefits = new System.Windows.Forms.CheckBox();
            this._chBoxCommission = new System.Windows.Forms.CheckBox();
            this._chBoxBenefits = new System.Windows.Forms.CheckBox();
            this._BtnSave = new System.Windows.Forms.Button();
            this._BtnClose = new System.Windows.Forms.Button();
            this._btnSearch = new System.Windows.Forms.Button();
            this.dbox_empType = new System.Windows.Forms.ComboBox();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.txt_info3 = new System.Windows.Forms.TextBox();
            this.txt_info1 = new System.Windows.Forms.TextBox();
            this.lbl_empType = new System.Windows.Forms.Label();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.lbl_empId = new System.Windows.Forms.Label();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.txt_info2 = new System.Windows.Forms.TextBox();
            this.txt_empName = new System.Windows.Forms.TextBox();
            this.btn_TestData = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_pg2.SuspendLayout();
            this.tab_employee.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_pg2
            // 
            this.tab_pg2.Controls.Add(this.tab_employee);
            this.tab_pg2.Location = new System.Drawing.Point(12, 12);
            this.tab_pg2.Name = "tab_pg2";
            this.tab_pg2.SelectedIndex = 0;
            this.tab_pg2.Size = new System.Drawing.Size(542, 297);
            this.tab_pg2.TabIndex = 5;
            // 
            // tab_employee
            // 
            this.tab_employee.Controls.Add(this._chBoxOvertime);
            this.tab_employee.Controls.Add(this._chBoxEDUBenefits);
            this.tab_employee.Controls.Add(this._chBoxCommission);
            this.tab_employee.Controls.Add(this._chBoxBenefits);
            this.tab_employee.Controls.Add(this._BtnSave);
            this.tab_employee.Controls.Add(this._BtnClose);
            this.tab_employee.Controls.Add(this._btnSearch);
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
            this.tab_employee.Controls.Add(this.menuStrip2);
            this.tab_employee.Location = new System.Drawing.Point(4, 22);
            this.tab_employee.Name = "tab_employee";
            this.tab_employee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_employee.Size = new System.Drawing.Size(534, 271);
            this.tab_employee.TabIndex = 0;
            this.tab_employee.Text = "Employee";
            this.tab_employee.UseVisualStyleBackColor = true;
            // 
            // _chBoxOvertime
            // 
            this._chBoxOvertime.AutoSize = true;
            this._chBoxOvertime.Location = new System.Drawing.Point(368, 141);
            this._chBoxOvertime.Name = "_chBoxOvertime";
            this._chBoxOvertime.Size = new System.Drawing.Size(68, 17);
            this._chBoxOvertime.TabIndex = 10;
            this._chBoxOvertime.Text = "Overtime";
            this._chBoxOvertime.UseVisualStyleBackColor = true;
            // 
            // _chBoxEDUBenefits
            // 
            this._chBoxEDUBenefits.AutoSize = true;
            this._chBoxEDUBenefits.Location = new System.Drawing.Point(368, 116);
            this._chBoxEDUBenefits.Name = "_chBoxEDUBenefits";
            this._chBoxEDUBenefits.Size = new System.Drawing.Size(123, 17);
            this._chBoxEDUBenefits.TabIndex = 9;
            this._chBoxEDUBenefits.Text = "Educational Benefits";
            this._chBoxEDUBenefits.UseVisualStyleBackColor = true;
            // 
            // _chBoxCommission
            // 
            this._chBoxCommission.AutoSize = true;
            this._chBoxCommission.Location = new System.Drawing.Point(368, 88);
            this._chBoxCommission.Name = "_chBoxCommission";
            this._chBoxCommission.Size = new System.Drawing.Size(81, 17);
            this._chBoxCommission.TabIndex = 8;
            this._chBoxCommission.Text = "Commission";
            this._chBoxCommission.UseVisualStyleBackColor = true;
            // 
            // _chBoxBenefits
            // 
            this._chBoxBenefits.AutoSize = true;
            this._chBoxBenefits.Location = new System.Drawing.Point(368, 61);
            this._chBoxBenefits.Name = "_chBoxBenefits";
            this._chBoxBenefits.Size = new System.Drawing.Size(64, 17);
            this._chBoxBenefits.TabIndex = 7;
            this._chBoxBenefits.Text = "Benefits";
            this._chBoxBenefits.UseVisualStyleBackColor = true;
            // 
            // _BtnSave
            // 
            this._BtnSave.Location = new System.Drawing.Point(218, 224);
            this._BtnSave.Name = "_BtnSave";
            this._BtnSave.Size = new System.Drawing.Size(91, 28);
            this._BtnSave.TabIndex = 13;
            this._BtnSave.Text = "Save";
            this._BtnSave.UseVisualStyleBackColor = true;
            this._BtnSave.Click += new System.EventHandler(this._BtnSave_Click);
            // 
            // _BtnClose
            // 
            this._BtnClose.Location = new System.Drawing.Point(413, 224);
            this._BtnClose.Name = "_BtnClose";
            this._BtnClose.Size = new System.Drawing.Size(91, 28);
            this._BtnClose.TabIndex = 15;
            this._BtnClose.Text = "Close";
            this._BtnClose.UseVisualStyleBackColor = true;
            this._BtnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(121, 224);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(91, 28);
            this._btnSearch.TabIndex = 12;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // dbox_empType
            // 
            this.dbox_empType.FormattingEnabled = true;
            this.dbox_empType.Items.AddRange(new object[] {
            "Contract",
            "Hourly",
            "Salary",
            "Sales"});
            this.dbox_empType.Location = new System.Drawing.Point(135, 112);
            this.dbox_empType.Name = "dbox_empType";
            this.dbox_empType.Size = new System.Drawing.Size(121, 21);
            this.dbox_empType.TabIndex = 3;
            this.dbox_empType.SelectedIndexChanged += new System.EventHandler(this.dbox_empType_SelectedIndexChanged);
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Location = new System.Drawing.Point(6, 164);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(36, 13);
            this.lbl_info2.TabIndex = 0;
            this.lbl_info2.Text = "info 2:";
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Location = new System.Drawing.Point(6, 85);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(87, 13);
            this.lbl_empName.TabIndex = 0;
            this.lbl_empName.Text = "Employee Name:";
            // 
            // txt_empID
            // 
            this.txt_empID.Location = new System.Drawing.Point(135, 59);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(194, 20);
            this.txt_empID.TabIndex = 1;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(315, 224);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(92, 28);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_info3
            // 
            this.lbl_info3.AutoSize = true;
            this.lbl_info3.Location = new System.Drawing.Point(6, 190);
            this.lbl_info3.Name = "lbl_info3";
            this.lbl_info3.Size = new System.Drawing.Size(36, 13);
            this.lbl_info3.TabIndex = 0;
            this.lbl_info3.Text = "info 3:";
            // 
            // txt_info3
            // 
            this.txt_info3.Location = new System.Drawing.Point(135, 190);
            this.txt_info3.Name = "txt_info3";
            this.txt_info3.Size = new System.Drawing.Size(194, 20);
            this.txt_info3.TabIndex = 6;
            // 
            // txt_info1
            // 
            this.txt_info1.Location = new System.Drawing.Point(135, 138);
            this.txt_info1.Name = "txt_info1";
            this.txt_info1.Size = new System.Drawing.Size(194, 20);
            this.txt_info1.TabIndex = 4;
            // 
            // lbl_empType
            // 
            this.lbl_empType.AutoSize = true;
            this.lbl_empType.Location = new System.Drawing.Point(6, 112);
            this.lbl_empType.Name = "lbl_empType";
            this.lbl_empType.Size = new System.Drawing.Size(83, 13);
            this.lbl_empType.TabIndex = 0;
            this.lbl_empType.Text = "Employee Type:";
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Location = new System.Drawing.Point(24, 225);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(91, 28);
            this.btn_AddEmployee.TabIndex = 11;
            this.btn_AddEmployee.Text = "Add Employee";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // lbl_empId
            // 
            this.lbl_empId.AutoSize = true;
            this.lbl_empId.Location = new System.Drawing.Point(6, 59);
            this.lbl_empId.Name = "lbl_empId";
            this.lbl_empId.Size = new System.Drawing.Size(70, 13);
            this.lbl_empId.TabIndex = 0;
            this.lbl_empId.Text = "Employee ID:";
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(6, 138);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(33, 13);
            this.lbl_info1.TabIndex = 0;
            this.lbl_info1.Text = "info1:";
            // 
            // txt_info2
            // 
            this.txt_info2.Location = new System.Drawing.Point(135, 164);
            this.txt_info2.Name = "txt_info2";
            this.txt_info2.Size = new System.Drawing.Size(194, 20);
            this.txt_info2.TabIndex = 5;
            // 
            // txt_empName
            // 
            this.txt_empName.Location = new System.Drawing.Point(135, 85);
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.Size = new System.Drawing.Size(194, 20);
            this.txt_empName.TabIndex = 2;
            // 
            // btn_TestData
            // 
            this.btn_TestData.Location = new System.Drawing.Point(412, 185);
            this.btn_TestData.Name = "btn_TestData";
            this.btn_TestData.Size = new System.Drawing.Size(92, 28);
            this.btn_TestData.TabIndex = 16;
            this.btn_TestData.Text = "Test Data";
            this.btn_TestData.UseVisualStyleBackColor = true;
            this.btn_TestData.Click += new System.EventHandler(this.btn_TestData_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(528, 24);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 335);
            this.Controls.Add(this.tab_pg2);
            this.Name = "Form_Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form_Employee_Load);
            this.tab_pg2.ResumeLayout(false);
            this.tab_employee.ResumeLayout(false);
            this.tab_employee.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_pg2;
        private System.Windows.Forms.TabPage tab_employee;
        private System.Windows.Forms.Button _BtnSave;
        private System.Windows.Forms.Button _BtnClose;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.ComboBox dbox_empType;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_info3;
        private System.Windows.Forms.TextBox txt_info3;
        private System.Windows.Forms.TextBox txt_info1;
        private System.Windows.Forms.Label lbl_empType;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Label lbl_empId;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.TextBox txt_info2;
        private System.Windows.Forms.TextBox txt_empName;
        private System.Windows.Forms.Button btn_TestData;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.CheckBox _chBoxOvertime;
        private System.Windows.Forms.CheckBox _chBoxEDUBenefits;
        private System.Windows.Forms.CheckBox _chBoxCommission;
        private System.Windows.Forms.CheckBox _chBoxBenefits;
    }
}

