using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MatrixCalcWFApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a11_s = textBox1.Text;
            string a12_s = textBox2.Text;
            string a21_s = textBox3.Text;
            string a22_s = textBox4.Text;

            int a11 = 0; int a12 = 0; int a21 = 0; int a22 = 0; int Det = 0;

            try
            {
                a11 = Convert.ToInt32(a11_s);
                a12 = Convert.ToInt32(a12_s);
                a21 = Convert.ToInt32(a21_s);
                a22 = Convert.ToInt32(a22_s);
                Det = (a11 * a22) - (a12 * a21);
                textBox5.Text = Det.ToString();
                textBox6.Text = "Succesfully calculated!";
            }
            catch 
            {
                textBox6.Text = "Check the field`s format!";
                
            }            

            
        }
    }
}
