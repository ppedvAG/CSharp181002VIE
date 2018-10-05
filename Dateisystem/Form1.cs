using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dateisystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mir ist nicht mehr zu helfen :) ...");
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // System.IO
            //StreamReader sr = new StreamReader("output.txt");
            //textBoxInhalt.Text = sr.ReadToEnd();
            //sr.Close();

            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxInhalt.Text = File.ReadAllText(dlg.FileName);
                MessageBox.Show("Datei wurde geöffnet !");
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter("output.txt");
            //sw.Write(textBoxInhalt.Text);
            //sw.Close();

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Textdatei | *.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBoxInhalt.Text);
                MessageBox.Show("Datei wurde erfolgreich gespeichert !");
            }

            // File -> Alle Funktionen, die mit Dateien zu tun haben
            //File.SetCreationTime("output.txt", new DateTime(1856, 5, 12));

            // Directory -> Alles, was mit Ordner zu tun hat

            // Beispiel: Durch alle Dateien im Ordner x Durchgehen

            //string dateien = "";
            //// @ -> String ohne Steuerzeichen wie \n\r etc..., \  zählt als  \ 
            //foreach (string filePath in Directory.GetFiles(@"C:\Users\mz1-dev\Desktop"))
            //{
            //    dateien += filePath + Environment.NewLine;
            //}
            //MessageBox.Show(dateien);

        }


    }
}
