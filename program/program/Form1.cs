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

        List<Huffman> lista = new List<Huffman>();  // Node List.
        FileStream potok = null;
        String plik = null;
        String nazwa = null;
        

        private void button1_Click(object sender, EventArgs e)
        {
            info.Text = String.Empty;
            OpenFileDialog okno = new OpenFileDialog();
            okno.Title = "Wybierz plik";

            if (okno.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    plik = okno.FileName;
                    nazwa = Path.GetFileName(plik);
                    info.Text = "Plik: " + nazwa + "\n\r";
                    potok = new FileStream(plik, FileMode.Open, FileAccess.Read);
                    
                    for (int i = 0; i < potok.Length; i++)
                    {
                        string odczytany = Convert.ToChar(potok.ReadByte()).ToString();
                        if (lista.Exists(x => x.znak == odczytany)) // Checking the value that have you created before?
                            lista[lista.FindIndex(y => y.znak == odczytany)].zwiekszCzestotliwosc(); // If is yes, find the index of the Node and increase the frequency of the Node.
                        else
                            lista.Add(new Huffman(odczytany));   // If is no, create a new node and add to the List of Nodes
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
