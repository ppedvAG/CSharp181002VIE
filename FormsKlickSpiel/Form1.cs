using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsKlickSpiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            t = new Timer();
            t.Tick += TimerAbgelaufen;
            t.Interval = 60000;
            buttonKlickMich.Enabled = false;
        }
        private Timer t;
        private int counter;

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            t.Start();
            buttonKlickMich.Enabled = true;

            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void TimerAbgelaufen(object sender, EventArgs e)
        {
            MessageBox.Show($"Sie haben {counter} Klicks geschafft !");
            t.Stop();
            buttonKlickMich.Enabled = false;
            MaximizeBox = true;
            MinimizeBox = true;
        }

        private void buttonKlickMich_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int newX = r.Next(0, this.Width - buttonKlickMich.Width);
            int newY = r.Next(0, this.Height - buttonKlickMich.Height);

            buttonKlickMich.Location = new Point(newX, newY);
            counter++;
            labelNoCheat.Focus();

            int red = r.Next(0, 255);
            int green = r.Next(0, 255);
            int blue = r.Next(0, 255);
            buttonKlickMich.BackColor = Color.FromArgb(red,green,blue);
        }

        private void buttonKlickMich_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            int newX = r.Next(0, this.Width - buttonKlickMich.Width);
            int newY = r.Next(0, this.Height - buttonKlickMich.Height);

            buttonKlickMich.Location = new Point(newX, newY);
            labelNoCheat.Focus();
        }
    }
}
