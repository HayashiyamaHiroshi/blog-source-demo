using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewWithDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getDataTable();

            // 列名を自由に変更する。
            var col = dataGridView1.Columns["ID"];
            col.HeaderText = "コード";
            //dataGridView1.DataSource = GetUsers().ToList();
        }

        private DataTable getDataTable()
        {
            var dt = new DataTable();
            var idCol = dt.Columns.Add("ID");
            var nameCol = dt.Columns.Add("氏名");
            var ageCol = dt.Columns.Add("年齢");
            var addressCol = dt.Columns.Add("住所");

            var newRow = dt.NewRow();
            newRow.SetField(idCol,1);
            newRow.SetField(nameCol, "鈴木　おさむ");
            newRow.SetField(ageCol, 22);
            newRow.SetField(addressCol, "東京都世田谷区");
            dt.Rows.Add(newRow);

            var newRow2 = dt.NewRow();
            newRow2.SetField(idCol, 2);
            newRow2.SetField(nameCol, "高橋　つよし");
            newRow2.SetField(ageCol, 25);
            newRow2.SetField(addressCol, "東京都葛飾区");
            dt.Rows.Add(newRow2);

            return dt;
        }

        private IEnumerable<User> GetUsers()
        {
            var user1 = new User(1, "鈴木　おさむ",22, "東京都世田谷区");
            var user2 = new User(2, "高橋　つよし",25, "東京都葛飾区");

            return new List<User>()
            {
                user1,user2
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = (DataTable)dataGridView1.DataSource;
            var newDt = data.Copy();

            dataGridView2.DataSource = newDt;
        }
    }
}
