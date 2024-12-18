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
    public partial class Form4 : Form
    {
        public Form4()
        {
                InitializeComponent();
                textBox4_print.Text = "241217 5교시" + "\r\n";
                string homework5_words = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
                int index_special_char = homework5_words.IndexOf("-");
                string q1_answer = homework5_words.Remove(index_special_char, 3);
                textBox4_print.Text += "q1_answer: " + q1_answer + "\r\n";

                int index_last_num = q1_answer.LastIndexOf("는");
                string q2_words = q1_answer.Remove(index_last_num, 1);
                string[] split_q2_nun_delete = q2_words.Split(' ');
                string[] q2_answer = split_q2_nun_delete.Skip(3).Take(3).ToArray();
                // 파이썬 q2_answer = split_q2_nun_delete[3:6]과 같은 것
                textBox4_print.Text += "q2_answer: " + string.Join(" ", q2_answer) + "\r\n";

                int index_dot = q2_words.IndexOf(".");
                string q3_words = q2_words.Remove(index_dot, 1);
                string q3_answer = q3_words.Replace(" ", ",");
                textBox4_print.Text += "q3_answer: " + q3_answer;




        }
    }
}
