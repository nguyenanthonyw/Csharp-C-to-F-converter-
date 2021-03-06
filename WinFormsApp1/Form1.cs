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


        /*
         * This will take number from text box and used to compute the conversion
         * 
         */
        private void btn_Click(object sender, EventArgs e)
        {




            /*
             * This creates a dialog box if the user has both text boxes filled out 
             * and the system can't determine which on to use.
             * 
             */
            if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Clear Screen");
            }



            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                double A, result;
                //A = 1.8 * Double.Parse(textBox2.Text) + 32;

                result = Class1.calcF(Double.Parse(textBox2.Text));


                textBox1.Text = Convert.ToString(result);
            }



            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                double A, result;
                //A = 1.8 * Double.Parse(textBox2.Text) + 32;

                result = Class1.calcC(Double.Parse(textBox1.Text));


                textBox2.Text = Convert.ToString(result);
            }



        }
    }
}
