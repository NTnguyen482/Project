using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using System.IO;
using System.Diagnostics;

namespace project2
{
    public partial class PDFtoWord : Form
    {
        public PDFtoWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF file(*.pdf)|*.pdf|All Files(*.*)|*.*";
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
                var kq = new PdfDocument(textBox1.Text);
                kq.SaveToFile("Result.docx", FileFormat.DOCX);
                if (File.Exists("Result.docx"))
                {
                    MessageBox.Show("congrats. Docx file is Saved Successfully.", "Success");
                    Process.Start("Result.docx");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Message: " + ex.Message);
            }
        }
    }
}
