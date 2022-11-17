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
    }
}
