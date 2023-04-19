using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieFreeBook.Models
{
    internal class Utilizator
    {
        private string email;
        private string password;
        private string nume;
        private string prenume;

        public Utilizator(string email, string pass, string nume, string prenume)
        {
            this.email = email;
            this.password = pass;
            this.nume = nume;
            this.prenume = prenume;

        }

        public Utilizator(string text) {

            string[] porp = text.Split('*');

            this.email = porp[0];
            this.password = porp[1];
            this.nume = porp[2];
            this.prenume = porp[3];

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
