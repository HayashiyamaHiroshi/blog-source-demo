using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInForm
{
    public partial class MainForm : Form
    {
        private Form form1;
        private Form form2;
        private Form form3;

        private IEnumerable<Form> _subForms;
        private IEnumerable<Button> _formButtons;

        private Color _activeColor = Color.Aquamarine;
        private Color _defaultColor = Color.CadetBlue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.TopLevel = false;
            form1.Dock = DockStyle.Fill;
            panel2.Controls.Add(form1);

            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            panel2.Controls.Add(form2);

            form3 = new Form3();
            form3.TopLevel = false;
            form3.Dock = DockStyle.Fill;
            panel2.Controls.Add(form3);

            // ここでフィールドのリストを作る
            _subForms = new List<Form>()
            {
                form1,form2,form3
            };

            // ここでフィールドのリストを作る
            _formButtons = new List<Button>()
            {
                button1,button2,button3
            };

            ShowForm(form1);
            ActivateBtn(button1);

            button1.BackColor = _activeColor;
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm(form1);
            ActivateBtn((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowForm(form2);
            ActivateBtn((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForm(form3);
            ActivateBtn((Button)sender);
        }

        private void ShowForm(Form form)
        {
            // subFormの配列をぶん回して引数のFormと一致してたら表示して、
            // 一致してなかったら隠す
            foreach (var f in _subForms)
            {
                if (f == form)
                {
                    f.Show();
                }
                else
                {
                    f.Hide();
                }
            }
        }

        private void ActivateBtn(Button btn)
        {
            // form表示するボタンのリストをぶん回して、
            // 引数のボタンを一致してたらactiveColorにして、
            // 一致してなかったらdefaultColorにする
            foreach (var b in _formButtons)
            {
                b.BackColor = b == btn ? _activeColor : _defaultColor;
            }
        }
    }
}
