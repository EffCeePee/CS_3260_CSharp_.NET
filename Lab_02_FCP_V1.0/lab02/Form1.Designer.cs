namespace lab02
{
    partial class form_calculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_opperand1r = new System.Windows.Forms.RichTextBox();
            this.txt_opperand2r = new System.Windows.Forms.RichTextBox();
            this.lbl_opperand1 = new System.Windows.Forms.Label();
            this.lbl_opperand2 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.RichTextBox();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.txt_operator = new System.Windows.Forms.RichTextBox();
            this.txt_plus1 = new System.Windows.Forms.RichTextBox();
            this.txt_plus2 = new System.Windows.Forms.RichTextBox();
            this.txt_opperand1c = new System.Windows.Forms.RichTextBox();
            this.txt_opperand2c = new System.Windows.Forms.RichTextBox();
            this.lbl_realNum = new System.Windows.Forms.Label();
            this.lbl_complexNum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txt_opperand1r
            // 
            this.txt_opperand1r.Location = new System.Drawing.Point(88, 92);
            this.txt_opperand1r.Multiline = false;
            this.txt_opperand1r.Name = "txt_opperand1r";
            this.txt_opperand1r.Size = new System.Drawing.Size(100, 27);
            this.txt_opperand1r.TabIndex = 1;
            this.txt_opperand1r.Text = "";
            this.txt_opperand1r.WordWrap = false;
            // 
            // txt_opperand2r
            // 
            this.txt_opperand2r.Location = new System.Drawing.Point(88, 176);
            this.txt_opperand2r.Multiline = false;
            this.txt_opperand2r.Name = "txt_opperand2r";
            this.txt_opperand2r.Size = new System.Drawing.Size(100, 27);
            this.txt_opperand2r.TabIndex = 3;
            this.txt_opperand2r.Text = "";
            this.txt_opperand2r.WordWrap = false;
            // 
            // lbl_opperand1
            // 
            this.lbl_opperand1.AutoSize = true;
            this.lbl_opperand1.Location = new System.Drawing.Point(12, 92);
            this.lbl_opperand1.Name = "lbl_opperand1";
            this.lbl_opperand1.Size = new System.Drawing.Size(70, 13);
            this.lbl_opperand1.TabIndex = 12;
            this.lbl_opperand1.Text = "Opperand #1";
            // 
            // lbl_opperand2
            // 
            this.lbl_opperand2.AutoSize = true;
            this.lbl_opperand2.Location = new System.Drawing.Point(12, 176);
            this.lbl_opperand2.Name = "lbl_opperand2";
            this.lbl_opperand2.Size = new System.Drawing.Size(70, 13);
            this.lbl_opperand2.TabIndex = 13;
            this.lbl_opperand2.Text = "Opperand #2";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(201, 285);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(65, 23);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(45, 324);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(37, 13);
            this.lbl_result.TabIndex = 16;
            this.lbl_result.Text = "Result";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(173, 314);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(112, 23);
            this.txt_result.TabIndex = 11;
            this.txt_result.Text = "";
            // 
            // btn_addition
            // 
            this.btn_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addition.Location = new System.Drawing.Point(173, 237);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(42, 32);
            this.btn_addition.TabIndex = 5;
            this.btn_addition.Text = "+";
            this.btn_addition.UseVisualStyleBackColor = true;
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtraction.Location = new System.Drawing.Point(243, 237);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(42, 32);
            this.btn_subtraction.TabIndex = 6;
            this.btn_subtraction.Text = "-";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            this.btn_subtraction.Click += new System.EventHandler(this.btn_subtraction_Click);
            // 
            // txt_operator
            // 
            this.txt_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txt_operator.Location = new System.Drawing.Point(217, 134);
            this.txt_operator.Name = "txt_operator";
            this.txt_operator.ReadOnly = true;
            this.txt_operator.Size = new System.Drawing.Size(19, 27);
            this.txt_operator.TabIndex = 9;
            this.txt_operator.Text = "";
            // 
            // txt_plus1
            // 
            this.txt_plus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plus1.Location = new System.Drawing.Point(217, 92);
            this.txt_plus1.Name = "txt_plus1";
            this.txt_plus1.ReadOnly = true;
            this.txt_plus1.Size = new System.Drawing.Size(19, 27);
            this.txt_plus1.TabIndex = 8;
            this.txt_plus1.Text = "+";
            // 
            // txt_plus2
            // 
            this.txt_plus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plus2.Location = new System.Drawing.Point(217, 176);
            this.txt_plus2.Name = "txt_plus2";
            this.txt_plus2.ReadOnly = true;
            this.txt_plus2.Size = new System.Drawing.Size(19, 27);
            this.txt_plus2.TabIndex = 10;
            this.txt_plus2.Text = "+";
            // 
            // txt_opperand1c
            // 
            this.txt_opperand1c.Location = new System.Drawing.Point(262, 89);
            this.txt_opperand1c.Multiline = false;
            this.txt_opperand1c.Name = "txt_opperand1c";
            this.txt_opperand1c.Size = new System.Drawing.Size(109, 30);
            this.txt_opperand1c.TabIndex = 2;
            this.txt_opperand1c.Text = "";
            this.txt_opperand1c.WordWrap = false;
            // 
            // txt_opperand2c
            // 
            this.txt_opperand2c.Location = new System.Drawing.Point(262, 173);
            this.txt_opperand2c.Multiline = false;
            this.txt_opperand2c.Name = "txt_opperand2c";
            this.txt_opperand2c.Size = new System.Drawing.Size(109, 27);
            this.txt_opperand2c.TabIndex = 4;
            this.txt_opperand2c.Text = "";
            this.txt_opperand2c.WordWrap = false;
            // 
            // lbl_realNum
            // 
            this.lbl_realNum.AutoSize = true;
            this.lbl_realNum.Location = new System.Drawing.Point(85, 59);
            this.lbl_realNum.Name = "lbl_realNum";
            this.lbl_realNum.Size = new System.Drawing.Size(69, 13);
            this.lbl_realNum.TabIndex = 14;
            this.lbl_realNum.Text = "Real Number";
            // 
            // lbl_complexNum
            // 
            this.lbl_complexNum.AutoSize = true;
            this.lbl_complexNum.Location = new System.Drawing.Point(259, 59);
            this.lbl_complexNum.Name = "lbl_complexNum";
            this.lbl_complexNum.Size = new System.Drawing.Size(87, 13);
            this.lbl_complexNum.TabIndex = 15;
            this.lbl_complexNum.Text = "Complex Number";
            // 
            // form_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 397);
            this.Controls.Add(this.lbl_complexNum);
            this.Controls.Add(this.lbl_realNum);
            this.Controls.Add(this.txt_opperand2c);
            this.Controls.Add(this.txt_opperand1c);
            this.Controls.Add(this.txt_plus2);
            this.Controls.Add(this.txt_plus1);
            this.Controls.Add(this.txt_operator);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_opperand2);
            this.Controls.Add(this.lbl_opperand1);
            this.Controls.Add(this.txt_opperand2r);
            this.Controls.Add(this.txt_opperand1r);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_calculator";
            this.Text = "Complex Number Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txt_opperand1r;
        private System.Windows.Forms.RichTextBox txt_opperand2r;
        private System.Windows.Forms.Label lbl_opperand1;
        private System.Windows.Forms.Label lbl_opperand2;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.RichTextBox txt_result;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_subtraction;
        private System.Windows.Forms.RichTextBox txt_operator;
        private System.Windows.Forms.RichTextBox txt_plus1;
        private System.Windows.Forms.RichTextBox txt_plus2;
        private System.Windows.Forms.RichTextBox txt_opperand1c;
        private System.Windows.Forms.RichTextBox txt_opperand2c;
        private System.Windows.Forms.Label lbl_realNum;
        private System.Windows.Forms.Label lbl_complexNum;
    }
}

