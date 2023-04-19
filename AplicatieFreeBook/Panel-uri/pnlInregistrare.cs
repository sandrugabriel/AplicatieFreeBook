using AplicatieFreeBook.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook.Panel_uri
{
    internal class pnlInregistrare:Panel
    {
        private Button btnInreg;
        private Label lblNume;
        private Label lblEmail;
        private Label lblConfParola;
        private Label lblParola;
        private Label lblPrenume;
        private TextBox txtEmail;
        private TextBox txtConfParola;
        private TextBox txtParola;
        private TextBox txtPrenume;
        private TextBox txtNume;

        private List<string> erori;

        ControllerUtilizatori controllerUtilizatori;

        AplicatieFreeBook form;

        public pnlInregistrare(AplicatieFreeBook form1)
        {
            controllerUtilizatori = new ControllerUtilizatori();
            form = form1;
            erori = new List<string>();
            this.Name = "pnlInregistrare";
            this.Text = "Creeaza Cont FreeBook";
            this.BackColor = System.Drawing.Color.Silver;
            this.Size = new System.Drawing.Size(833, 632);

            this.btnInreg = new Button();
            this.lblNume = new Label();
            this.lblEmail = new Label();
            this.lblConfParola = new Label();
            this.lblParola = new Label();
            this.lblPrenume = new Label();
            this.txtEmail = new TextBox();
            this.txtConfParola = new TextBox();
            this.txtParola = new TextBox();
            this.txtPrenume = new TextBox();
            this.txtNume = new TextBox();

            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtConfParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblConfParola);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.btnInreg);

            // btnInreg
            this.btnInreg.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnInreg.Location = new System.Drawing.Point(306, 516);
            this.btnInreg.Name = "btnInreg";
            this.btnInreg.Size = new System.Drawing.Size(171, 67);
            this.btnInreg.Text = "Inregistrare";
            this.btnInreg.Click += new EventHandler(btnInreg_Click);

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblNume.Location = new System.Drawing.Point(83, 171);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(77, 30);
            this.lblNume.Text = "Nume";
            
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblEmail.Location = new System.Drawing.Point(83, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 30);
            this.lblEmail.Text = "Email";
             
            // lblConfParola
            this.lblConfParola.AutoSize = true;
            this.lblConfParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblConfParola.Location = new System.Drawing.Point(83, 371);
            this.lblConfParola.Name = "lblConfParola";
            this.lblConfParola.Size = new System.Drawing.Size(200, 30);
            this.lblConfParola.TabIndex = 7;
            this.lblConfParola.Text = "Confirmare parola";
            
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblParola.Location = new System.Drawing.Point(83, 303);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(78, 30);
            this.lblParola.Text = "Parola";
            
            // lblPrenume
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblPrenume.Location = new System.Drawing.Point(83, 240);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(107, 30);
            this.lblPrenume.Text = "Prenume";
             
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(383, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 33);
            
            // txtConfParola
            this.txtConfParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txtConfParola.Location = new System.Drawing.Point(383, 371);
            this.txtConfParola.Name = "txtConfParola";
            this.txtConfParola.Size = new System.Drawing.Size(332, 34);
             
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txtParola.Location = new System.Drawing.Point(383, 303);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(332, 34);

            // txtPrenume
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txtPrenume.Location = new System.Drawing.Point(383, 240);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(332, 34);
             
            // txtNume
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txtNume.Location = new System.Drawing.Point(383, 171);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(332, 34);


        }

        public void eroriVerif()
        {
            erori.Clear();

            if (txtNume.Text.Equals(""))
            {
                erori.Add("Nu ati introdus numele");
            }
            if (txtPrenume.Text.Equals(""))
            {
                erori.Add("Nu ati introdus prenumele");
            }
            if (txtEmail.Text.Equals("") || controllerUtilizatori.verifEmail(txtEmail.Text) == false)
            {
                txtEmail.Text = "";
                txtEmail.Focus();
                erori.Add("Nu ati introdus email");
            }

            if (!txtParola.Text.Equals(txtConfParola.Text))
            {
                erori.Add("Parola nu se potriveste");
                txtParola.Text = "";
                txtConfParola.Text = "";
            }
           
        }

        public void btnInreg_Click(object sender, EventArgs e)
        {

            eroriVerif();

            if (erori.Count > 0)
            {

                for (int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i], "Erori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                string nume = txtNume.Text;
                string prenume = txtPrenume.Text;
                string parola = txtParola.Text;
                string email = txtEmail.Text;

                string textul = email + "*" + parola + "*" + nume + "*" + prenume;
                controllerUtilizatori.saveNewClient(textul);
                this.form.removePnl("pnlInregistrare");

            }




        }


    }
}
