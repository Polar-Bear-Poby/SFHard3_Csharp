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
    public partial class Practice_1220_2nd : Form
    {
        public Practice_1220_2nd()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
        
            string input_text = textBox_input.Text;
        
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

    }
}
