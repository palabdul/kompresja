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

        String plik = null;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Metody wykonaj = new Metody(); // inicjujemy klasę
            List<Huffman> lista = new List<Huffman>();  // inicjujemy klasę
            
            FileInfo opliku = null;
            String nazwa = null;
            long rozmiar = 0;
            char ch;


            //lista.OrderBy();

            info.Text = String.Empty; // czyścimy okno

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

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

                    string Text = File.ReadAllText(plik);
                    int dlugosc = Text.Length;
                    info.Text += "\r\nZnaków w pliku: " + dlugosc.ToString() + "\r\n";

                    StreamReader reader;
                    reader = new StreamReader(plik);
                    do
                    {
                        ch = (char)reader.Read();
                        string odczytany = Convert.ToChar(ch).ToString();
                        if (lista.Exists(x => x.znak == odczytany)) // Checking the value that have you created before?
                            lista[lista.FindIndex(y => y.znak == odczytany)].zwiekszCzestotliwosc(); // If is yes, find the index of the Node and increase the frequency of the Node.
                        else
                            lista.Add(new Huffman(odczytany));   // If is no, create a new node and add to the List of Nodes
                    } while (!reader.EndOfStream);

                    reader.Close();

                    lista.Sort();
                    wykonaj.zrobDrzewo(lista);
                    Double granica = 0;
                    wykonaj.nadajKody("", lista[0], dlugosc,ref granica);
              //      wykonaj.nadaj(lista, info);
                    wykonaj.wypisz(lista[0], dataGridView1, dlugosc);

                    

                    

                    // this.dataGridView1.Sort(this.dataGridView1.Columns["znak"], ListSortDirection.Ascending);

                    int total = dataGridView1.Rows.Cast<DataGridViewRow>()
                                .Sum(t => Convert.ToInt32(t.Cells[1].Value));
                    info.Text += "\r\nSuma: " + total.ToString() + "\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            StreamReader reader = new StreamReader(plik);
            char ch;
            Double dolna;
            Double gorna;
            Double zakres;
            Double zakres_dolny;
            Double zakres_gorny;
            Double tmp;
            Metody wykonaj = new Metody(); // inicjujemy klasę


            dolna = 0.0;
            gorna = 1.0;
            do
            {
                ch = (char)reader.Read();
                string odczytany = Convert.ToChar(ch).ToString();
                if (odczytany == " ") odczytany = "[spacja]";
                if (odczytany == "\n") odczytany = "\\n";
                if (odczytany == "\r") odczytany = "\\r";
                DataGridViewRow wiersz = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                wiersz.Cells[0].Value = odczytany;
                int wiersz_dgv = wykonaj.znajdz_wiersz(dataGridView1, odczytany);
                wiersz.Cells[1].Value = dataGridView1.Rows[wiersz_dgv].Cells[1].Value;
                wiersz.Cells[2].Value = dataGridView1.Rows[wiersz_dgv].Cells[2].Value;
                zakres_dolny = Convert.ToDouble(dataGridView1.Rows[wiersz_dgv].Cells[4].Value);
                zakres_gorny = Convert.ToDouble(dataGridView1.Rows[wiersz_dgv].Cells[5].Value);

                zakres = gorna - dolna;
                tmp = dolna;
                dolna = dolna + (zakres * zakres_dolny);
                gorna = tmp + (zakres * zakres_gorny);
                wiersz.Cells[3].Value = dolna.ToString();
                wiersz.Cells[4].Value = gorna.ToString();
                dataGridView2.Rows.Add(wiersz);

            } while (!reader.EndOfStream);

            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double granica = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[4].Value = granica.ToString();
                granica = granica + Convert.ToDouble(row.Cells[2].Value);
                row.Cells[5].Value = granica.ToString();
            }
        }
    }
}
