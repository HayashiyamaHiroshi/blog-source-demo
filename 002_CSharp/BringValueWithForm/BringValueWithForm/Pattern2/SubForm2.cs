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
    public partial class SubForm2 : Form
    {
        public string TextBox1Str { get; private set; } = "";
        public SubForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1Str = textBox1.Text;
            this.Close();
        }
    }
}
