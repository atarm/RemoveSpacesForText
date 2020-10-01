using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleateSpaceForText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {
            string prevText = richTextBox1.Text;
            string rgx = @"https?://(?:[!-~]+\.)+[!-~]+";
            richTextBox2.Text = Regex.Replace(prevText, rgx, String.Empty) // 以下のようにReplaceは複数指定可能
                .Replace("\n", String.Empty)
                .Replace(".", String.Empty)
                .Replace("(", String.Empty)
                .Replace(")", String.Empty)
                .Replace("―", String.Empty)
                .Replace("-", String.Empty)
                .Replace("├", String.Empty)
                .Replace(" ", String.Empty)
                .Replace("　", String.Empty)
                .Replace("└", String.Empty)
                .Replace("|",String.Empty)
                .Replace("･",String.Empty)
                .Replace("・",String.Empty)
                .Replace("…",String.Empty)
                .Replace("[ー]{2,}", "ー")
                .Replace("♪", "。")
                .Replace("/",String.Empty)
                .Replace(":",String.Empty);
            Clipboard.SetText(prevText.Replace(",","\n"));
        }
    }
}
