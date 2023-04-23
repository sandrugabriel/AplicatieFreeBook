using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieFreeBook.Models
{
    internal class Utilizator
    {
        private int id;
        private string email;
        private string password;
        private string nume;
        private string prenume;

        public Utilizator(int id,string email, string pass, string nume, string prenume)
        {
            this.id = id;
            this.email = email;
            this.password = pass;
            this.nume = nume;
            this.prenume = prenume;

        }

        public Utilizator(string text) {

            string[] porp = text.Split('*');

            this.id = int.Parse(porp[0]);
            this.email = porp[1];
            this.password = porp[2];
            this.nume = porp[3];
            this.prenume = porp[4];

        }

        public int getId()
        {
            return id;
        }

        public string getemail()
        {
            return this.email;
        }

        public string getpass() {
            return this.password; }

        public string getnume(){ 
            return this.nume; }

        public string getprenume()
        {
            return this.prenume;
        }


    }
}
