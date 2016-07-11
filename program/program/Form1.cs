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

        public String plik = null; // przechowuje ścieżkę pliku
        public String nazwa = null; // przechowuje nazwę pliku
        public String zawartosc = null; // przechowuje zawartość pliku
        public FileInfo opliku = null; // przechowuje informacje o pliku
        public long rozmiar = 0; // przechowuje rozmiar pliku 
        public char ch; // przechowuje odczytywany znak
        public int ilosc_znakow = 0; // przechowuje ilosc znaków pliku
        public int unikalnych_znakow = 0; // przechowuje ilosc unikalnych znaków pliku
        public Double granica = 0; // początek zakresu 0,1
        Metody wykonaj = new Metody(); // 
        List<Huffman> lista = new List<Huffman>();  // 

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_otworz_plik_click(object sender, EventArgs e)
        {

            dgv_info.Rows.Clear();
            dgv_info.Refresh();

            OpenFileDialog okno = new OpenFileDialog(); // tworzy okno dialogowe do otwierania pliku
            okno.Title = "Wybierz plik"; // tytuł okna

            if (okno.ShowDialog() == DialogResult.OK) // jeżeli użytkownik wybrał plik
            {
                try // to próbuje wykonać na nim operacje
                {
                    plik = okno.FileName; // wyciąga ścieżkę do pliku
                    opliku = new FileInfo(plik); // wyciąga informacje o pliku
                    nazwa = opliku.Name; // wyciąga nazwę pliku 
                    rozmiar = opliku.Length; // wyciąga rozmiar pliku

                    DataGridViewRow wiersz = (DataGridViewRow)dgv_info.Rows[0].Clone();
                    wiersz.Cells[0].Value = "Plik: ";// wypisuje na ekran nazwę pliku
                    wiersz.Cells[1].Value = nazwa;
                    dgv_info.Rows.Add(wiersz);

                    wiersz = (DataGridViewRow)dgv_info.Rows[0].Clone();
                    wiersz.Cells[0].Value = "Rozmiar: ";// wypisuje na ekran rozmiar pliku
                    wiersz.Cells[1].Value = rozmiar;
                    dgv_info.Rows.Add(wiersz);
                                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            info.Text = String.Empty; // czyści textbox
            dgv_huffman.Rows.Clear(); // czyści tabelkę 1
            dgv_huffman.Refresh();
            dgv_arytmetyczne.Rows.Clear(); // czyści tabelkę 2
            dgv_arytmetyczne.Refresh();
            dgv_arytmetyczne.Rows.Clear();
            dgv_arytmetyczne.Refresh();

            StreamReader reader = new StreamReader(plik);
            char ch;
            Double dolna;
            Double gorna;
            Double zakres;
            Double zakres_dolny;
            Double zakres_gorny;
            Double tmp;


            dolna = 0.0;
            gorna = 1.0;
            do
            {
                ch = (char)reader.Read();
                string odczytany = Convert.ToChar(ch).ToString();
                if (odczytany == " ") odczytany = "[spacja]";
                if (odczytany == "\n") odczytany = "\\n";
                if (odczytany == "\r") odczytany = "\\r";
                DataGridViewRow wiersz = (DataGridViewRow)dgv_arytmetyczne.Rows[0].Clone();
                wiersz.Cells[0].Value = odczytany;

                var index = lista.FindIndex(a => a.znak == odczytany);
                wiersz.Cells[1].Value = lista[index].czestotliwosc;
                wiersz.Cells[2].Value = lista[index].prawdopodobienstwo;
                zakres_dolny = Convert.ToDouble(lista[index].dolna);
                zakres_gorny = Convert.ToDouble(lista[index].gorna);

                zakres = gorna - dolna;
                tmp = dolna;
                dolna = dolna + (zakres * zakres_dolny);
                gorna = tmp + (zakres * zakres_gorny);
                wiersz.Cells[3].Value = dolna.ToString();
                wiersz.Cells[4].Value = gorna.ToString();
                dgv_arytmetyczne.Rows.Add(wiersz);

            } while (!reader.EndOfStream);

            tb_policz.Text = dolna.ToString();
            reader.Close();
        }

        private void btn_policz_click(object sender, EventArgs e)
        {
            try
            {
                dgv_policz.Rows.Clear();
                dgv_policz.Refresh();
                tb_policz.Clear();
                tb_policz.Refresh();

                zawartosc = File.ReadAllText(plik); // wyciąga zawartość pliku
                ilosc_znakow = zawartosc.Length; // liczy ilość znaków
                tb_policz.Text += "Znaków w pliku: " + ilosc_znakow.ToString() + "\r\n"; // wypisuje na ekran ilość znaków w pliku

                StreamReader reader; // tworzy instancję potoku
                reader = new StreamReader(plik); // podpina plik do potoku
                do // rozpoczyna pętlę
                {
                    ch = (char)reader.Read(); // odczytuje jeden bajt
                    string odczytany = Convert.ToChar(ch).ToString(); // konwertuje na wartość typu string
                    if (lista.Exists(x => x.znak == odczytany)) // sprawdza czy znak znajduje się na liście
                        lista[lista.FindIndex(y => y.znak == odczytany)].zwiekszCzestotliwosc(); // jeśli tak, to zwiększa jego częstotliwość
                    else
                        unikalnych_znakow++;
                        lista.Add(new Huffman(odczytany));   // jeśli nie, to tworzy nowy węzeł listy
                } while (!reader.EndOfStream); // wykonuje dopóki nie skończy czytać całego pliku

                reader.Close(); // zamyka potok

                tb_policz.Text += "Unikalnych znaków w pliku: " + unialnych_znakow.ToString() + "\r\n"; // wypisuje na ekran ilość unikalnych znaków w pliku



                lista.Sort(); // sortuje listę zgodnie z częstotliwością znaków
                wykonaj.zrobDrzewo(lista); // tworzy drzewo binarne znaków

                wykonaj.nadajKody("", lista[0], ilosc_znakow, ref granica); // nadaje kody poszczególnym znakom
                wykonaj.wypisz(lista[0], dgv_huffman, ilosc_znakow); // wypisuje tablicę kodowania
            }
            catch
            {

            }


            Double granica = 0;
            foreach (DataGridViewRow row in dgv_huffman.Rows)
            {
                row.Cells[4].Value = granica.ToString();
                granica = granica + Convert.ToDouble(row.Cells[2].Value);
                row.Cells[5].Value = granica.ToString();
            }
        }

    }
}
