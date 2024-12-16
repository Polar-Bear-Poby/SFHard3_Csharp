using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_C_sharp_geon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_print.Text = "241216 3교시";
            byte days_of_80 = 81;
            // 80일 세계 일주 실제 시간
            short sfhard_training_session = 6;
            // 오늘 교육 차수
            int soldiers_of_spartans = 300;
            // 영화 300에 나온 스파트타 군대 수
            float my_height = 180.6f;
            // 나의 키
            double korean_war_deaths = 3000000;
            //한국 전쟁 때 사망자 수
            decimal us_national_debt = 33000000000000;

            textBox_print.Text = days_of_80.GetType().ToString() + " days_of_80: " + days_of_80 + "\r\n";
            textBox_print.Text += sfhard_training_session.GetType().ToString() + " sfhard_training_session: " + sfhard_training_session + "\r\n";
            textBox_print.Text += soldiers_of_spartans.GetType().ToString() + " soldiers_of_spartans: " + soldiers_of_spartans + "\r\n";
            textBox_print.Text += my_height.GetType().ToString() + " my_height: " + my_height + "\r\n";
            textBox_print.Text += korean_war_deaths.GetType().ToString() + " korean_war_deaths: " + korean_war_deaths + "\r\n";
            textBox_print.Text += us_national_debt.GetType().ToString() + " us_national_debt: " + us_national_debt + "\r\n";


        }
    }
}
