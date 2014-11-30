namespace GUI_RegEx_01
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
            this.components = new System.ComponentModel.Container();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblInput = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.LblRegEx = new System.Windows.Forms.Label();
            this.TxtRegExp = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.TxtExpNumber = new System.Windows.Forms.TextBox();
            this.LblExpNumber = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.BtnGroup = new System.Windows.Forms.Button();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.LblReplacement = new System.Windows.Forms.Label();
            this.TxtReplaceString = new System.Windows.Forms.TextBox();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(223, 278);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(181, 22);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(58, 13);
            this.LblInput.TabIndex = 1;
            this.LblInput.Text = "Test String";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(12, 38);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(379, 20);
            this.TxtInput.TabIndex = 0;
            this.TxtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnTest
            // 
            this.BtnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTest.Location = new System.Drawing.Point(223, 240);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // LblRegEx
            // 
            this.LblRegEx.AutoSize = true;
            this.LblRegEx.Location = new System.Drawing.Point(164, 63);
            this.LblRegEx.Name = "LblRegEx";
            this.LblRegEx.Size = new System.Drawing.Size(98, 13);
            this.LblRegEx.TabIndex = 1;
            this.LblRegEx.Text = "Regular Expression";
            // 
            // TxtRegExp
            // 
            this.TxtRegExp.Location = new System.Drawing.Point(12, 79);
            this.TxtRegExp.Name = "TxtRegExp";
            this.TxtRegExp.Size = new System.Drawing.Size(379, 20);
            this.TxtRegExp.TabIndex = 1;
            this.TxtRegExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(188, 141);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(37, 13);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "Status";
            // 
            // TxtStatus
            // 
            this.TxtStatus.Enabled = false;
            this.TxtStatus.Location = new System.Drawing.Point(95, 157);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(212, 20);
            this.TxtStatus.TabIndex = 3;
            this.TxtStatus.TabStop = false;
            this.TxtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(188, 181);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(37, 13);
            this.LblResult.TabIndex = 1;
            this.LblResult.Text = "Result";
            // 
            // TxtResult
            // 
            this.TxtResult.Enabled = false;
            this.TxtResult.Location = new System.Drawing.Point(12, 199);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(379, 20);
            this.TxtResult.TabIndex = 3;
            this.TxtResult.TabStop = false;
            this.TxtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtExpNumber
            // 
            this.TxtExpNumber.Location = new System.Drawing.Point(429, 197);
            this.TxtExpNumber.Name = "TxtExpNumber";
            this.TxtExpNumber.Size = new System.Drawing.Size(41, 20);
            this.TxtExpNumber.TabIndex = 4;
            this.TxtExpNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtExpNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtExpNumber_KeyPress);
            // 
            // LblExpNumber
            // 
            this.LblExpNumber.AutoSize = true;
            this.LblExpNumber.Location = new System.Drawing.Point(427, 181);
            this.LblExpNumber.Name = "LblExpNumber";
            this.LblExpNumber.Size = new System.Drawing.Size(44, 13);
            this.LblExpNumber.TabIndex = 5;
            this.LblExpNumber.Text = "Number";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(437, 220);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(22, 13);
            this.LblCount.TabIndex = 6;
            this.LblCount.Text = "1-5";
            // 
            // BtnGroup
            // 
            this.BtnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGroup.Location = new System.Drawing.Point(412, 236);
            this.BtnGroup.Name = "BtnGroup";
            this.BtnGroup.Size = new System.Drawing.Size(75, 23);
            this.BtnGroup.TabIndex = 7;
            this.BtnGroup.Text = "Group";
            this.BtnGroup.UseVisualStyleBackColor = true;
            this.BtnGroup.Click += new System.EventHandler(this.BtnGroup_Click);
            // 
            // BtnReplace
            // 
            this.BtnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReplace.Location = new System.Drawing.Point(412, 265);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(75, 23);
            this.BtnReplace.TabIndex = 7;
            this.BtnReplace.Text = "Replace";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // LblReplacement
            // 
            this.LblReplacement.AutoSize = true;
            this.LblReplacement.Location = new System.Drawing.Point(160, 102);
            this.LblReplacement.Name = "LblReplacement";
            this.LblReplacement.Size = new System.Drawing.Size(100, 13);
            this.LblReplacement.TabIndex = 8;
            this.LblReplacement.Text = "Replacement String";
            // 
            // TxtReplaceString
            // 
            this.TxtReplaceString.Location = new System.Drawing.Point(78, 118);
            this.TxtReplaceString.Name = "TxtReplaceString";
            this.TxtReplaceString.Size = new System.Drawing.Size(266, 20);
            this.TxtReplaceString.TabIndex = 9;
            this.TxtReplaceString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 310);
            this.Controls.Add(this.TxtReplaceString);
            this.Controls.Add(this.LblReplacement);
            this.Controls.Add(this.BtnReplace);
            this.Controls.Add(this.BtnGroup);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.LblExpNumber);
            this.Controls.Add(this.TxtExpNumber);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtRegExp);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.LblRegEx);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.BtnExit);
            this.Name = "FrmMain";
            this.Text = "Regular Expression - Form";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Label LblRegEx;
        private System.Windows.Forms.TextBox TxtRegExp;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.TextBox TxtExpNumber;
        private System.Windows.Forms.Label LblExpNumber;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Button BtnGroup;
        private System.Windows.Forms.Button BtnReplace;
        private System.Windows.Forms.Label LblReplacement;
        private System.Windows.Forms.TextBox TxtReplaceString;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
    }
}

