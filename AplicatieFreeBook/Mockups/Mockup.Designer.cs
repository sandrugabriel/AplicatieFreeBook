namespace AplicatieFreeBook.Mockups
{
    partial class Mockup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctImg = new System.Windows.Forms.PictureBox();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblTex2 = new System.Windows.Forms.Label();
            this.btnLogare = new System.Windows.Forms.Button();
            this.btnInreg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pctImg
            // 
            this.pctImg.Location = new System.Drawing.Point(48, 37);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(730, 376);
            this.pctImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImg.TabIndex = 0;
            this.pctImg.TabStop = false;
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(12, 12);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(792, 36);
            this.lblText1.TabIndex = 1;
            this.lblText1.Text = "FreeBook este o platforma care faciliteaza imprumutul de carti";
            // 
            // lblTex2
            // 
            this.lblTex2.AutoSize = true;
            this.lblTex2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTex2.Location = new System.Drawing.Point(44, 402);
            this.lblTex2.Name = "lblTex2";
            this.lblTex2.Size = new System.Drawing.Size(744, 24);
            this.lblTex2.TabIndex = 2;
            this.lblTex2.Text = "Fiecare utilizator are la dispozitie un numar de 3 carti pe care le poate imprumu" +
    "ta simultan";
            // 
            // btnLogare
            // 
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.Location = new System.Drawing.Point(195, 497);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(189, 70);
            this.btnLogare.TabIndex = 3;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
            // 
            // btnInreg
            // 
            this.btnInreg.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInreg.Location = new System.Drawing.Point(488, 497);
            this.btnInreg.Name = "btnInreg";
            this.btnInreg.Size = new System.Drawing.Size(189, 70);
            this.btnInreg.TabIndex = 4;
            this.btnInreg.Text = "Inregistrare";
            this.btnInreg.UseVisualStyleBackColor = true;
            // 
            // Mockup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 632);
            this.Controls.Add(this.btnInreg);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblTex2);
            this.Controls.Add(this.pctImg);
            this.Name = "Mockup";
            this.Text = "Mockup";
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImg;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblTex2;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Button btnInreg;
    }
}