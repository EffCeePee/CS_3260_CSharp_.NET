using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI_RegEx_01
{
    public partial class FrmMain : Form
    {
        private Regex _regEx;
        private Match _match;
        private int _length;
        private int _index;
        private string _value;
        private bool _success;
        private List<string> _listRE;
        /// <summary>
        /// Purpose: Initialize Form controls
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: Initialize FrmMain class variables befor FrmMain loads & shows
        /// </summary>
        /// <param name="sender">FrmMain Load Event</param>
        /// <param name="e">Not used!</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            _regEx = null;
            _match = null;
            _length = default(int);
            _index = 0;
            _value = null;
            _success = false;
            TestRegExp _testRE = new TestRegExp();
            _listRE = _testRE.GetRegExpList();
            LblCount.Text = "1-" + (_listRE.Count - 1);
        }
        /// <summary>
        /// Purpose: To respond to BtnText Click Event
        /// </summary>
        /// <param name="sender">BtnTest Click Event</param>
        /// <param name="e">Not used!</param>
        private void BtnTest_Click(object sender, EventArgs e)
        {
            TestRegExp();

        }

        private void TestRegExp()
        {
            ErrorProvider1.Clear();
            ErrorProvider1.Tag = 0;
            if (TxtInput.Text == "")
            {
                ErrorProvider1.SetError(TxtInput, "Empty String");
                ErrorProvider1.Tag = 1;
                TxtStatus.Text = "Failed";
            }
            if (TxtRegExp.Text == "")
            {
                ErrorProvider1.SetError(TxtRegExp, "Empty String");
                ErrorProvider1.Tag = 1;
                TxtStatus.Text = "Failed";
            }
            else if ((int)ErrorProvider1.Tag == 1)
            {
                return;
            }
            _regEx = new Regex(TxtRegExp.Text);
            _match = _regEx.Match(TxtInput.Text);
            _length = _match.Length;
            _index = _match.Index;
            _value = _match.Value;
            _success = _match.Success;
            if (!_success)
                ErrorProvider1.SetError(TxtStatus, "No match occurred!");
            TxtStatus.Text = "Success: " + _success + " Length: " + _length + " index: " + _index;
            TxtResult.Text = "" + _value;
        }
        /// <summary>
        /// Purpose: Respond to BtnExit Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Not used!</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Purpose: To respond to TxtExpNumber KeyPress event to select a Regular Expression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Not used!</param>
        private void TxtExpNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleExpNumb(e);
        }

        private void HandleExpNumb(KeyPressEventArgs e)
        {
            int number = -1;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (int.TryParse(TxtExpNumber.Text, out number))
                {
                    if (number >= 0 && number < _listRE.Count)
                        TxtRegExp.Text = _listRE[number];
                    else
                    {
                        MessageBox.Show("Invalid Regular Expression Number -> " + number);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Regular Expression Number -> " + number);
                    return;
                }
            }
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            TestRegExpReplace();
        }

        private void TestRegExpReplace()
        {
            ErrorProvider1.Clear();
            ErrorProvider1.Tag = 0;
            if (TxtInput.Text == "")
            {
                ErrorProvider1.SetError(TxtInput, "Empty String");
                ErrorProvider1.Tag = 1;
                TxtStatus.Text = "Failed";
            }
            if (TxtRegExp.Text == "")
            {
                ErrorProvider1.SetError(TxtRegExp, "Empty String");
                ErrorProvider1.Tag = 1;
                TxtStatus.Text = "Failed";
            }
            if (TxtReplaceString.Text == "")
            {
                ErrorProvider1.SetError(TxtReplaceString, "Empty String");
                ErrorProvider1.Tag = 1;
                TxtStatus.Text = "Failed";
            }
            else if ((int)ErrorProvider1.Tag == 1)
            {
                return;
            }
            TxtResult.Text = Regex.Replace(TxtInput.Text, TxtRegExp.Text, TxtReplaceString.Text);
            if (TxtResult.Text.Length > 0)
                TxtStatus.Text = "Succeeded!";
            else
                ErrorProvider1.SetError(TxtStatus, "Replacement Failed!");
        }

        private void BtnGroup_Click(object sender, EventArgs e)
        {
            TestRegExpGroup();
        }

        private void TestRegExpGroup()
        {
            string inputStg = "aaabbbccc:aaabbbccc:aaabbbccc";
            TxtInput.Text = inputStg;
            string regexStg = "(aaa)(bbb)(ccc)";
            TxtRegExp.Text = regexStg;
            Regex re2 = new Regex(regexStg);
            Console.WriteLine("--------------- Groups ----------");
            Console.WriteLine("Replace...");
            TxtReplaceString.Text = "$3$2$1";
            string group1 = re2.Replace(inputStg, "$3$2$1", 1);
            string group2 = re2.Replace(inputStg, "$3$2$1", 2);
            string group3 = re2.Replace(inputStg, "$3$2$1", 3);
            TxtResult.Text = "See MessageBox";
            TxtStatus.Text = "Succeeded";
            MessageBox.Show("Replace Once - " + group1 + "\n" + "Replace Twice - " + group2 + "\n" + "Replace Thrice - " + group3, "Grouping Example");
        }
    }//End class FrmMain
}//End namespace GUI_RegEx_01
