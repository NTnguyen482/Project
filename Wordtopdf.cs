using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using System.IO;
using System.Diagnostics;

namespace project2
{
    public partial class Wordtopdf : Form
    {
        public Wordtopdf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "MS(*.doc)|*.doc|MS Word(*.docx)|*.docx|All Files(*.*)|*.*";
                DialogResult openResult = openFileDialog.ShowDialog();
                if (openResult == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    textBox1.Text = path;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Message: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var kq = new Document(textBox1.Text); 
                kq.Save("Result.pdf");
                if (File.Exists("Result.pdf"))
                {
                    MessageBox.Show("congrats. PDF file is Saved Successfully.", "Success");
                    Process.Start("Result.pdf");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Message: " + ex.Message);
            }
        }
    }
}
