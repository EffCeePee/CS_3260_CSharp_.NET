using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileStreaming
{
    public partial class Form1 : Form
    {
        FileIO _fileIO;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _fileIO = new FileIO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fileIO.OpenDB();
            _fileIO.SerializeFile();
            _fileIO.deserializeFile();
        }

    }

    class FileIO
    {
        private FileStream _fs;
        private BinaryFormatter _bf;
       
        public void OpenDB()
        { 
            string _filePath = null;
            SaveFileDialog _saveDlg = new SaveFileDialog();
            _saveDlg.Filter = "All Files *.*|*.*|Text Files *.txt|*.txt|Binary File *.bin|*.bin|Serialzed File *.ser|*.ser";
            _saveDlg.FilterIndex = 1;
            _saveDlg.ShowDialog();
            _filePath = _saveDlg.FileName;
            _fs = new FileStream(_filePath, FileMode.Create, FileAccess.ReadWrite);
            //_fs.Close();
        }

        public void SerializeFile()
        {
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, "Hello World");
            _bf.Serialize(_fs, 80085);
            _bf.Serialize(_fs, 135.11);
            _bf.Serialize(_fs, '&');
            _bf.Serialize(_fs, true);
            _fs.Flush();
        }

        public void deserializeFile()
        {
            _fs.Seek(0, SeekOrigin.Begin);
            string stg = (string)(_bf.Deserialize(_fs));  // need to cast the reference to the object type.
            int ival = (int)(_bf.Deserialize(_fs));
            double dval =(double)(_bf.Deserialize(_fs));
            char cval = (char)(_bf.Deserialize(_fs));
            bool bval = (bool)(_bf.Deserialize(_fs));
        }
      

    }

}
