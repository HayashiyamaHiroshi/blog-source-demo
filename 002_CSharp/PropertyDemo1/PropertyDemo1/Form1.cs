using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyDemo1
{
    public partial class Form1 : Form
    {
        private IEnumerable<User> _users;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _users = new List<User>()
            {
                new User(20,1,"杉山","東京都")
                ,new User(30,2,"山田","愛知県")
                ,new User(25,3,"鈴木","秋田県")
            };
            dataGridView1.DataSource = _users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.xml");
            new XmlHelper<List<User>>(path).Save(_users.ToList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var props = typeof(User).GetProperties();

            var str = new StringBuilder();
            foreach (var user in _users)
            {
                foreach (var prop in props)
                {
                    str.Append($@"{prop.Name} : {prop.GetValue(user)}");
                    str.Append(Environment.NewLine);
                }
            }

            MessageBox.Show(str.ToString());

        }
    }
}
