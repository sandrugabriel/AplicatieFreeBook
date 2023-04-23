using AplicatieFreeBook.Controllers;
using AplicatieFreeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AplicatieFreeBook());

           // ControllerImprumutari controllerImprumutari = new ControllerImprumutari();
          //  List<int> list = controllerImprumutari.iduri4Maxime();
           // for (int i = 0; i < list.Count; i++)
           //    MessageBox.Show(list[i].ToString());
        }
    }
}
