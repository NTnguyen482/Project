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
using System.Diagnostics;
using Aspose.Pdf;

namespace project2
{
    public partial class SplitPDF : Form
    {
        public SplitPDF()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF file(*.pdf)|*.pdf|All Files(*.*)|*.*";
                DialogResult openResult = ofd.ShowDialog();
                if (openResult == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    textBox2.Text = path;
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
                var kq = new Document(textBox2.Text);
                int pageCount = 1;
                // Loop through all the pages
                foreach (Aspose.Pdf.Page pdfPage in kq.Pages)
                {
                    // Create a new document
                    Document newDocument = new Document();

                    // Add page to the document
                    newDocument.Pages.Add(pdfPage);

                    // Save as PDF 
                    newDocument.Save("page_" + pageCount + "_out" + ".pdf");
                    pageCount++;
                    if (File.Exists("page_" + pageCount + "_out" + ".pdf"))
                    {
                        MessageBox.Show("PDF Split successfully", "successfull");
                        Process.Start("page_" + pageCount + "_out" + ".pdf");
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
