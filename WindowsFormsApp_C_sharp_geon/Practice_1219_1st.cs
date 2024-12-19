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
    public partial class Practice_1219_1st : Form
    {
        public Practice_1219_1st()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {

            string input_text = textBox_input.Text;

            if (bool.Parse(input_text) == true || bool.Parse(input_text) == false)
            {
                bool target = bool.Parse(input_text);
                bool result_practice_1219_1st = Show_result_flip_coin(target);

                string game_result;
                if (result_practice_1219_1st == true)
                {
                    game_result = "승리했습니다!";
                }
                else
                {
                    game_result = "패배했습니다!";
                }
                
                textBox_result.Text = "target을 " + target.ToString() + "로 설정한 동전 던지기 결과 \r\n"
                    + game_result;
            }
            else
            {
                textBox_result.Text = textBox_input.Text + "는 입력값이 아닙니다.\r\n"
                    + "true 나 false 중 하나를 입력 혹은 선택하세요";
            }
        }

        private void radioButton_True_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_True.Checked)
            {
                textBox_input.Text = "true";
            }
            
        }

        private void radioButton_False_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_False.Checked)
            {
                textBox_input.Text = "false";
            }

        }
        bool Show_result_flip_coin(bool target)
        {
            int int_target = Convert.ToInt32(target);
            Random make_random = new Random();
            int random_number = make_random.Next();
            int remainder = random_number % 2;

            bool result = false;

            if (remainder == int_target)
            {
                result = true;
            }
            return result;
        }

    }
}
