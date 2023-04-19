using AplicatieFreeBook.Controllers;
using AplicatieFreeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicatieFreeBook.Panel_uri
{
    internal class pnlMeniu:Panel
    {
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabDisponibile;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn titlu;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn gen;
        private DataGridViewTextBoxColumn imprumutare;
        private TabPage tabImprum;
        private TabPage tabStat;

        AplicatieFreeBook form;

        ControllerCarti controllerCarti;
        ControllerImprumutari controllerImprumutari;

        private string email;

        private List<Carte> cartiList;

        private List<Carte> imprList;

        public pnlMeniu(string email1, AplicatieFreeBook form1)
        {
            form = form1;
            this.form.MaximumSize = new System.Drawing.Size(939, 688);
            this.form.MinimumSize = new System.Drawing.Size(939, 688);
            this.BackColor = System.Drawing.Color.Silver;
            this.Size = new System.Drawing.Size(939, 648);
            email = email1;
            controllerCarti = new ControllerCarti();
            controllerImprumutari = new ControllerImprumutari();
            cartiList = new List<Carte>();
            imprList = new List<Carte>();

            this.Name = "pnlMeniu";
            this.Text = "Meniu FreeBook";

            this.label1 = new Label();
            this.label2 = new Label();
            this.tabControl1 = new TabControl();
            this.tabDisponibile = new TabPage();
            this.tabImprum = new TabPage();
            this.tabStat = new TabPage();
            this.dataGridView1 = new DataGridView();
            this.id = new DataGridViewTextBoxColumn();
            this.titlu = new DataGridViewTextBoxColumn();
            this.autor = new DataGridViewTextBoxColumn();
            this.gen = new DataGridViewTextBoxColumn();
            this.imprumutare = new DataGridViewTextBoxColumn();

            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.Text = "Email:";
             
            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.label2.Location = new System.Drawing.Point(55, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.Text = email;
             
            // tabControl1
            this.tabControl1.Controls.Add(this.tabDisponibile);
            this.tabControl1.Controls.Add(this.tabImprum);
            this.tabControl1.Controls.Add(this.tabStat);
            this.tabControl1.Location = new System.Drawing.Point(2, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(925, 586);
             
            // tabDisponibile
            this.tabDisponibile.Controls.Add(this.dataGridView1);
            this.tabDisponibile.Location = new System.Drawing.Point(4, 25);
            this.tabDisponibile.Name = "tabDisponibile";
            this.tabDisponibile.Size = new System.Drawing.Size(917, 557);
            this.tabDisponibile.Text = "Carti disponibile";
             
            // tabImprum
            this.tabImprum.Location = new System.Drawing.Point(4, 25);
            this.tabImprum.Name = "tabImprum";
            this.tabImprum.Size = new System.Drawing.Size(917, 557);
            this.tabImprum.Text = "Carti imprumutate";
            
            // tabStat
            this.tabStat.Location = new System.Drawing.Point(4, 25);
            this.tabStat.Name = "tabStat";
            this.tabStat.Size = new System.Drawing.Size(917, 557);
            this.tabStat.Text = "Statistici biblioteca";
             
            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titlu,
            this.autor,
            this.gen,
            this.imprumutare});
            this.dataGridView1.Location = new System.Drawing.Point(6, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 542);
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            cartiList = controllerImprumutari.getCartes(DateTime.Now);
            foreach (var produs in cartiList)
            {
                dataGridView1.Rows.Add(produs.getId(),produs.getTitlu(), produs.getAutor(), produs.getGen(),"");
            }

            // id
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 90;

            // titlu
            this.titlu.HeaderText = "Titlu";
            this.titlu.MinimumWidth = 6;
            this.titlu.Name = "titlu";
            this.titlu.ReadOnly = true;
            this.titlu.Width = 250;
             
            // autor
            this.autor.HeaderText = "Autor";
            this.autor.MinimumWidth = 6;
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            this.autor.Width = 190;
            
            // gen
            this.gen.HeaderText = "Gen";
            this.gen.MinimumWidth = 6;
            this.gen.Name = "gen";
            this.gen.ReadOnly = true;
            this.gen.Width = 200;
             
            // imprumutare
            this.imprumutare.HeaderText = "Imprumutare carte";
            this.imprumutare.MinimumWidth = 6;
            this.imprumutare.Name = "imprumutare";
            this.imprumutare.ReadOnly = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["imprumutare"].Index && e.RowIndex >= 0)
            {

                if(imprList.Count > 3) {

                    MessageBox.Show("Poti sa imprumuti maxim 3 carti");
                    tabControl1.SelectTab("tabImprum");
                
                }

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                string titlu = dataGridView1.Rows[e.RowIndex].Cells["titlu"].Value.ToString();
                string autor = dataGridView1.Rows[e.RowIndex].Cells["autor"].Value.ToString();
                string gen = dataGridView1.Rows[e.RowIndex].Cells["gen"].Value.ToString();
                Carte a = new Carte(id,titlu, autor,gen);
                imprList.Add(a);
            }
        }


    }
}
