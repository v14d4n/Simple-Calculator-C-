using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForSoul
{
    public partial class Kub : Form
    {
        public Kub()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void rasch1Button_Click(object sender, EventArgs e)
        {
            try
            {
                string str_temp = this.textBox1.Text;
                double dbl_temp = Convert.ToDouble(str_temp);
                this.textBox4.Text = Convert.ToString(Math.Pow(dbl_temp, 3));
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
                string str_temp = this.textBox8.Text;
                double dbl_temp = Convert.ToDouble(str_temp);
                this.textBox5.Text = Convert.ToString(6 * Math.Pow(dbl_temp, 2));
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
                string str_temp = this.textBox12.Text;
                double dbl_temp = Convert.ToDouble(str_temp);
                this.textBox9.Text = Convert.ToString(dbl_temp * Math.Sqrt(3));
            }
            catch
            {
                this.textBox9.Text = "ERROR";
            }
        }
    }
}
