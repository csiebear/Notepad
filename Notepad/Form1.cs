using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for read the user Input stream
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //讓Richtextbox 充滿整個視窗
            richTextBox1.Dock =DockStyle.Fill;
        }


        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_11_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem_16_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void ToolStripMenuItem_17_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_12_Click(object sender, EventArgs e)
        {
            //First we drop the openFileDiaglog into the Form1.cs(form desinger bottom)
            //If user Click the Open file Button and then show it up to screen
            // Displays an OpenFileDialog so the user can select a txt file.
            //reference the https://msdn.microsoft.com/zh-tw/library/61097ykx(v=vs.110).aspx
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文字檔(*.txt) | *.txt";
            openFileDialog1.Title = "開啟舊檔";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .txt file was selected, open it.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Because we may read the chinese word so we solve the encoding problem
                //reference the http://ithelp.ithome.com.tw/articles/10030801
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName,System.Text.Encoding.Default);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void ToolStripMenuItem_13_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "新記事本檔案.txt";
            saveFileDialog1.Filter = "Text File | *.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                writer.WriteLine(richTextBox1.Text);
                writer.Dispose();
                writer.Close();
            }
        }
    }
}
