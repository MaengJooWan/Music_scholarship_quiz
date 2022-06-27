using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Threading;

namespace Music_scholarship_quiz
{
    public partial class Form1 : Form
    {
        bool play_result = false;
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File_Control file_Control = new File_Control();

            label1.Text = Convert.ToString(file_Control.file_count("1990년", "10점"));
            label2.Text = Convert.ToString(file_Control.file_count("2000년", "10점"));
            label3.Text = Convert.ToString(file_Control.file_count("2010년", "10점"));
            label4.Text = Convert.ToString(file_Control.file_count("2010년", "20점"));
            label5.Text = Convert.ToString(file_Control.file_count("2000년", "20점"));
            label6.Text = Convert.ToString(file_Control.file_count("1990년", "20점"));
            label7.Text = Convert.ToString(file_Control.file_count("2010년", "30점"));
            label8.Text = Convert.ToString(file_Control.file_count("2000년", "30점"));
            label9.Text = Convert.ToString(file_Control.file_count("1990년", "30점"));
            label10.Text = Convert.ToString(file_Control.file_count("2010년", "40점"));
            label11.Text = Convert.ToString(file_Control.file_count("2000년", "40점"));
            label12.Text = Convert.ToString(file_Control.file_count("1990년", "40점"));
            label13.Text = Convert.ToString(file_Control.file_count("2010년", "50점"));
            label14.Text = Convert.ToString(file_Control.file_count("2000년", "50점"));
            label15.Text = Convert.ToString(file_Control.file_count("1990년", "50점"));
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            File_Control file_Control = new File_Control();
            Music_Condition music_Condition = new Music_Condition();
            string year = "";
            string score = "";
            string[] file_list = { };
            string path = "";
            int rand_count = 0;
            //랜덤함수
            Random rand = new Random();
            //음악 재생 클래스
            
            //재생이 되지 않는 상황이라면
            if(play_result == false)
            {
                //연도 클릭된 값 가지고 오기
                year = groupBox6.Controls.OfType<RadioButton>().First(p => p.Checked).Text;
                //점수 클릭된 값 가지고 오기
                score = groupBox7.Controls.OfType<RadioButton>().First(p => p.Checked).Text;
                //파일 목록 가지고 오기
                file_list = file_Control.file_list(year, score);
                //음악랜덤 돌리기
                rand_count = rand.Next(file_list.Length);
                //랜덤 돌린 값 중 음악 뽑아 내기
                path = file_list[rand_count].ToString();
                //음악 이동
                path = file_Control.file_move(path);
                //Keyword
                label16.Text = music_Condition.Condition(path);
                //다른음악 재생 방지
                play_result = true;
                //음악 경로
                wmp.URL = path;
                //3초 지연
                Thread.Sleep(2000);
            }



            //음악재생
            wmp.controls.play();

            //음악 재생 후 표지판에 음악 Count
            label1.Text = Convert.ToString(file_Control.file_count("1990년", "10점"));
            label2.Text = Convert.ToString(file_Control.file_count("2000년", "10점"));
            label3.Text = Convert.ToString(file_Control.file_count("2010년", "10점"));
            label4.Text = Convert.ToString(file_Control.file_count("2010년", "20점"));
            label5.Text = Convert.ToString(file_Control.file_count("2000년", "20점"));
            label6.Text = Convert.ToString(file_Control.file_count("1990년", "20점"));
            label7.Text = Convert.ToString(file_Control.file_count("2010년", "30점"));
            label8.Text = Convert.ToString(file_Control.file_count("2000년", "30점"));
            label9.Text = Convert.ToString(file_Control.file_count("1990년", "30점"));
            label10.Text = Convert.ToString(file_Control.file_count("2010년", "40점"));
            label11.Text = Convert.ToString(file_Control.file_count("2000년", "40점"));
            label12.Text = Convert.ToString(file_Control.file_count("1990년", "40점"));
            label13.Text = Convert.ToString(file_Control.file_count("2010년", "50점"));
            label14.Text = Convert.ToString(file_Control.file_count("2000년", "50점"));
            label15.Text = Convert.ToString(file_Control.file_count("1990년", "50점"));


        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            play_result = false;
            wmp.controls.stop();
        }
    }
}
