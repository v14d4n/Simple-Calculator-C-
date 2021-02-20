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
    public partial class PParalel : Form
    {
        public PParalel()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void rasch1Button_Click(object sender, EventArgs e)
        {
            try
            {
                string str_temp = this.textBox1.Text; string str_temp2 = this.textBox2.Text; string str_temp3 = this.textBox3.Text;
                double dbl_temp = Convert.ToDouble(str_temp); double dbl_temp2 = Convert.ToDouble(str_temp2); double dbl_temp3 = Convert.ToDouble(str_temp3);
                this.textBox4.Text = Convert.ToString(dbl_temp * dbl_temp2 * dbl_temp3);
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
                string str_temp = this.textBox8.Text; string str_temp2 = this.textBox7.Text; string str_temp3 = this.textBox6.Text;
                double dbl_temp = Convert.ToDouble(str_temp); double dbl_temp2 = Convert.ToDouble(str_temp2); double dbl_temp3 = Convert.ToDouble(str_temp3);
                this.textBox5.Text = Convert.ToString(2 * dbl_temp * dbl_temp2 + 2 * dbl_temp * dbl_temp2 + 2 * dbl_temp2 * dbl_temp3);
            }
            catch 
            {
                this.textBox5.Text = "ERROR";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str_temp = this.textBox12.Text; string str_temp2 = this.textBox11.Text; string str_temp3 = this.textBox10.Text;
                double dbl_temp = Convert.ToDouble(str_temp); double dbl_temp2 = Convert.ToDouble(str_temp2); double dbl_temp3 = Convert.ToDouble(str_temp3);
                this.textBox9.Text = Convert.ToString(Math.Sqrt(Math.Pow(dbl_temp, 2) + Math.Pow(dbl_temp2,2) + Math.Pow(dbl_temp3, 3)));
            }
            catch 
            {
                this.textBox9.Text = "ERROR";
            }
        }
    }
}
