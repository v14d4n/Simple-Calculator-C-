using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows;

// v14d4n ;)

namespace CalcForSoul
{
    public partial class Form1 : Form
    {
        History h = new History();
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public void equallyButton_Click(object sender, EventArgs e) // при нажатии на равно
        {
            try
            {
                string exp = UserText.Text.Replace(",", ".") + ".0";

                CalculateText.Text = Convert.ToString(new DataTable().Compute(exp, ""));

                if (CalculateText.Text.EndsWith(",0"))
                {
                    CalculateText.Text = CalculateText.Text.Remove(CalculateText.Text.Length - 2);
                }

                if (CalculateText.Text != "" && UserText.Text != CalculateText.Text)
                {
                    h.textBox10.Text = h.textBox9.Text; h.textBox9.Text = h.textBox8.Text; h.textBox8.Text = h.textBox7.Text;
                    h.textBox7.Text = h.textBox6.Text; h.textBox6.Text = h.textBox5.Text; h.textBox5.Text = h.textBox4.Text;
                    h.textBox4.Text = h.textBox3.Text; h.textBox3.Text = h.textBox2.Text; h.textBox2.Text = h.textBox1.Text;
                    h.textBox1.Text = UserText.Text + " = " + CalculateText.Text;
                }

                UserText.Clear();
            }
            catch
            {
                CalculateText.Text = @"ERROR";
                UserText.Clear();
            }
        }

        private void UserText_KeyDown_1(object sender, KeyEventArgs e) // обработка нажатий на ентер
        {
            if (e.KeyCode == Keys.Enter) 
                equallyButton_Click(this, EventArgs.Empty);
        }

        #region ...кнопки...

        private void button10_Click(object sender, EventArgs e)
        {
            if (UserText.Text.LastIndexOf(" ") == UserText.Text.Length - 1) UserText.Text += @"( ";
            else UserText.Text += @" ( ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (UserText.Text.LastIndexOf(" ") == UserText.Text.Length - 1 && UserText.TextLength >= 2) 
                UserText.Text = UserText.Text.Remove(UserText.Text.Length - 2);
            else if (UserText.TextLength > 0) 
                UserText.Text = UserText.Text.Remove(UserText.Text.Length - 1);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (UserText.Text.LastIndexOf(" ") == UserText.Text.Length - 1) UserText.Text += @") ";
            else UserText.Text += @" ) ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserText.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserText.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserText.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserText.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserText.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserText.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserText.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserText.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserText.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            UserText.Text += 0;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            UserText.Text += @".";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (UserText.Text.LastIndexOf(" ") == UserText.Text.Length - 1) UserText.Text += @"/ ";
            else UserText.Text += @" / ";
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            if (UserText.Text.LastIndexOf(" ") == UserText.Text.Length - 1) UserText.Text += @"* ";
            else UserText.Text += @" * ";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (UserText.Text.LastIndexOf(" ") == UserText.Text.Length - 1) UserText.Text += @"- ";
            else UserText.Text += @" - ";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (UserText.Text.LastIndexOf(" ") == UserText.Text.Length - 1) UserText.Text += @"+ ";
            else UserText.Text += @" + ";
        }

        #endregion

        private void buttonFormul_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            h.Show();
        }
    }
}