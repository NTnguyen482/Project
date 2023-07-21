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
    public partial class CombineAndConvert : Form
    {
        List<string> selectedFiles = new List<string>();
        public CombineAndConvert()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MS(*.doc)|*.doc|MS Word(*.docx)|*.docx|PDF file(*.pdf)|*.pdf|All Files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    if (!selectedFiles.Contains(file))
                        selectedFiles.Add(file);
                }

                UpdateSelectedFilesList();
            }
        }

        private void Combine1_Click(object sender, EventArgs e)
        {
            try
            {
                var output = new Document();
                // Remove all content from the destination document before appending.
                output.RemoveAllChildren();

                foreach (string fileName in selectedFiles)
                {
                    var input = new Document(fileName);
                    // Append the source document to the end of the destination document.
                    output.AppendDocument(input, ImportFormatMode.KeepSourceFormatting);
                }
                output.Save("Result.Docx");
                if (File.Exists("Result.docx"))
                {
                    MessageBox.Show("congrats. Convert Successfully.", "Success");
                    Process.Start("Result.docx");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Message: " + ex.Message);
            }
        }
        private void Combine2_Click(object sender, EventArgs e)
        {
            try
            {
                var output = new Document();
                // Remove all content from the destination document before appending.
                output.RemoveAllChildren();

                foreach (string fileName in selectedFiles)
                {
                    var input = new Document(fileName);
                    // Append the source document to the end of the destination document.
                    output.AppendDocument(input, ImportFormatMode.KeepSourceFormatting);
                }
                output.Save("Result.pdf");
                if (File.Exists("Result.pdf"))
                {
                    MessageBox.Show("congrats. Convert Successfully.", "Success");
                    Process.Start("Result.pdf");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Message: " + ex.Message);
            }
        }
        private void UpdateSelectedFilesList()
        {
            listBox1.Items.Clear();
            foreach (string file in selectedFiles)
            {
                listBox1.Items.Add(Path.GetFileName(file));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
