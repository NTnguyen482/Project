using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.Diagnostics;


namespace project2
{
    public partial class CreatingWordDocument : Form
    {
        public CreatingWordDocument()
        {
            InitializeComponent();
        }
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +@"/Result.docx";
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                string userMessage = textBox1.Text;
                DocX kq = DocX.Create(path);
                kq.InsertParagraph(userMessage);
                kq.Save();
                Process.Start("Winword.exe", path);
            }    
            else
            {
                MessageBox.Show("Text box is Empty\nPlease type you message...", "Empty");
            }    
        }

        private void reset(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
