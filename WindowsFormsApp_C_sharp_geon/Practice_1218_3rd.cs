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
    public partial class Practice_1218_3rd : Form
    {
        public Practice_1218_3rd()
        {
            InitializeComponent();
            Practice_1218_3rd_print.Text = "241218 3교시" + "\r\n";

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

            bool result_practice_1218_3rd = Show_result_flip_coin(true);
            if (result_practice_1218_3rd == true)
            {
                Practice_1218_3rd_print.Text += "승리";
            }
            else
            {
                Practice_1218_3rd_print.Text += "패배";
            }
        }
    }
}
