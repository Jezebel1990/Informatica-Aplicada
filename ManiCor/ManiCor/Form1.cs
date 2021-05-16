using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManiCor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Yellow;
        }
    }
}
