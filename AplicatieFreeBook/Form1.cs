using AplicatieFreeBook.Panel_uri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook
{
    public partial class AplicatieFreeBook : Form
    {
        public AplicatieFreeBook()
        {
            InitializeComponent();

            this.Controls.Add(new pnlMeniu("gabi@gmail.com",this));


        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);
        }


    }
}
