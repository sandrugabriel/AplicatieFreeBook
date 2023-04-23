using AplicatieFreeBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook.Controllers
{
    internal class ControllerCarti
    {

        private List<Carte> carti;

        public ControllerCarti()
        {

            carti = new List<Carte>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/carti.txt";
            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {
                Carte a = new Carte(text);
                carti.Add(a);
            }


            streamReader.Close();
        }

        public List<Carte> getCarti()
        {

            return carti;
        }

        public List<Carte> getCartiNeimprum(List<string> stringCarti)
        {
            List<Carte> books = new List<Carte>();

            for(int i = 0; i < stringCarti.Count; i++)
            {
                for(int j = 0; j < carti.Count; j++)
                {
                    if (stringCarti[i].Equals(carti[j].getTitlu()))
                    {
                        books.Add(carti[j]);
                        
                    }
                }
            }


            return books;
        }

    }
}
