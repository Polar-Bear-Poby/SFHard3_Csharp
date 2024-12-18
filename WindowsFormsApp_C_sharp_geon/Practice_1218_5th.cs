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
    public partial class Practice_1218_5th : Form
    {
        public Practice_1218_5th()
        {
            InitializeComponent();
            textBox_result.Text = "241218 5교시" + "\r\n";


        }

        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_result.Text += "완료!";
        }

        private void Practice_1218_5th_Load(object sender, EventArgs e)
        {

        }
    }
}
