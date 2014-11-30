using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator_Overloading_01
{
    enum OPS{POS=0, NEG, ADD, SUB, INC, DEC, MULT, DIV, MOD, GT, LT, GTE, LTE, EQ, RSHFT, LSHFT, NEQ, NOT, TRU, FAL, COMP, AND, OR, XOR, INT, DBL, CHAR}
    // +       Positive
    // -       Negation
    // +       Addition
    // -       Subtration
    // ++      Increment
    // --      Decrement
    // *       Multiplication
    // /       Division
    // %       Modulus
    // >       Greater Than
    // <       Less Than
    // >=      Greater Than or Equal
    // <=      Less Than or Equal
    // ==      Equal
    // >>      Extraction
    // <<      Insertion
    // !=      Not Equal
    // !       Not
    // true    True
    // false   False
    // ~       Complement (bitwise)
    // &       AND        (bitwise)
    // |       OR         (bitwise)
    // ^       XOR        (bitwise)
    // int     int conversion (explicit)
    // double  double conversion (implicit)
    // char    char conversion (implicit)
    /// <summary>
    /// Purpose: Test overloaded operators listed above
    /// </summary>
    public partial class FrmMain : Form
    {
        const int SIZE = 4;
        const double VAL = 10.5;
        private Data _dataLop;
        private Data _dataRop;
        private Data _dataResult;
        private OPS _operator;
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: To start overloaded operator tests
        /// </summary>
        /// <param name="sender">BtnCalc Event</param>
        /// <param name="e">Not used</param>
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            TestOperators();
        }
        /// <summary>
        /// Purpose: Demostrate the use of i++ + i++ * ++i
        /// </summary>
        public void TestInc()
        {
            int i = 6;
            int iResult = i+++i++*++i;
            MessageBox.Show("i+++i++*++i = " + iResult,"Result");
        }
        /// <summary>
        /// Purpose: Test overloaded operators
        /// </summary>
        private void TestOperators()
        {
            _dataLop = new Data(TxtLeftOperand.Text);
            _dataRop = new Data(TxtRightOperand.Text);
            _dataResult = new Data(SIZE);
            switch(_operator)
            {
                case OPS.ADD:
                    _dataResult = _dataLop + _dataRop;
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.OperandD);
                    LblOperator.Text = "+";
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.OperandD);
                    MessageBox.Show("Addition _dataLop + _dataRop","Addition");
                    _dataResult += VAL;
                    LblOperator.Text = "  +";
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.OperandD);
                    MessageBox.Show("Addition _dataResult += 10.5","Addition");
                    break;
                case OPS.DEC:
                    _dataResult = _dataLop--;
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.OperandD);
                    TxtRightOperand.Text = string.Format("{0:F3}", _dataLop.OperandD);
                    LblOperator.Text = "Post--";
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.OperandD);
                    MessageBox.Show("Post Decrement - _dataLop");
                    _dataResult = --_dataRop;
                    LblOperator.Text = "--Pre";
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.OperandD);
                    TxtRightOperand.Text = string.Format("{0:F3}", _dataRop.OperandD);
                    MessageBox.Show("Pre Decrement - _dataRop");
                    break;
                case OPS.DIV:
                    _dataResult = _dataLop / _dataRop;
                    LblOperator.Text = "  /";
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.OperandD);
                    break;
                case OPS.EQ:
                    _dataResult.State = (_dataLop == _dataRop);
                    LblOperator.Text = "  ==";
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.State);
                    break;
                case OPS.RSHFT:
                    _dataResult = _dataLop >> (int)_dataRop;
                    LblOperator.Text = "  >>";
                    TxtResult.Text = string.Format("{0:X}", _dataResult.OperandI);
                    break;
                case OPS.FAL:
                    if (_dataLop && _dataRop)
                        _dataResult.State = true;
                    else
                        _dataResult.State = false;
                    LblOperator.Text = "False";
                    TxtResult.Text = string.Format("{0}", _dataResult.State);
                    break;
                case OPS.GT:
                    _dataResult.State = (_dataLop > _dataRop);
                    LblOperator.Text = "  >";
                    TxtResult.Text = string.Format("{0}", _dataResult.State);
                    break;
                case OPS.GTE:
                    _dataResult.State = (_dataLop >= _dataRop);
                    LblOperator.Text = "  >=";
                    TxtResult.Text = string.Format("{0}", _dataResult.State);
                    break;
                case OPS.INC:
                    _dataResult = _dataLop++;
                    TxtResult.Text = string.Format("{0:F3}", _dataResult.OperandD);
                    TxtRightOperand.Text = string.Format("{0:F3}", _dataLop.OperandD);
                    LblOperator.Text = "Post++";
                    MessageBox.Show("Post Increment + _dataLop");
                    _dataResult = ++_dataRop;
                    LblOperator.Text = "++Pre";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandD);
                    TxtRightOperand.Text = string.Format("{0:F3}", _dataRop.OperandD);
                    MessageBox.Show("Pre Increment - _dataRop");
                    break;
                case OPS.LSHFT:
                    _dataResult = _dataLop << (int)_dataRop;
                    LblOperator.Text = "  <<";
                    TxtResult.Text = string.Format("{0:X}", _dataResult.OperandI);
                    break;
                case OPS.LT:
                    _dataResult.State = (_dataLop <_dataRop);
                    LblOperator.Text = "  <";
                    TxtResult.Text = string.Format("{0}", _dataResult.State);
                    break;
                case OPS.LTE:
                    _dataResult.State = (_dataLop <= _dataRop);
                    LblOperator.Text = "  <=";
                    TxtResult.Text = string.Format("{0}", _dataResult.State);
                    break;
                case OPS.MOD:
                    _dataResult = _dataLop % _dataRop;
                    LblOperator.Text = "  %";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandD);
                    MessageBox.Show("Floating Point Modulus _dataLop % _dataRop", "Modulus");
                    _dataResult = _dataLop % 3;
                    LblOperator.Text = "  %";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandI);
                    MessageBox.Show("Integer Modulus _dataLop % 3", "Modulus");
                    break;
                case OPS.MULT:
                    _dataResult = _dataLop * _dataRop;
                    LblOperator.Text = "  *";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandD);
                    break;
                case OPS.NEG:
                    _dataResult = -_dataLop;
                    LblOperator.Text = "-(neg)";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandD);
                    break;
                case OPS.NEQ:
                    _dataResult.State = (_dataLop != _dataRop);
                    LblOperator.Text = "  !=";
                    TxtResult.Text = string.Format("{0}", _dataResult.State);
                    break;
                case OPS.NOT:
                    _dataResult = !_dataLop;
                    LblOperator.Text = "  !";
                    TxtResult.Text = string.Format("{0}", _dataResult.State);
                    break;
                case OPS.POS:
                    _dataResult = +_dataLop;
                    LblOperator.Text = "+ (pos)";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandD);
                    break;
                case OPS.SUB:
                    _dataResult = _dataLop - _dataRop;
                    LblOperator.Text = "  -";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandD);
                    break;
                case OPS.TRU:
                    if (_dataLop || _dataRop)
                        _dataResult.State = true;
                    else
                        _dataResult.State = false;
                    LblOperator.Text = "True";
                    TxtResult.Text = string.Format("{0}", _dataResult.State);
                    break;
                case OPS.XOR:
                    _dataResult = _dataLop ^ _dataRop;
                    LblOperator.Text = "  ^";
                    TxtResult.Text = string.Format("{0:X}", _dataResult.OperandI);
                    break;
                case OPS.CHAR:
                    _dataResult = _dataLop - _dataRop;
                    LblOperator.Text = "chr cnv";
                    TxtResult.Text = string.Format("{0}", (char)_dataResult.OperandI);
                    break;
                case OPS.COMP:
                    _dataResult = ~_dataLop;
                    LblOperator.Text = "  ~";
                    TxtResult.Text = string.Format("{0:X}", _dataResult.OperandI);
                    break;
                case OPS.DBL:
                    _dataResult = _dataLop;
                    LblOperator.Text = "dbl cnv";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandD);
                    break;
                case OPS.INT:
                    _dataResult = _dataLop;
                    LblOperator.Text = "int conv";
                    TxtResult.Text = string.Format("{0}", _dataResult.OperandI);
                    break;
                case OPS.AND:
                    _dataResult = _dataLop & _dataRop;
                    LblOperator.Text = @"&AND ";
                    TxtResult.Text = string.Format("{0:X}", _dataResult.OperandI);
                    break;
                case OPS.OR:
                    _dataResult = _dataLop |_dataRop;
                    LblOperator.Text = "  |";
                    TxtResult.Text = string.Format("{0:X}", _dataResult.OperandI);
                    break;
                default:
                    MessageBox.Show("Unknown Overloaded Operator", "Unknown Operator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        /// <summary>
        /// Purpose: FrmMain load event handler
        /// </summary>
        /// <param name="sender">FrmMain Load Event</param>
        /// <param name="e">Not used</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            _dataLop = null;
            _dataRop = null;
            _operator = OPS.ADD;
        }
        /// <summary>
        /// Purpose: Close FrmMain on BtnExit Click
        /// </summary>
        /// <param name="sender">BtnExit Click</param>
        /// <param name="e">Not used</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Purpose: LBoxOperators Click Event Handler
        /// </summary>
        /// <param name="sender">LBoxOperators</param>
        /// <param name="e">Not used</param>
        private void LBoxOperators_SelectedIndexChanged(object sender, EventArgs e)
        {
            _operator = (OPS)(LBoxOperators.SelectedIndex);
            BtnCalc_Click(sender, e);
        }
        /// <summary>
        /// Purpose: TxtRightOperand KeyPress Event Handler
        /// </summary>
        /// <param name="sender">TxtRightOperand</param>
        /// <param name="e">Not used</param>
        private void TxtRightOperand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                BtnCalc_Click(sender, e);
            }
        }
        /// <summary>
        /// Purpose: BtnNonsense Click Event Handler
        /// </summary>
        /// <param name="sender">BtnNonsense</param>
        /// <param name="e">Not used</param>
        private void BtnNonsense_Click(object sender, EventArgs e)
        {
            TestInc();
        }
    }//End class FrmMain
    public class Data
    {
        private double _operandD;
        private int _operandI;
        private bool? _state;
        /// <summary>
        /// Purpose: Properties for _operandI, _operandD, _state
        /// </summary>
        public int OperandI
        {
            get { return _operandI; }
            set { _operandI = value; }
        }
        public bool? State
        {
            get { return _state; }
            set { _state = value; }
        }
        public double OperandD
        {
            get { return _operandD; }
            set { _operandD = value; }
        }
        /// <summary>
        /// Purpose: Default Constructor
        /// </summary>
        public Data()
        {
            _operandD = default(double);
            _operandI = default(int);
            _state = null;
        }
        /// <summary>
        /// Purpose: Parameterized Constructor
        /// </summary>
        /// <param name="op">op double</param>
        public Data(double op)
        {
            _operandD = op;
            _operandI = (int)op;
            _state = null;
        }
        /// <summary>
        /// Purpose: Parameterized Constructor
        /// </summary>
        /// <param name="op">op string</param>
        public Data(string op)
        {
            _operandD = (double.TryParse(op, out _operandD) ? _operandD : -1.0);
            _operandI = (int)_operandD;
            _state = null;
        }
        /// <summary>
        /// Purpose: + Positive Operator
        /// </summary>
        /// <param name="op">Unary Operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator + (Data op)
        {
            return new Data(+op.OperandD);
        }
        /// <summary>
        /// Purpose: - Negation Operator
        /// </summary>
        /// <param name="op">Unary Operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator - (Data op)
        {
            return new Data(-op.OperandD);
        }
        
        /// <summary>
        /// Purpose: + Addition Overloaded Operator
        /// </summary>
        /// <param name="lop">Left Operand</param>
        /// <param name="rop">Right Operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator + (Data lop, Data rop)
        {
            return new Data(lop._operandD + rop._operandD); 
        }
        /// <summary>
        /// Purpose: + Addition operator with left operand as double
        /// </summary>
        /// <param name="lop">Data object</param>
        /// <param name="rop">double right operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator + (Data lop, double rop)
        {
            return new Data(lop._operandD + rop); 
        }
        /// <summary>
        /// Purpose: + Addition operator
        /// </summary>
        /// <param name="lop">double left operand</param>
        /// <param name="rop">Data right operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator + (double lop, Data rop)
        {
            return new Data(lop + rop._operandD); 
        }
        //public static Data operator += (double rop) //automatically overloaded
        //{
        //    return new Data(lop + rop._operand); 
        //}
        /// <summary>
        /// Purpose: - Subtration operator
        /// </summary>
        /// <param name="lop">Data operand</param>
        /// <param name="rop">Data operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator - (Data lop, Data rop)
        {
            return new Data(lop._operandD - rop._operandD); 
        }
        /// <summary>
        /// Purpose: ++ Increment operator (both pre and post)
        /// </summary>
        /// <param name="op">Data operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator ++ (Data op)
        {
            Data temp = new Data();
            temp._operandD = op._operandD + 1;
            return temp; 
        }
        
        /// <summary>
        /// Purpose: -- Decrement overloaded operator (both pre and post)
        /// </summary>
        /// <param name="op">Data operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator -- (Data op)
        {
            Data temp = new Data();
            temp._operandD = op._operandD - 1;
            return temp; 
        }
        
        /// <summary>
        /// Purpose: * Multiplication overloaded operator
        /// </summary>
        /// <param name="lop">Data operand</param>
        /// <param name="rop">Data operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator * (Data lop, Data rop)
        {
            return new Data(lop._operandD * rop._operandD);
        }
        /// <summary>
        /// Purpose: / Division overloaded operator
        /// </summary>
        /// <param name="lop">Data operand</param>
        /// <param name="rop">Data operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator / (Data lop, Data rop)
        {
            return new Data(lop._operandD / rop._operandD);
        }
        /// <summary>
        /// Purpose: % Modulus overloaded operator (double & int)
        /// </summary>
        /// <param name="lop">Data operand</param>
        /// <param name="rop">Data operand</param>
        /// <returns>Data object reference</returns>
        public static Data operator % (Data lop, Data rop)
        {
            return new Data(lop._operandD % rop._operandD);
        }
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static Data operator % (Data lop, int rop)
        {
            return new Data(lop._operandI % rop);
        }
        
        /// <summary>
        /// Purpose: > Greater Than
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static bool operator > (Data lop, Data rop)
        {
            return (lop._operandD > rop._operandD);
        }
        /// <summary>
        /// Purpose: < Less Than
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static bool operator < (Data lop, Data rop)
        {
            return (lop._operandD < rop._operandD);
        }
        /// <summary>
        /// Purpose: >= Greater Than or Equal 
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static bool operator >= (Data lop, Data rop)
        {
            return (lop._operandD >= rop._operandD);
        }
        /// <summary>
        /// Purpose: <= Less Than or Equal 
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static bool operator <= (Data lop, Data rop)
        {
            return (lop._operandD <= rop._operandD);
        }
        /// <summary>
        /// Purpose: == Equal
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static bool operator == (Data lop, Data rop)
        {
            return (lop._operandD == rop._operandD);
        }
        //>>    Extraction
        public static Data operator >> (Data lop, int rop)
        {
            return new Data(lop._operandI >> rop);
        }
        
        /// <summary>
        /// Purpose: << Insertion
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static Data operator << (Data lop, int rop)
        {
            return new Data(lop._operandI << rop);
        }
        
        /// <summary>
        /// Purpose: != Not Equal 
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static bool operator != (Data lop, Data rop)
        {
            return (lop._operandD != rop._operandD);
        }
        
        /// <summary>
        /// Purpose: ! Not
        /// </summary>
        /// <param name="op"></param>
        /// <returns>Data object reference</returns>
        public static Data operator ! (Data op)
        {
            Data tempData = new Data();
            tempData.State = !(op.State ?? true);
            return tempData;
        }
        //public static Data operator??(Data lop, Data rop)  //cannot be overloaded
        //{
        //    return lop.TValue ?? rop.TValue; 
        //}

        //---------------------------------- Binary Bitwise Operators -----------------------------------
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="op"></param>
        /// <returns>Data object reference</returns>
        public static Data operator ~ (Data op)
        {
            return new Data(~op._operandI);
        }
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static Data operator & (Data lop, Data rop)
        {
            return new Data(lop._operandI & rop._operandI);
        }
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static Data operator | (Data lop, Data rop)
        {
            return new Data(lop._operandI | rop._operandI);
        }
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="lop"></param>
        /// <param name="rop"></param>
        /// <returns>Data object reference</returns>
        public static Data operator ^ (Data lop, Data rop)
        {
            return new Data(lop._operandI ^ rop._operandI);
        }
        //----------------------------------Conversion Operators -----------------------------------
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="op"></param>
        /// <returns>int data type</returns>
        public static explicit operator int (Data op)
        {
            return (op._operandD > 0.0) ? (int)(op._operandD) : 0;
        }
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="op"></param>
        /// <returns>double data type</returns>
        public static implicit operator double (Data op)
        {
            return (op._operandD >= 0.0) ? op._operandD : 0.0;
        }
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="op"></param>
        /// <returns>char data type</returns>
        public static implicit operator char (Data op)
        {
            return (char)op._operandD;
        }
        public static bool operator false (Data op)
        {
            return (op._operandD > 0.0) ? true : false;
        }
        /// <summary>
        /// Purpose: 
        /// </summary>
        /// <param name="op"></param>
        /// <returns>bool data type</returns>
        public static bool operator true (Data op)
        {
            return (op._operandD <= 0.0) ? false : true;
        }
    }
}//End namespace Operator_Overloading_01
