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

namespace P02ZadaniePogoda
{
    public partial class Form1 : Form
    {
        string sciezkaMiasta = "miasta.txt";

        public Form1()
        {
            InitializeComponent();
            wczytajMiasta();


        }

        private void wczytajMiasta()
        {
            string[] miasta = File.ReadAllLines(sciezkaMiasta);
            cbMiasta.Items.Clear();
            cbMiasta.Items.AddRange(miasta);
        }

        private void btnWczytajMiasta_Click(object sender, EventArgs e)
        {
            ofdPliki.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (ofdPliki.ShowDialog() == DialogResult.OK)
            {
                sciezkaMiasta = ofdPliki.FileName;
                wczytajMiasta();
            }
            
        }

        private void btnPodajTemperature_Click(object sender, EventArgs e)
        {
            ManagerPogody mp = new ManagerPogody();
            mp.SzukanyZnak = "°";

            // string jednostka = rbCel.Checked ? rbCel.Text : rbFar.Checked ? rbFar.Text : rbKel.Text;
            string jednostka;
            if (rbCel.Checked)
                jednostka = rbCel.Text.ToLower();
            else if (rbFar.Checked)
                jednostka = rbFar.Text.ToLower();
            else
                jednostka = rbKel.Text.ToLower();

            mp.Jednostka = jednostka;
            //mp.Jednostka = "c";

            string miasto = cbMiasta.Text;
            if (string.IsNullOrEmpty(miasto))
            {
                MessageBox.Show("Nie wybrano miasta","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            double temp = mp.PodajTemperature(miasto);
            lblRaport.Text = String.Format("Temperatura w mieście {0} wynosi {1}",
                miasto, temp);

        }
    }
}
