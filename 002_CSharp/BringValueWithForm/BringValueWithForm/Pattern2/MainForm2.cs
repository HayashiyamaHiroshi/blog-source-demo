using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BringValueWithForm.Pattern2
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new SubForm2();
            form.ShowDialog();

            // ここでform1が閉じられたら
            label1.Text = $@"SubFormから{form.TextBox1Str}の値が渡ってきました。";
        }
    }
}
