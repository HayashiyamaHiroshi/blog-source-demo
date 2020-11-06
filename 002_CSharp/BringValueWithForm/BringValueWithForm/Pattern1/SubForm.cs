using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BringValueWithForm.Pattern1
{
    public partial class SubForm : Form
    {
        private string _str;
        public SubForm(string str)
        {
            InitializeComponent();
            _str = str;
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            label1.Text = $@"MainFormから{_str}の値が来ました。";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
