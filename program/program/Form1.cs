using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Metody wykonaj = new Metody(); // inicjujemy klasę
        List<Huffman> lista = new List<Huffman>();  // inicjujemy klasę
        FileStream potok = null; // zerujemy zmienne
        String plik = null;
        FileInfo opliku = null;
        String nazwa = null;
        long rozmiar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            info.Text = String.Empty; // czyścimy okno
            OpenFileDialog okno = new OpenFileDialog(); // tworzymy okno otwierania pliku
            okno.Title = "Wybierz plik";

            if (okno.ShowDialog() == DialogResult.OK) // jeżeli użytkownik wybrał plik
            {
                try // to próbujemy wykonać na nim operacje
                {
                    
                    plik = okno.FileName; // wyciągamy ścieżkę do pliku
                    opliku = new FileInfo(plik); // wyciągamy informacje o pliku
                    nazwa = opliku.Name; // nazwa
                    rozmiar = opliku.Length; // rozmiar

                    info.Text += "Plik: " + nazwa + "\r\n"; // wypisujemy na ekran
                    info.Text += "Rozmiar: " + rozmiar + " bajtów\r\n"; // wypisujemy na ekran

                    potok = new FileStream(plik, FileMode.Open, FileAccess.Read); // tworzymy potok do którego przekażemy zawartośc pliku

                    info.Text += "\r\nZnaków w pliku: " + potok.Length.ToString() + "\r\n";

                    for (int i = 0; i < potok.Length; i++) // 
                    {
                        string odczytany = Convert.ToChar(potok.ReadByte()).ToString();
                        if (lista.Exists(x => x.znak == odczytany)) // Checking the value that have you created before?
                            lista[lista.FindIndex(y => y.znak == odczytany)].zwiekszCzestotliwosc(); // If is yes, find the index of the Node and increase the frequency of the Node.
                        else
                            lista.Add(new Huffman(odczytany));   // If is no, create a new node and add to the List of Nodes
                    }

                    lista.Sort();

                    wykonaj.zrobDrzewo(lista);
                    wykonaj.nadajKody("", lista[0]);
                    wykonaj.wypisz(lista[0], dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
