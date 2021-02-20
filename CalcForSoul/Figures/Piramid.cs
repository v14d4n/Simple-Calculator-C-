using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForSoul
{
    public partial class Piramid : Form
    {
        public Piramid()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void rasch1Button_Click(object sender, EventArgs e)
        {
            try
            {
                string str_temp = this.textBox1.Text; string str_temp2 = this.textBox2.Text; 
                double dbl_temp = Convert.ToDouble(str_temp); double dbl_temp2 = Convert.ToDouble(str_temp2);
                this.textBox4.Text = Convert.ToString((dbl_temp / 3) * dbl_temp2);
            }
            catch 
            {
                this.textBox4.Text = "ERROR";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str_temp = this.textBox8.Text; string str_temp2 = this.textBox7.Text; 
                double dbl_temp = Convert.ToDouble(str_temp); double dbl_temp2 = Convert.ToDouble(str_temp2);
                this.textBox5.Text = Convert.ToString(dbl_temp + dbl_temp2);
            }
            catch 
            {
                this.textBox5.Text = "ERROR";
            }
        }
    }
}
