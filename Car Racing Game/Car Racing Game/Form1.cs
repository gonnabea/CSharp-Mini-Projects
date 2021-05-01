using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gamespeed = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
        }

        void moveline(int speed)
        {
            // 직진하고 있는 것 같은 효과를 주기 위한 차선 애니메이션
            if(pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }

            if (pictureBox8.Top >= 500)
            {
                pictureBox8.Top = 0;
            }
            else
            {
                pictureBox8.Top += speed;
            }

        }
        
        // 자동차 이동 구현
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(car.Left > 10) // 자동차 왼쪽 이동 한계 범위 설정
                car.Left += - 8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Left < 690) // 자동차 오른쪽 이동 한계 범위 설정
                    car.Left += 8;
            }

            // 위쪽 방향키를 눌렀을 때 자동차 속도 증가
            if(e.KeyCode==Keys.Up)
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            // 아랫쪽 방향키를 눌렀을 때 자동차 속도 감소
            if(e.KeyCode==Keys.Down)
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
