namespace Operator_Overloading_01
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
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblLeftOperand = new System.Windows.Forms.Label();
            this.LBoxOperators = new System.Windows.Forms.ListBox();
            this.TxtLeftOperand = new System.Windows.Forms.TextBox();
            this.TxtRightOperand = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.LblRightOperand = new System.Windows.Forms.Label();
            this.LblAssignment = new System.Windows.Forms.Label();
            this.LblOperator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNonsense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(183, 95);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 3;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // LblLeftOperand
            // 
            this.LblLeftOperand.AutoSize = true;
            this.LblLeftOperand.Location = new System.Drawing.Point(38, 23);
            this.LblLeftOperand.Name = "LblLeftOperand";
            this.LblLeftOperand.Size = new System.Drawing.Size(72, 13);
            this.LblLeftOperand.TabIndex = 1;
            this.LblLeftOperand.Text = "Left Operand:";
            // 
            // LBoxOperators
            // 
            this.LBoxOperators.FormattingEnabled = true;
            this.LBoxOperators.Items.AddRange(new object[] {
            " +       Positive",
            "-         Negation",
            "+        Addition",
            "-         Subtration",
            "++     Increment",
            "--       Decrement",
            "*         Multiplication",
            "/         Division",
            "%       Modulus",
            ">       Greater Than",
            "<       Less Than",
            ">=     Greater Than or Equal",
            "<=     Less Than or Equal",
            "==     Equal",
            ">>     Right Shift",
            "<<     Left Shift",
            "!=      Not Equal",
            "!          Not",
            "true   True",
            "false  False",
            "~      complement (bitwise)",
            "&      AND        (bitwise)",
            "|      OR         (bitwise)",
            "^      XOR        (bitwise)",
            "int    int conversion (explicit)",
            "double double conversion (implicit)",
            "char   char conversion (implicit)"});
            this.LBoxOperators.Location = new System.Drawing.Point(434, 23);
            this.LBoxOperators.Name = "LBoxOperators";
            this.LBoxOperators.Size = new System.Drawing.Size(193, 368);
            this.LBoxOperators.TabIndex = 2;
            this.LBoxOperators.TabStop = false;
            this.LBoxOperators.UseTabStops = false;
            this.LBoxOperators.SelectedIndexChanged += new System.EventHandler(this.LBoxOperators_SelectedIndexChanged);
            // 
            // TxtLeftOperand
            // 
            this.TxtLeftOperand.Location = new System.Drawing.Point(24, 39);
            this.TxtLeftOperand.Name = "TxtLeftOperand";
            this.TxtLeftOperand.Size = new System.Drawing.Size(100, 20);
            this.TxtLeftOperand.TabIndex = 0;
            this.TxtLeftOperand.Text = "5.5";
            this.TxtLeftOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRightOperand
            // 
            this.TxtRightOperand.Location = new System.Drawing.Point(203, 39);
            this.TxtRightOperand.Name = "TxtRightOperand";
            this.TxtRightOperand.Size = new System.Drawing.Size(100, 20);
            this.TxtRightOperand.TabIndex = 1;
            this.TxtRightOperand.Text = "4.4";
            this.TxtRightOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRightOperand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRightOperand_KeyPress);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(289, 415);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(328, 39);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(100, 20);
            this.TxtResult.TabIndex = 2;
            this.TxtResult.TabStop = false;
            this.TxtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblRightOperand
            // 
            this.LblRightOperand.AutoSize = true;
            this.LblRightOperand.Location = new System.Drawing.Point(212, 23);
            this.LblRightOperand.Name = "LblRightOperand";
            this.LblRightOperand.Size = new System.Drawing.Size(79, 13);
            this.LblRightOperand.TabIndex = 1;
            this.LblRightOperand.Text = "Right Operand:";
            // 
            // LblAssignment
            // 
            this.LblAssignment.AutoSize = true;
            this.LblAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAssignment.Location = new System.Drawing.Point(307, 39);
            this.LblAssignment.Name = "LblAssignment";
            this.LblAssignment.Size = new System.Drawing.Size(19, 20);
            this.LblAssignment.TabIndex = 1;
            this.LblAssignment.Text = "=";
            // 
            // LblOperator
            // 
            this.LblOperator.AutoSize = true;
            this.LblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperator.Location = new System.Drawing.Point(127, 38);
            this.LblOperator.Name = "LblOperator";
            this.LblOperator.Size = new System.Drawing.Size(37, 20);
            this.LblOperator.TabIndex = 1;
            this.LblOperator.Text = "Op:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // BtnNonsense
            // 
            this.BtnNonsense.Location = new System.Drawing.Point(183, 141);
            this.BtnNonsense.Name = "BtnNonsense";
            this.BtnNonsense.Size = new System.Drawing.Size(75, 23);
            this.BtnNonsense.TabIndex = 4;
            this.BtnNonsense.Text = "Nonsense!";
            this.BtnNonsense.UseVisualStyleBackColor = true;
            this.BtnNonsense.Click += new System.EventHandler(this.BtnNonsense_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.BtnNonsense);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtRightOperand);
            this.Controls.Add(this.TxtLeftOperand);
            this.Controls.Add(this.LBoxOperators);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblOperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblAssignment);
            this.Controls.Add(this.LblRightOperand);
            this.Controls.Add(this.LblLeftOperand);
            this.Controls.Add(this.BtnCalc);
            this.Name = "FrmMain";
            this.Text = "Operator Overloading Examples";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblLeftOperand;
        private System.Windows.Forms.ListBox LBoxOperators;
        private System.Windows.Forms.TextBox TxtLeftOperand;
        private System.Windows.Forms.TextBox TxtRightOperand;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label LblRightOperand;
        private System.Windows.Forms.Label LblAssignment;
        private System.Windows.Forms.Label LblOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNonsense;
    }
}

