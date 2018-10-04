using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloTaschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            decimal z1 = Convert.ToDecimal(textBoxZahl1.Text);
            decimal z2 = Convert.ToDecimal(textBoxZahl2.Text);

            labelErgebnis.Text = (z1 + z2).ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            decimal z1 = Convert.ToDecimal(textBoxZahl1.Text);
            decimal z2 = Convert.ToDecimal(textBoxZahl2.Text);

            labelErgebnis.Text = (z1 - z2).ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            decimal z1 = Convert.ToDecimal(textBoxZahl1.Text);
            decimal z2 = Convert.ToDecimal(textBoxZahl2.Text);

            labelErgebnis.Text = (z1 * z2).ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            decimal z1 = Convert.ToDecimal(textBoxZahl1.Text);
            decimal z2 = Convert.ToDecimal(textBoxZahl2.Text);

            labelErgebnis.Text = (z1 / z2).ToString();
        }
    }
}
