using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex; // CurrentCeil 프로퍼티가 사용자가 선택한 row인 듯.

            if(index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

    }
}
