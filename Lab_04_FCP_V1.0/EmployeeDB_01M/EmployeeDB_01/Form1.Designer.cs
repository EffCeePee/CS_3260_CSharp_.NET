namespace EmployeeDB_01
{
    partial class FrmMain
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
            this.BtnTestData = new System.Windows.Forms.Button();
            this.LblEmpID = new System.Windows.Forms.Label();
            this.TxtEmpID = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblEmpType = new System.Windows.Forms.Label();
            this.TxtEmpType = new System.Windows.Forms.TextBox();
            this.LblValue0 = new System.Windows.Forms.Label();
            this.TxtValue0 = new System.Windows.Forms.TextBox();
            this.LblValue1 = new System.Windows.Forms.Label();
            this.TxtValue1 = new System.Windows.Forms.TextBox();
            this.LblValue2 = new System.Windows.Forms.Label();
            this.TxtValue2 = new System.Windows.Forms.TextBox();
            this.TCtlMain = new System.Windows.Forms.TabControl();
            this.TPgFront = new System.Windows.Forms.TabPage();
            this.RBtnContract = new System.Windows.Forms.RadioButton();
            this.RBtnSales = new System.Windows.Forms.RadioButton();
            this.RBtnHourly = new System.Windows.Forms.RadioButton();
            this.RBtnSalary = new System.Windows.Forms.RadioButton();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.TPgDisplay = new System.Windows.Forms.TabPage();
            this.RTxtDisplay = new System.Windows.Forms.RichTextBox();
            this.BtnCalcSalary = new System.Windows.Forms.Button();
            this.TCtlMain.SuspendLayout();
            this.TPgFront.SuspendLayout();
            this.TPgDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTestData
            // 
            this.BtnTestData.Location = new System.Drawing.Point(17, 315);
            this.BtnTestData.Name = "BtnTestData";
            this.BtnTestData.Size = new System.Drawing.Size(75, 23);
            this.BtnTestData.TabIndex = 0;
            this.BtnTestData.Text = "Test Data";
            this.BtnTestData.UseVisualStyleBackColor = true;
            this.BtnTestData.Click += new System.EventHandler(this.BtnTestData_Click);
            // 
            // LblEmpID
            // 
            this.LblEmpID.AutoSize = true;
            this.LblEmpID.Location = new System.Drawing.Point(31, 23);
            this.LblEmpID.Name = "LblEmpID";
            this.LblEmpID.Size = new System.Drawing.Size(70, 13);
            this.LblEmpID.TabIndex = 1;
            this.LblEmpID.Text = "Employee ID:";
            // 
            // TxtEmpID
            // 
            this.TxtEmpID.Location = new System.Drawing.Point(116, 20);
            this.TxtEmpID.Name = "TxtEmpID";
            this.TxtEmpID.Size = new System.Drawing.Size(100, 20);
            this.TxtEmpID.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(164, 456);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(141, 315);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(31, 63);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(83, 60);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(170, 20);
            this.TxtName.TabIndex = 2;
            // 
            // LblEmpType
            // 
            this.LblEmpType.AutoSize = true;
            this.LblEmpType.Location = new System.Drawing.Point(31, 105);
            this.LblEmpType.Name = "LblEmpType";
            this.LblEmpType.Size = new System.Drawing.Size(83, 13);
            this.LblEmpType.TabIndex = 1;
            this.LblEmpType.Text = "Employee Type:";
            // 
            // TxtEmpType
            // 
            this.TxtEmpType.Location = new System.Drawing.Point(116, 102);
            this.TxtEmpType.Name = "TxtEmpType";
            this.TxtEmpType.Size = new System.Drawing.Size(100, 20);
            this.TxtEmpType.TabIndex = 2;
            // 
            // LblValue0
            // 
            this.LblValue0.AutoSize = true;
            this.LblValue0.Location = new System.Drawing.Point(31, 149);
            this.LblValue0.Name = "LblValue0";
            this.LblValue0.Size = new System.Drawing.Size(46, 13);
            this.LblValue0.TabIndex = 1;
            this.LblValue0.Text = "Value 0:";
            // 
            // TxtValue0
            // 
            this.TxtValue0.Location = new System.Drawing.Point(153, 146);
            this.TxtValue0.Name = "TxtValue0";
            this.TxtValue0.Size = new System.Drawing.Size(100, 20);
            this.TxtValue0.TabIndex = 2;
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(31, 191);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(46, 13);
            this.LblValue1.TabIndex = 1;
            this.LblValue1.Text = "Value 1:";
            // 
            // TxtValue1
            // 
            this.TxtValue1.Location = new System.Drawing.Point(153, 184);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(100, 20);
            this.TxtValue1.TabIndex = 2;
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(31, 231);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(46, 13);
            this.LblValue2.TabIndex = 1;
            this.LblValue2.Text = "Value 2:";
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(153, 224);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(100, 20);
            this.TxtValue2.TabIndex = 2;
            // 
            // TCtlMain
            // 
            this.TCtlMain.Controls.Add(this.TPgFront);
            this.TCtlMain.Controls.Add(this.TPgDisplay);
            this.TCtlMain.Location = new System.Drawing.Point(12, 12);
            this.TCtlMain.Name = "TCtlMain";
            this.TCtlMain.SelectedIndex = 0;
            this.TCtlMain.Size = new System.Drawing.Size(403, 419);
            this.TCtlMain.TabIndex = 3;
            // 
            // TPgFront
            // 
            this.TPgFront.Controls.Add(this.BtnCalcSalary);
            this.TPgFront.Controls.Add(this.RBtnContract);
            this.TPgFront.Controls.Add(this.RBtnSales);
            this.TPgFront.Controls.Add(this.RBtnHourly);
            this.TPgFront.Controls.Add(this.RBtnSalary);
            this.TPgFront.Controls.Add(this.BtnAddEmployee);
            this.TPgFront.Controls.Add(this.TxtEmpID);
            this.TPgFront.Controls.Add(this.BtnClear);
            this.TPgFront.Controls.Add(this.TxtValue2);
            this.TPgFront.Controls.Add(this.LblEmpID);
            this.TPgFront.Controls.Add(this.BtnTestData);
            this.TPgFront.Controls.Add(this.LblValue2);
            this.TPgFront.Controls.Add(this.LblName);
            this.TPgFront.Controls.Add(this.TxtValue1);
            this.TPgFront.Controls.Add(this.TxtName);
            this.TPgFront.Controls.Add(this.LblValue1);
            this.TPgFront.Controls.Add(this.LblEmpType);
            this.TPgFront.Controls.Add(this.TxtValue0);
            this.TPgFront.Controls.Add(this.TxtEmpType);
            this.TPgFront.Controls.Add(this.LblValue0);
            this.TPgFront.Location = new System.Drawing.Point(4, 22);
            this.TPgFront.Name = "TPgFront";
            this.TPgFront.Padding = new System.Windows.Forms.Padding(3);
            this.TPgFront.Size = new System.Drawing.Size(395, 393);
            this.TPgFront.TabIndex = 0;
            this.TPgFront.Text = "Main Page";
            this.TPgFront.UseVisualStyleBackColor = true;
            // 
            // RBtnContract
            // 
            this.RBtnContract.AutoSize = true;
            this.RBtnContract.Location = new System.Drawing.Point(271, 170);
            this.RBtnContract.Name = "RBtnContract";
            this.RBtnContract.Size = new System.Drawing.Size(114, 17);
            this.RBtnContract.TabIndex = 7;
            this.RBtnContract.Text = "Contract Employee";
            this.RBtnContract.UseVisualStyleBackColor = true;
            // 
            // RBtnSales
            // 
            this.RBtnSales.AutoSize = true;
            this.RBtnSales.Location = new System.Drawing.Point(271, 147);
            this.RBtnSales.Name = "RBtnSales";
            this.RBtnSales.Size = new System.Drawing.Size(100, 17);
            this.RBtnSales.TabIndex = 6;
            this.RBtnSales.Text = "Sales Employee";
            this.RBtnSales.UseVisualStyleBackColor = true;
            // 
            // RBtnHourly
            // 
            this.RBtnHourly.AutoSize = true;
            this.RBtnHourly.Location = new System.Drawing.Point(271, 124);
            this.RBtnHourly.Name = "RBtnHourly";
            this.RBtnHourly.Size = new System.Drawing.Size(104, 17);
            this.RBtnHourly.TabIndex = 5;
            this.RBtnHourly.Text = "Hourly Employee";
            this.RBtnHourly.UseVisualStyleBackColor = true;
            // 
            // RBtnSalary
            // 
            this.RBtnSalary.AutoSize = true;
            this.RBtnSalary.Location = new System.Drawing.Point(271, 101);
            this.RBtnSalary.Name = "RBtnSalary";
            this.RBtnSalary.Size = new System.Drawing.Size(103, 17);
            this.RBtnSalary.TabIndex = 4;
            this.RBtnSalary.Text = "Salary Employee";
            this.RBtnSalary.UseVisualStyleBackColor = true;
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(141, 264);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(75, 35);
            this.BtnAddEmployee.TabIndex = 3;
            this.BtnAddEmployee.Text = "Add Employee";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // TPgDisplay
            // 
            this.TPgDisplay.Controls.Add(this.RTxtDisplay);
            this.TPgDisplay.Location = new System.Drawing.Point(4, 22);
            this.TPgDisplay.Name = "TPgDisplay";
            this.TPgDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.TPgDisplay.Size = new System.Drawing.Size(395, 393);
            this.TPgDisplay.TabIndex = 1;
            this.TPgDisplay.Text = "Display Page";
            this.TPgDisplay.UseVisualStyleBackColor = true;
            // 
            // RTxtDisplay
            // 
            this.RTxtDisplay.Location = new System.Drawing.Point(6, 6);
            this.RTxtDisplay.Name = "RTxtDisplay";
            this.RTxtDisplay.Size = new System.Drawing.Size(365, 381);
            this.RTxtDisplay.TabIndex = 0;
            this.RTxtDisplay.Text = "--------------- Display -------------------";
            // 
            // BtnCalcSalary
            // 
            this.BtnCalcSalary.Location = new System.Drawing.Point(248, 264);
            this.BtnCalcSalary.Name = "BtnCalcSalary";
            this.BtnCalcSalary.Size = new System.Drawing.Size(75, 41);
            this.BtnCalcSalary.TabIndex = 4;
            this.BtnCalcSalary.Text = "Calculate Salary";
            this.BtnCalcSalary.UseVisualStyleBackColor = true;
            this.BtnCalcSalary.Click += new System.EventHandler(this.BtnCalcSalary_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 498);
            this.Controls.Add(this.TCtlMain);
            this.Controls.Add(this.BtnExit);
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TCtlMain.ResumeLayout(false);
            this.TPgFront.ResumeLayout(false);
            this.TPgFront.PerformLayout();
            this.TPgDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTestData;
        private System.Windows.Forms.Label LblEmpID;
        private System.Windows.Forms.TextBox TxtEmpID;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblEmpType;
        private System.Windows.Forms.TextBox TxtEmpType;
        private System.Windows.Forms.Label LblValue0;
        private System.Windows.Forms.TextBox TxtValue0;
        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.TabControl TCtlMain;
        private System.Windows.Forms.TabPage TPgFront;
        private System.Windows.Forms.TabPage TPgDisplay;
        private System.Windows.Forms.RichTextBox RTxtDisplay;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.RadioButton RBtnContract;
        private System.Windows.Forms.RadioButton RBtnSales;
        private System.Windows.Forms.RadioButton RBtnHourly;
        private System.Windows.Forms.RadioButton RBtnSalary;
        private System.Windows.Forms.Button BtnCalcSalary;
    }
}

