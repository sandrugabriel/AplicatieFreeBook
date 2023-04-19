using AplicatieFreeBook.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook.Panel_uri
{
    internal class pnlLogare:Panel
    {

        AplicatieFreeBook form;

        private Button btnLogare;
        private Label lblEmail;
        private Label lblParola;
        private TextBox txtEmail;
        private TextBox txtParola;

        ControllerUtilizatori controllerUtilizatori;
            
        public pnlLogare(AplicatieFreeBook from1)
        {
            form = from1;
            this.form.MaximumSize = new System.Drawing.Size(700, 460); 
            this.form.MinimumSize = new System.Drawing.Size(700, 460);
            this.form.Size = new System.Drawing.Size(700, 460);
            controllerUtilizatori = new ControllerUtilizatori();

            this.Name = "pnlLogare";
            this.Text = "Logare FreeBook";
            this.Size = new System.Drawing.Size(841, 460); 
            this.BackColor = System.Drawing.Color.Silver;

            this.btnLogare = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();

            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnLogare);

            // btnLogare
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnLogare.Location = new System.Drawing.Point(250, 323);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(171, 67);
            this.btnLogare.Text = "Logare";
            this.btnLogare.Click += new EventHandler(btnLogare_Click); 

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblEmail.Location = new System.Drawing.Point(83, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 30);
            this.lblEmail.Text = "Email";
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblParola.Location = new System.Drawing.Point(83, 203);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(78, 30);
            this.lblParola.Text = "Parola";
             
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(290, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 33);
             
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txtParola.Location = new System.Drawing.Point(290, 203);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(332, 34);


        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            if (controllerUtilizatori.verifAut(txtEmail.Text, txtParola.Text))
            {
                this.form.removePnl("pnlLogare");
                this.form.Controls.Add(new pnlMeniu(txtEmail.Text, form));
            }
            else
            {

                MessageBox.Show("Eroare autentificare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtParola.Text = "";
            }
        }



    }
}
