using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program
{
    class Metody
    {
        public void wypisz(Huffman lista, DataGridView dgv, Int32 znakow)
        {
            if (lista == null)
                return;
            if (lista.lewy == null && lista.prawy == null)
            {

                DataGridViewRow wiersz = (DataGridViewRow)dgv.Rows[0].Clone();
                if (lista.znak == " ") wiersz.Cells[0].Value = "[spacja]";
                else if (lista.znak == "\n") wiersz.Cells[0].Value = "\\n";
                else if (lista.znak == "\r") wiersz.Cells[0].Value = "\\r";
                else wiersz.Cells[0].Value = lista.znak;
                wiersz.Cells[1].Value = lista.czestotliwosc;
                wiersz.Cells[2].Value = (double)lista.czestotliwosc / (double)znakow;
                wiersz.Cells[3].Value = lista.kod;
                dgv.Rows.Add(wiersz);
                return;
            }
            wypisz(lista.lewy, dgv, znakow);
            wypisz(lista.prawy, dgv, znakow);
        }

        // Setting the codes of the nodes of tree. Recursive method.
        public void nadajKody(string kod, Huffman lista)
        {
            if (lista == null)
                return;
            if (lista.lewy == null && lista.prawy == null)
            {
                lista.kod = kod;
                return;
            }
            nadajKody(kod + "0", lista.lewy);
            nadajKody(kod + "1", lista.prawy);
        }

        //  Creates a Tree according to Nodes(frequency, symbol)
        public void zrobDrzewo(List<Huffman> lista)
        {
            while (lista.Count > 1)  // 1 because a tree need 2 leaf to make a new parent.
            {
                Huffman pierwszy = lista[0];    // Get the node of the first index of List,
                lista.RemoveAt(0);               // and delete it.
                Huffman drugi = lista[0];    // Get the node of the first index of List,
                lista.RemoveAt(0);               // and delete it.
                lista.Add(new Huffman(pierwszy, drugi));    // Sending the constructor to make a new Node from this nodes.
                lista.Sort();        // and sort it again according to frequency.
            }
        }
    }
}
