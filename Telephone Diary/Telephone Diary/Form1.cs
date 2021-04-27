using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Telephone_diary
{
    public partial class Form1 : Form
    {
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

        }
    }
}


// TabIndex를 사용하는 이유: Tab버튼을 눌렀을 때 다음 요소 선택되도록.