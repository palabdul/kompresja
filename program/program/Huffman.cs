using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Huffman : IComparable<Huffman>
    {
        public string znak;   // For the character of char wartosc. Public because Process class use it.
        public int czestotliwosc;          // Number of the count on file, string, text.
        public double prawdopodobienstwo; // 
        public string kod;            // Getting from a tree for making a huffman tree.
        public Huffman rodzic; // Parent Node of current Node.
        public Huffman lewy;   // Left Node of current Node.
        public Huffman prawy;  // Right Node of current Node.
        public bool lisc;            // Shows it is a leaf.


        public Huffman(string wartosc)    // Creating a Node with given wartosc(character).
        {
            znak = wartosc;     // Setting the znak.
            czestotliwosc = 1;      // This is creation of Node, so now its count is 1.

            prawy = lewy = rodzic = null;       // Does not have a left or right tree and a parent.

            kod = "";          // It will be Assigned on the making Tree. Now it is empty.
            lisc = true;      // Because all Node we create first does not have a parent Node.
        }


        public Huffman(Huffman pierwszy, Huffman drugi) // Join the 2 Node to make Node.
        {
            // Firsly we are adding this 2 Nodes' variables. Except the new Node's left and right tree.
            kod = "";
            lisc = false;
            rodzic = null;

            // Now the new Node need leaf. They are pierwszy and drugi. if pierwszy's czestotliwosc is bigger than or equal to drugi's czestotliwosc. It is right tree. Otherwise left tree. The controllers are below:
            if (pierwszy.czestotliwosc >= drugi.czestotliwosc)
            {
                prawy = pierwszy;
                lewy = drugi;
                prawy.rodzic = lewy.rodzic = this;     // "this" means the new Node!
                znak = pierwszy.znak + drugi.znak;
                czestotliwosc = pierwszy.czestotliwosc + drugi.czestotliwosc;
            }
            else if (pierwszy.czestotliwosc < drugi.czestotliwosc)
            {
                prawy = drugi;
                lewy = pierwszy;
                lewy.rodzic = prawy.rodzic = this;     // "this" means the new Node!
                znak = drugi.znak + pierwszy.znak;
                czestotliwosc = drugi.czestotliwosc + pierwszy.czestotliwosc;
            }
        }


        public int CompareTo(Huffman inny) // We just override the CompareTo method. Because when we compare two Node, it must be according to frequencies of the Nodes.
        {
            return this.czestotliwosc.CompareTo(inny.czestotliwosc);
        }


        public void zwiekszCzestotliwosc()             // When facing a same wartosc on the Node list, it is increasing the czestotliwosc of the Node.
        {
            czestotliwosc++;
        }
    }
}
