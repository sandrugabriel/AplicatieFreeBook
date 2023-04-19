using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieFreeBook.Models
{
    internal class Imprumut
    {

        private int id;
        private int id_carte;
        private string email;
        private DateTime data_Imprumut;

        public Imprumut(int id, int id_carte, string email, DateTime data_Imprumut)
        {
            this.id = id;
            this.id_carte = id_carte;
            this.email = email;
            this.data_Imprumut = data_Imprumut;
        }

        public Imprumut(string text)
        {

            string[] prop = text.Split('*');

            this.id = int.Parse(prop[0]);
            this.id_carte = int.Parse(prop[1]);
            this.email = prop[2];
            this.data_Imprumut = DateTime.Parse(prop[3]);

        }

        public int getId()
        {
            return id;
        }

        public int getId_carte()
        {
            return id_carte;
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
