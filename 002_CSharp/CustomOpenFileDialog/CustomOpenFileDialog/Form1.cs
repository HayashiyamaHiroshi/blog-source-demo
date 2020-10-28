using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomOpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cofd = new CustomOpenFileDialog(FilterType.CSV);
            if (cofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = cofd.FileName;
            } 
        }
    }
}
