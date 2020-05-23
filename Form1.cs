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

namespace WriteLineExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile; // create the output stream
            string filename = "WriteLineExample output.txt";
            outputFile = File.CreateText(filename); // create empty file 
            // add three lines of text
            outputFile.WriteLine("first line of text");
            outputFile.WriteLine("second line of text");
            outputFile.WriteLine("third line of text");
            // close the stream/file, ensuring all data will be saved in the file
            outputFile.Close();
            MessageBox.Show("File \""  + filename + "\" created containing three lines.");
        }
    }
}
