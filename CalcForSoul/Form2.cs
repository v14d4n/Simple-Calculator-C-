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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void KubButton_Click(object sender, EventArgs e)
        {
            Kub kub = new Kub();
            kub.Show();
            this.Close();
        }

        private void ParalButton_Click(object sender, EventArgs e)
        {
            Paralel paralel = new Paralel();
            paralel.Show();
            this.Close();
        }

        private void PParalButton_Click(object sender, EventArgs e)
        {
            PParalel pParalel = new PParalel();
            pParalel.Show();
            this.Close();
        }

        private void PrismButton_Click(object sender, EventArgs e)
        {
            Prism prism = new Prism();
            prism.Show();
            this.Close();
        }

        private void PiramidButton_Click(object sender, EventArgs e)
        {
            Piramid piramid = new Piramid();
            piramid.Show();
            this.Close();
        }
    }
}
