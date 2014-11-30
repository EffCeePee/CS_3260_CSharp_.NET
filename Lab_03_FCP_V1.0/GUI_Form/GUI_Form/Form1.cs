using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Form
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        // by double clicking you get "load"
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            // when they press enter after the text box we can get the text
            if(e.KeyChar == (char)Keys.Enter)
            {
                // Modal, means we can't go back to thet program without addressing the box
                MessageBox.Show("You entered the following text: " + txt_name.Text );  
            }
        }
    }
}
