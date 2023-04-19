using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieFreeBook.Models
{
    internal class Carte
    {

        private int id;
        private string titlu;
        private string autor;
        private string gen;

        public Carte(int id, string titlu, string autor, string gen)
        {
            this.id = id;
            this.titlu = titlu;
            this.autor = autor;
            this.gen = gen;
        }

        public Carte(string text)
        {

            string[] prop = text.Split('*');

            this.id = int.Parse(prop[0]);
            this.titlu = prop[1];
            this.autor = prop[2];
            this.gen = prop[3];

        }

        public int getId()
        {
            return id;
        }

        public string getTitlu()
        {
            return titlu;
        }

        public string getAutor()
        {
            return autor;
        }

        public string getGen()
        {
            return gen;
        }

    }
}
