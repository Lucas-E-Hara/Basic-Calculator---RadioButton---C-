using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas_Eiji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtN1.Text);
            double N2 = Convert.ToDouble(txtN2.Text);
            double soma = N1 + N2;
            txtR.Text = soma.ToString();
        }

        private void radioSub_CheckedChanged(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtN1.Text);
            double N2 = Convert.ToDouble(txtN2.Text);
            double subtracao = N1 - N2;
            txtR.Text = subtracao.ToString();
        }

        private void radioMult_CheckedChanged(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtN1.Text);
            double N2 = Convert.ToDouble(txtN2.Text);
            double multiplicacao = N1 * N2;
            txtR.Text = multiplicacao.ToString();
        }

        private void radioDiv_CheckedChanged(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtN1.Text);
            double N2 = Convert.ToDouble(txtN2.Text);
            double divisao = N1 / N2;
            txtR.Text = divisao.ToString();
        }
    }
}
