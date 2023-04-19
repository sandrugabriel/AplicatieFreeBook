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

    }
}
