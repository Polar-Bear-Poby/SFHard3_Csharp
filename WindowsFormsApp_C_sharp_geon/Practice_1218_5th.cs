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
            

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_result.Text = textBox_input.Text;
        }
    }
}
