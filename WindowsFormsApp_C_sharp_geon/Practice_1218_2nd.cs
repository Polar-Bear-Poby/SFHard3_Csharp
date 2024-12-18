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
    public partial class Practice_1218_2nd : Form
    {
        public Practice_1218_2nd()
        {
            InitializeComponent();
            Practice_1218_2nd_print.Text = "241218 2교시" + "\r\n";

            //PER 공식 = 현재 주가 / BPS
            int[] Calculate_PER(int current_stock_price, int BPS)
            {
                int [] result = new int[2];
                result[0] = current_stock_price / BPS;
                result[1] = current_stock_price % BPS;

                return result;

            }
            //삼성전자의 PER
            int[] samsung_per = Calculate_PER(55200, 3310);
            Practice_1218_2nd_print.Text += string.Join(", ", samsung_per) +"\r\n";
            Practice_1218_2nd_print.Text += "삼성전자 PER: " + samsung_per[0].ToString();


        }
    }
}
