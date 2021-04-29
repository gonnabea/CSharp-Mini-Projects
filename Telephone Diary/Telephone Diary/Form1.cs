﻿using System;
using System.Windows.Forms;

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
        }
    }
}


// TabIndex를 사용하는 이유: Tab버튼을 눌렀을 때 다음 요소 선택되도록.