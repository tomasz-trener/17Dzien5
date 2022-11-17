using P03AplikacjaZawodnicy.Domain;
using P03AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {

        ManagerZawodnikow mz;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnWczytaj_Click(object sender, EventArgs e) 
        {
            mz = new ManagerZawodnikow(TypImportu.Zdalny, txtUrl.Text);
            mz.WczytajZawodnikow();

            lblDane.DataSource = mz.PodajZawodnikow(txtKraj.Text); // Data binding 
            lblDane.DisplayMember = "ImieNazwisko";
        }

        private void lblDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lblDane.SelectedItem;
            //Zawodnik zaznaczony = lblDane.SelectedItem as Zawodnik;

            txtImie.Text = zaznaczony.Imie;
            txtNazwisko.Text = zaznaczony.Nazwisko;
            txtKrajZawodnika.Text = zaznaczony.Kraj;
            txtDaraUr.Text = zaznaczony.DataUrodzenia.ToString("dd-MM-yyyy"); //Convert.ToString(zaznaczony.DataUrodzenia);
            txtWzrost.Text = Convert.ToString(zaznaczony.Wzrost);
            txtWaga.Text = Convert.ToString(zaznaczony.Waga);
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lblDane.SelectedItem;

            zaznaczony.Imie = txtImie.Text;
            zaznaczony.Nazwisko = txtNazwisko.Text;
            zaznaczony.Kraj = txtKrajZawodnika.Text;

            // zaznaczony.DataUrodzenia = Convert.ToDateTime(txtDaraUr.Text);
            string[] dataStr = txtDaraUr.Text.Split('-');
            zaznaczony.DataUrodzenia = new DateTime(
                Convert.ToInt32(dataStr[2]), Convert.ToInt32(dataStr[1]), Convert.ToInt32(dataStr[0])
                );

            zaznaczony.Wzrost = Convert.ToInt32(txtWzrost.Text);
            zaznaczony.Waga = Convert.ToInt32(txtWaga.Text);

            mz.Zapisz(zaznaczony);

        }


        //private void btnWczytaj_Click(object sender, EventArgs e)
        //{
        //    lblDane.Items.Clear();

        //    mz = new ManagerZawodnikow(TypImportu.Zdalny, txtUrl.Text);
        //    mz.WczytajZawodnikow();
        //    Zawodnik[] zawodnicy = mz.PodajZawodnikow(txtKraj.Text);

        //    foreach (var z in zawodnicy)
        //    {
        //        lblDane.Items.Add(z.Imie + " " + z.Nazwisko);
        //    }

        //}

        //private void lblDane_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string zaznaczony = Convert.ToString(lblDane.SelectedItem);

        //    MessageBox.Show(zaznaczony);

        //    // propozycja rozwiazania:
        //    // sprawdzamy, która pozycja na liście jest zaznaczona.
        //    // nastepnie na liscie naszych zawodnikow szukamy zawodnika o podanym indeksie 
        //    int zaznaczonaPozycja = lblDane.SelectedIndex;
        //    //ManagerZawodnikow mz = new ManagerZawodnikow(TypImportu.Zdalny, txtUrl.Text);
        //    //mz.WczytajZawodnikow();
        //    Zawodnik[] zawodnicy = mz.Zawodnicy;
        //    Zawodnik zaznaczonyZawodnik = zawodnicy[zaznaczonaPozycja];

        //    // wady: po 1) nie potrzebnie wywolujemy ponowne odwolanie się do pliku źródłowego 
        //    // ta wada zsotała rozwiazania poprzez wyniesienie ManagerZawodnikow
        //    // do ciała klasy i w tym momencie obydwie metody korzystaja 
        //    // z tego samego obiektu (ManagerZawodnikow). A ManagerZawodnikow
        //    // posisada z cachowaną listę zawodnikow 

        //    // wada nr 2) 
        //}
    }
}
