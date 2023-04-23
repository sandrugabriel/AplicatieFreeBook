using AplicatieFreeBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicatieFreeBook.Controllers
{
    internal class ControllerUtilizatori
    {
        private List<Utilizator> utilizatorii;

        public ControllerUtilizatori() { 
        
            utilizatorii = new List<Utilizator>();

            load();
        }

        public void load() {

            string path = Application.StartupPath + @"/data/utilizatori.txt";

            StreamReader streamReader = new StreamReader(path);

            string text; 

            while((text = streamReader.ReadLine()) != null)
            {

                Utilizator a = new Utilizator(text);

                utilizatorii.Add(a);

            }

            streamReader.Close();

        }

        public bool verifEmail(string email)
        {

            for (int i = 0; i < utilizatorii.Count; i++)
            {

                if (utilizatorii[i].getemail() == email)
                {
                    return false;
                }

            }

            return true;
        }

        public void saveNewClient(string textul)
        {

            string path = Application.StartupPath + @"/data/utilizatori.txt";

            File.AppendAllText(path, textul + "\n");


        }

        public bool verifAut(string email, string parola)
        {

            for (int i = 0; i < utilizatorii.Count; i++)
            {

                if (utilizatorii[i].getemail() == email && utilizatorii[i].getpass() == parola)
                {
                    return true;
                }
            }

            return false;

        }

        public List<Utilizator> getUtilizator()
        {

            return utilizatorii;
        }

        public Utilizator getByid(int id)
        {

            for (int i = 0; i < utilizatorii.Count; i++)
            {
                if (id == utilizatorii[i].getId())
                {
                    return utilizatorii[i];
                }
            }

            return null;
        }

        public int generareID()
        {

            Random random = new Random();

            int id = random.Next();

            while (this.getByid(id) != null)
            {

                id = random.Next();


            }

            return id;
        }

    }
}
