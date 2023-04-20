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
    internal class ControllerImprumutari
    {

        private List<Imprumut> imprumuturi;
        private List<Carte> cartii;

        public ControllerImprumutari()
        {

            imprumuturi = new List<Imprumut>();
            cartii = new List<Carte>();
            load();
            load1();
        }
        
        public void load() {

            string path = Application.StartupPath + @"/data/imprumuturi.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while ((text = streamReader.ReadLine()) != null)
            {

                Imprumut a = new Imprumut(text);

                imprumuturi.Add(a);

            }

            streamReader.Close();




        }
        public void load1()
        {

            string path = Application.StartupPath + @"/data/carti.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while ((text = streamReader.ReadLine()) != null)
            {

                Carte a = new Carte(text);

                cartii.Add(a);

            }

            streamReader.Close();




        }

        public List<Carte> getCartes(DateTime nowtime)
        {
            List<Carte> cartiiNeimp = new List<Carte>();

            for(int i = 0; i < imprumuturi.Count; i++)
            {
                for (int j = 0; j < cartii.Count; j++)
                { 
                    if (imprumuturi[i].getData_Imprumut().AddDays(30) <= nowtime && imprumuturi[i].getcarte().Equals(cartii[j].getTitlu()))
                    {
                        cartiiNeimp.Add(cartii[j]);
                    }
                }
               
            }
            cartiiNeimp = cartiiNeimp.Distinct().ToList();
            return cartiiNeimp;
        }
        public void saveNewImprumut(string textul)
        {

            string path = Application.StartupPath + @"/data/imprumuturi.txt";

            File.AppendAllText(path, textul + "\n");


        }

        public Imprumut getByid(int id)
        {

            for (int i = 0; i < imprumuturi.Count; i++)
            {
                if (id == imprumuturi[i].getId())
                {
                    return imprumuturi[i];
                }
            }

            return null;
        }

        public int generareId()
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
