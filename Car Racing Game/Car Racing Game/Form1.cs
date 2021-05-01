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
            gameOverText.Visible = false;

        }

        int gamespeed = 0;
        // 반복 실행되는 로직
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
        }

        Random random = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                enemy1.Top = 0;
            }else
            {
                enemy1.Top += speed;
            }

            if (enemy1.Top >= 500)
            {
                // 차가 화면 밖으로 벗어났을 때 랜덤 위치에서 재생성
                x = random.Next(0, 200);


                enemy1.Location = new Point(x, 0);
            }
            else
            {
                // enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                // 차가 화면 밖으로 벗어났을 때 랜덤 위치에서 재생성
                x = random.Next(200, 400);


                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                // 차가 화면 밖으로 벗어났을 때 랜덤 위치에서 재생성
                x = random.Next(400, 800);


                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void gameover()
        {
            // 적 자동차와 부딪혔을 때
            if (car.Bounds.IntersectsWith(enemy1.Bounds) || car.Bounds.IntersectsWith(enemy2.Bounds) || car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                gameOverText.Visible = true;
            }
        }

        // 직진하고 있는 것 같은 효과를 주기 위한 차선 애니메이션
        void moveline(int speed)
        {
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
