using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// 직접 패키지를 설치해야 함
// https://stackoverflow.com/questions/41315727/how-to-connect-with-sql-server-database-using-net-core-class-library-net-stan
using System.Data.SqlClient;




namespace Telephone_diary
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Phone;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox5;
            textBox5.Focus(); // 프로그램 실행 시 포커스 되어있게.
            Display(); // 실행 시 Query All
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Clear();
            textBox7.Text = "";
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.SelectedIndex = -1;
            textBox5.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Mobiles
            (First, Last, Mobile, Email, Category)
            VALUES ('" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("SuccessFully Saved...!");
            Display();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

 

        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Mobiles", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["First"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           textBox7.Text =  dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           textBox8.Text =  dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           textBox9.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           comboBox1.Text =  dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Mobiles
            WHERE (Mobile = '" + textBox8.Text + "')", con); // 유니크 키가 Mobile이기 때문에 WHERE Mobile을 사용(?) 
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("SuccessFully Deleted...!");
            Display();
        }
    }
}


// TabIndex를 사용하는 이유: Tab버튼을 눌렀을 때 다음 요소 선택되도록.