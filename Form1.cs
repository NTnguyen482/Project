using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wordtopdf wordtopdf = new Wordtopdf();
            wordtopdf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDFtoWord pdftoword = new PDFtoWord();
            pdftoword.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreatingWordDocument document = new CreatingWordDocument();
            document.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CombineAndConvert combineAndConvert = new CombineAndConvert();
            combineAndConvert.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CombineDocx combineDocx = new CombineDocx();
            combineDocx.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SplitPDF splitPDF = new SplitPDF();
            splitPDF.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SplitDocx splitDocx = new SplitDocx();
            splitDocx.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CombinePDF combinePDF = new CombinePDF();
            combinePDF.Show();
        }
    }
}
