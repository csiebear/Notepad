using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
            ReturnTargetText = "";
        }

        private void FindButton_Click(object sender, EventArgs e)
        {

            if (TargetText.Text == "")
            {
                MessageBox.Show("請輸入需要尋找的文字\n不可為空白", "警告", MessageBoxButtons.OK);
            }
            else
            {
                ReturnTargetText = TargetText.Text.ToString();
                //MessageBox.Show(String.Format("{0}",ReturnTargetText), "需要查詢的字串", MessageBoxButtons.OK);
                MessageBox.Show(String.Format("{0}", TextBoxMsg), "搜尋結果", MessageBoxButtons.OK);
                Close();
            }
        }

        public string TextBoxMsg
        {
            set { ReturnTargetText = TargetText.Text.ToString();}
            get { return ReturnTargetText; }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
