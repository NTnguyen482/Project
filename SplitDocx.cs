using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using System.IO;


namespace project2
{
    public partial class SplitDocx : Form
    {
        public SplitDocx()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MS(*.doc)|*.doc|MS Word(*.docx)|*.docx|All Files(*.*)|*.*";
                DialogResult openResult = ofd.ShowDialog();
                if (openResult == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    textBox1.Text = path;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Message: " + ex.Message);
            }
        }

        private void Meger_Click(object sender, EventArgs e)
        {
            try
            {
                var doc = new Document(textBox1.Text);
                int dem = 1;
                for (int i = 0; i < doc.PageCount; i++)
                {
                    // Split a document into smaller parts, in this instance split by section
                    var extractedPage = doc.ExtractPages(i, 1);
                    extractedPage.Save("page_" + i + "_out" + ".docx");
                    dem ++;
                    if (File.Exists("page_" + i + "_out" + ".docx"))
                    {
                        MessageBox.Show("Docx Split successfully", "successfull");
                        Process.Start("page_" + i + "_out" + ".docx");
                    }
                }
            }
            catch (Exception ex) 
            { 
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}

