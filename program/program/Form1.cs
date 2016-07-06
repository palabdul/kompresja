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

        

        private void button1_Click(object sender, EventArgs e)
        {
            Metody wykonaj = new Metody(); // inicjujemy klasę
            List<Huffman> lista = new List<Huffman>();  // inicjujemy klasę
            String plik = null;
            FileInfo opliku = null;
            String nazwa = null;
            long rozmiar = 0;
            char ch;

            lista.OrderBy()

            info.Text = String.Empty; // czyścimy okno

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

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


                    lista.Sort();
                    wykonaj.zrobDrzewo(lista);
                    wykonaj.nadajKody("", lista[0], dlugosc);
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
            double dolna = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells[4].Value = dolna.ToString();
                dolna += Convert.ToDouble(row.Cells[2].Value);
                row.Cells[5].Value = dolna.ToString();
                
                //More code here
            }
        }
    }
}
