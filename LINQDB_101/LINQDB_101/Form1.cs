using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LINQDB_101
{
    public partial class Form1 : Form
    {
        string _FileType;
        public Form1()
        {
            InitializeComponent();
        }

        private void mediaTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            //this.employeeTableAdapter.UpdateAll(this.hPMediaDBDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.testDataSet.Employee);
            // TODO: This line of code loads data into the 'hPMediaDBDataSet.MediaTB' table. You can move, or remove it, as needed.
            comboBox1.SelectedIndex = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            string selectStatement = "<none>";
            SqlCommand selectCommand = null;
            SqlConnection dbConnection = null;
            DataTable dtNames = null;
            SqlDataAdapter sdaNames = null;
            BindingSource sbsNames = null;
            string connectStr = @"Data Source=localhost;Initial Catalog=Test;Integrated Security=true;";
            dbConnection = new SqlConnection(connectStr);
            if (dbConnection.State == ConnectionState.Closed)
                dbConnection.Open();
            selectStatement = "SELECT * FROM Employee";
            selectCommand = new SqlCommand(selectStatement, dbConnection);
            dtNames = new DataTable();
            sdaNames = new SqlDataAdapter(selectCommand);
            sdaNames.Fill(dtNames);                       //Fill Datatable from DataAdapter
            sbsNames = new BindingSource();
            switch(comboBox1.Text)
            {
                case "Filter Names":
                      var parRowsN  = from ex in dtNames.AsEnumerable()
                         where ((ex.Field<string>("LName"))??"null") == "Dwarf" || ((ex.Field<string>("LName"))??"null").StartsWith("W")
                              orderby ex.Field<string>("LName"), ex.Field<string>("FName")
                                     select ex;
                      employeeBindingSource.DataSource = parRowsN.AsDataView<DataRow>();
                    break;
                case "Filter Employee ID":
                      var parRowsI  = from ex in dtNames.AsEnumerable()
                         where ex.Field<int>("EmpID") >= 1003
                              orderby ex.Field<int>("EmpID")
                                     select ex;
                      employeeBindingSource.DataSource = parRowsI.AsDataView<DataRow>();
                    break;
                case "Filter Salary":
                      var parRowsS  = from ex in dtNames.AsEnumerable()
                         where ex.Field<decimal?>("Salary") >= 100000.00M
                              orderby ex.Field<decimal>("Salary")
                                     select ex;
                      employeeBindingSource.DataSource = parRowsS.AsDataView<DataRow>();
                    break;
                case "Filter Benefits":
                      var parRowsB  = from ex in dtNames.AsEnumerable()
                         where ((ex.Field<string>("Benefits"))??"null") == "Y"
                              orderby ex.Field<int>("EmpID")
                                     select ex;
                      employeeBindingSource.DataSource = parRowsB.AsDataView<DataRow>();
                    break;
                case "Filter Description":
                      var parRowsD  = from ex in dtNames.AsEnumerable()
                         where ((ex.Field<string>("Description"))??"null").Contains("S")||((ex.Field<string>("Description"))??"null").Contains("null")
                              orderby ex.Field<int>("EmpID")
                                     select ex;
                      employeeBindingSource.DataSource = parRowsD.AsDataView<DataRow>();
                    break;
                case "<none>":
                      var parRowsNo  = from ex in dtNames.AsEnumerable()
                              orderby ex.Field<int>("EmpID")
                                     select ex;
                      employeeBindingSource.DataSource = parRowsNo.AsDataView<DataRow>();
                    break;
                default:
                    MessageBox.Show("Invalid Filter Type", "Invalid");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = (string)comboBox1.Items[comboBox1.SelectedIndex];
            BtnProcess_Click(sender, e);
        }
    }
}
