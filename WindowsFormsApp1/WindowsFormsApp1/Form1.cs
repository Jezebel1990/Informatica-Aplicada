using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double N1,N2,N3, N4, Soma, Media;

        private void txbN3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbN1.Text = null;
            txbN2.Text = null;
            txbN3.Text = null;
            txbN4.Text = null;
            txbSoma.Text = null;
            txbMedia.Text = null;
            txbN1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            N1 = Convert.ToDouble(txbN1.Text.Trim());
            N2 = Convert.ToDouble(txbN2.Text.Trim());
            N3 = Convert.ToDouble(txbN3.Text.Trim());
            N4 = Convert.ToDouble(txbN4.Text.Trim());
            Soma = N1 + N2 + N3 + N4;
            Media = Soma / 4;
            txbSoma.Text = Soma.ToString();
            txbMedia.Text = Media.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
