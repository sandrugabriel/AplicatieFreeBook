using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook.Models
{
    internal class Imprumut
    {

        private int id;
        private int id_Carte;
        private int id_User;
        private string carte;
        private string email;
        private DateTime data_Imprumut;

        public Imprumut(int id,int id_carte, int id_User, string carte, string email, DateTime data_Imprumut)
        {
            this.id = id;
            this.id_Carte = id_carte;
            this.id_User = id_User;
            this.carte = carte;
            this.email = email;
            this.data_Imprumut = data_Imprumut;
        }

        public Imprumut(string text)
        {

            string[] prop = text.Split('*');

            this.id = int.Parse(prop[0]);
            this.id_Carte = int.Parse(prop[1]);
            this.id_User = int.Parse(prop[2]);
            this.carte = prop[3];
            this.email = prop[4];
            this.data_Imprumut = DateTime.Parse(prop[5]);

        }

        public int getId()
        {
            return id;
        }

        public int getId_Carte() { 
             return id_Carte;
        }

        public int getId_User()
        {
            return id_User;
        }

        public string getcarte()
        {
            return carte;
        }

        public string getEmail()
        {
            return email;
        }

        public DateTime getData_Imprumut()
        {
            return data_Imprumut;
        }



    }
}
