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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox_print.Text = "241217 2교시";

            string[] submits = new string[10];
            string q1 = "동해 물과 백두산이";
            int q1_answer = q1.IndexOf("백두산");
            submits[0] = q1_answer.ToString();

            string q2 = "토요일에 먹는 토마토";
            int q2_answer = q2.LastIndexOf('토');
            submits[1] = q2_answer.ToString();

            string q3 = "질서있는 퇴장";
            string q3_answer = q3.Contains('퇴').ToString();
            submits[2] = q3_answer;

            string q4 = "그 사람의 그림자는 그랬다.";
            string q4_answer = q4.Replace("그", "이");
            submits[3] = q4_answer;

            string q5 = "삼성 갤럭시";
            string q5_answer = q5.Insert(3, "애플");
            submits[4] = q5_answer;

            string q6 = "오늘은 왠지 더 배고프다";
            string q6_answer = q6.Remove(7,1);
            submits[5] = q6_answer;

            string q7 = "이름,나이,전화번호";
            string[] q7_answer = q7.Split(',');
            submits[6] = q7_answer[0];
            submits[7] = q7_answer[1];
            submits[8] = q7_answer[2];

            string q8 = "우리 나라 만세";
            string q8_answer = q8.Substring(3, 2);
            submits[9] = q8_answer;

            textBox_print.Text = string.Join(",",submits);



        }
    }
}
