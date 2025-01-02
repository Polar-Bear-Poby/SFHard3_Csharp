using System;
using System.Windows.Forms;

namespace WindowsFormsApp_C_sharp_geon
{
    public partial class Practice_0102 : Form
    {
        public Practice_0102()
        {
            InitializeComponent();

            ExecutePractice();
        }

        public void ExecutePractice()
        {

            int[] array_ref = new int[5];
            fillarraywithref(ref array_ref);
            Console.WriteLine("Ref Result");
            foreach (int item in array_ref)
            {
                Console.WriteLine(item);
            }

            int[] array_out;
            fillarraywithout(5, out array_out);
            Console.WriteLine("Out Result");
            foreach (int item in array_out)
            {
                Console.WriteLine(item);
            }
            
        }
        public void fillarraywithref(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }
        }
         
        public void fillarraywithout(int size, out int[] array)
        {
            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }
        }


    }
}