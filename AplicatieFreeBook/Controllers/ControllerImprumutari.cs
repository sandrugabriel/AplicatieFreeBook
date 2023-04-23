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

        public ControllerImprumutari()
        {

            imprumuturi = new List<Imprumut>();
           
            load();
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
       

        public List<string> getBooks(DateTime nowtime)
        {
            List<string> cartiiNeimp = new List<string>();

            for(int i = 0; i < imprumuturi.Count; i++)
            {
                for (int j = 0; j < imprumuturi.Count; j++)
                { 
                    if (imprumuturi[i].getData_Imprumut().AddDays(30) <= nowtime && imprumuturi[i].getcarte().Equals(imprumuturi[j].getcarte()))
                    {
                        cartiiNeimp.Add(imprumuturi[j].getcarte());
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


       
    //functie ce returneaza numarul de imprumuturi

        public int contorImprumut(int idCarte)
        {
            int ct = 0;
            for(int i = 0; i < imprumuturi.Count; i++)
            {

                if (imprumuturi[i].getId_Carte() == idCarte)
                {
                    ct++;
                }

            }

            return ct;
        }

        public void eliminare(int[] v, int poz)
        {

            for(int i=poz;i<v.Length-1; i++)
            {
                v[i] = v[i + 1];
            }
            Array.Resize(ref v, v.Length - 1);
        }

        public int[] frecventa()
        {

            int[] f = new int[100];

            for(int i = 0; i < imprumuturi.Count; i++)
            {
                f[imprumuturi[i].getId_Carte()]++;
            }

            return f;
        }

        public int[] frecventaMaxi()
        {
            int[] fp = frecventa();

            Array.Sort(fp);
            Array.Reverse(fp);

            return fp;  
        }

        public List<int> iduri4Maxime()
        {
            int[] f = frecventa();
            List<int> idUriMaxime = new List<int>();

            int id1=0;
            for (int i = 0; i < 4; i++)
            {
                int maxi = -1;
                for (int j = 0; j < 23; j++)
                {
                    if (f[j] != 0 && f[j] > maxi)
                    {
                        maxi = f[j];
                        id1 = j;
                    }
                }
                eliminare(f, id1);
                idUriMaxime.Add(id1);
            }
            return idUriMaxime;
        }

        public List<string> listNume()
        {
            List<string> list = new List<string>();
            List<int> listid = iduri4Maxime();
            for (int i = 0; i < listid.Count; i++)
            { 
                //MessageBox.Show(listid[i].ToString());
                for (int j = 0; j < imprumuturi.Count; j++)
                {
                   
                    if(imprumuturi[j].getId_Carte() == listid[i])
                    {

                        list.Add(imprumuturi[j].getcarte());
                        break;
                    }
                }
            }

            return list;
        }

    }
}
