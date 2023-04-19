using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook.Panel_uri
{
    internal class pnlStart:Panel
    {

        private PictureBox pctImg;
        private Label lblText1;
        private Label lblTex2;
        private Button btnLogare;
        private Button btnInreg;

        public pnlStart()
        {

            this.Size = new System.Drawing.Size(902, 697);
            this.Name = "pnlStart";
            this.Text = "Start";

            this.pctImg = new PictureBox();
            this.lblText1 = new Label();
            this.lblTex2 = new Label();
            this.btnLogare = new Button();
            this.btnInreg = new Button();

            this.Controls.Add(this.btnInreg);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblTex2);
            this.Controls.Add(this.pctImg);

            // pctImg
            this.pctImg.Location = new System.Drawing.Point(48, 55);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(630, 356);
            this.pctImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            string path = Application.StartupPath + @"/imagini/sigla_Biblioteca_3.jpg";
            this.pctImg.Image = Image.FromFile(path);
             
            // lblText1
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblText1.Location = new System.Drawing.Point(40, 12);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(792, 36);
            this.lblText1.Text = "FreeBook este o platforma care faciliteaza imprumutul de carti";
             
            // lblTex2
            this.lblTex2.AutoSize = true;
            this.lblTex2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.lblTex2.Location = new System.Drawing.Point(55, 415);
            this.lblTex2.Name = "lblTex2";
            this.lblTex2.Size = new System.Drawing.Size(744, 24);
            this.lblTex2.Text = "Fiecare utilizator are la dispozitie un numar de 3 carti pe care le poate imprumuta simultan";
             
            // btnLogare
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.btnLogare.Location = new System.Drawing.Point(130, 475);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(189, 70);
            this.btnLogare.Text = "Logare";
             
            // btnInreg
            this.btnInreg.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.btnInreg.Location = new System.Drawing.Point(370, 475);
            this.btnInreg.Name = "btnInreg";
            this.btnInreg.Size = new System.Drawing.Size(189, 70);
            this.btnInreg.Text = "Inregistrare";

        }





    }
}
