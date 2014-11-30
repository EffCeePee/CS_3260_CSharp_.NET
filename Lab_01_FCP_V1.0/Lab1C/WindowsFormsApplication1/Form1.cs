// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: lab1C.cs
// Date: 1/11/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


// Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// namespace delcaration
namespace WindowsFormsApplication1
{
    //class definiition
    public partial class Min_Max : Form
    {
        public Min_Max()
        {
            InitializeComponent();
        }

        private void Min_Max_Load(object sender, EventArgs e)
        {

            string maxVal = "The maximum value of an ";
            string minVal = "The minimum value of an ";
            string integer = "integer is: ";
            string shortNum = "short number is: ";
            string longNum = "long number is: ";
            string unsignedInt = "unsigned integer is: ";
            string unsignedShort = "unsigned short is: ";
            string unsignedLong = "unsigned long is: ";
            string character = "character is: ";
            string floatingPoint = "floating point number is: ";
            string boolean = "boolean value is: ";
            string decimalNum = "decimal number is: ";

            int iMax = int.MaxValue;
            int iMin = int.MinValue;
            uint uMax = uint.MaxValue;
            uint uMin = uint.MinValue;
            short sMax = short.MaxValue;
            short sMin = short.MinValue;
            ushort usMax = ushort.MaxValue;
            ushort usMin = ushort.MinValue;
            long lMax = long.MaxValue;
            long lMin = long.MinValue;
            ulong ulMax = ulong.MaxValue;
            ulong ulMin = ulong.MinValue;

            int cMax = char.MaxValue;
            cMax = cMax.GetHashCode();
            int cMin = char.MinValue;
            cMin = cMin.GetHashCode();

            float fMax = float.MaxValue;
            float fMin = float.MinValue;

            bool bMax = true;
            int boolMax = Convert.ToInt32(bMax);
            bool bMin = false;
            int boolMin = Convert.ToInt32(bMin);

            decimal dMax = decimal.MaxValue;
            decimal dMin = decimal.MinValue;
            
            richTextBox1.AppendText( maxVal+ integer+ iMax +"\r\n");
            richTextBox1.AppendText( minVal+ integer+ iMin+"\r\n");

            richTextBox1.AppendText( maxVal+ unsignedInt+ uMax+"\r\n");
            richTextBox1.AppendText( minVal+ unsignedInt+ uMin+"\r\n");

            richTextBox1.AppendText( maxVal+ shortNum+ sMax+"\r\n");
            richTextBox1.AppendText( minVal+ shortNum+ sMin+"\r\n");

            richTextBox1.AppendText( maxVal+ unsignedShort+ usMax+"\r\n");
            richTextBox1.AppendText( minVal+ unsignedShort+ usMin+"\r\n");

            richTextBox1.AppendText( maxVal+ longNum+ lMax+"\r\n");
            richTextBox1.AppendText( minVal+ longNum+ lMin+"\r\n");

            richTextBox1.AppendText( maxVal+ unsignedLong+ ulMax+"\r\n");
            richTextBox1.AppendText( minVal+ unsignedLong+ ulMin+"\r\n");

            richTextBox1.AppendText( maxVal+ character+ cMax+"\r\n");
            richTextBox1.AppendText( minVal+ character+ cMin+"\r\n");

            richTextBox1.AppendText( maxVal+ floatingPoint+ fMax+"\r\n");
            richTextBox1.AppendText( minVal+ floatingPoint+ fMin+"\r\n");

            richTextBox1.AppendText( maxVal+ boolean+ boolMax+"\r\n");
            richTextBox1.AppendText( minVal+ boolean+ boolMin+"\r\n");

            richTextBox1.AppendText( maxVal+ decimalNum+ dMax+"\r\n");
            richTextBox1.AppendText( minVal+ decimalNum+ dMin+"\r\n");

            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
