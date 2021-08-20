using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
         * This will take number from text box and used to compute the conversion
         * 
         */
        private void btn_Click(object sender, EventArgs e)
        {


            double A;

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                A = 1.8 * Double.Parse(textBox2.Text) + 32;
                textBox1.Text = Convert.ToString(A);
            }



            double F = Double.Parse(textBox1.Text);
            double Y = F - 32;
            double C =  Y * 1.8;


            textBox2.Text = Convert.ToString(C);

        }
    }
}
