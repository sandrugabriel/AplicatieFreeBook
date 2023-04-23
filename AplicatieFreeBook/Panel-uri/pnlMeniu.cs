using AplicatieFreeBook.Controllers;
using AplicatieFreeBook.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
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
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn id2;
        private DataGridViewTextBoxColumn titlu2;
        private DataGridViewTextBoxColumn autor2;
        private DataGridViewTextBoxColumn dataImpr2;
        private DataGridViewTextBoxColumn datadispon2;
        private Chart chart;
        private ChartArea chartArea;
        private  Series series;
        private List<string> listNume;
        private int[] listFrecventa;
        private Legend legend;
        private System.Windows.Forms.ComboBox comboBox;

        AplicatieFreeBook form;

        ControllerCarti controllerCarti;
        ControllerImprumutari controllerImprumutari;

        private string email;

        private List<Carte> cartiList;
        private List<string> stringCarti;
        private List<Carte> imprList;

        public pnlMeniu(string email1, AplicatieFreeBook form1)
        {

            form = form1; 
            this.form.MaximumSize = new System.Drawing.Size(939, 688);
            this.form.MinimumSize = new System.Drawing.Size(939, 688);
            email = email1;

            //PnlMeniu
            this.BackColor = System.Drawing.Color.Silver;
            this.Size = new System.Drawing.Size(939, 648);
            this.Name = "pnlMeniu";
            this.Text = "Meniu FreeBook";

            //New
            this.controllerImprumutari = new ControllerImprumutari();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.imprumutare = new DataGridViewTextBoxColumn();
            this.datadispon2 = new DataGridViewTextBoxColumn();
            this.dataImpr2 = new DataGridViewTextBoxColumn();
            this.titlu2 = new DataGridViewTextBoxColumn();
            this.autor2 = new DataGridViewTextBoxColumn();
            this.controllerCarti = new ControllerCarti();
            this.titlu = new DataGridViewTextBoxColumn();
            this.autor = new DataGridViewTextBoxColumn();
            this.id2 = new DataGridViewTextBoxColumn();
            this.gen = new DataGridViewTextBoxColumn();
            this.id = new DataGridViewTextBoxColumn();
            this.dataGridView2 = new DataGridView();
            this.dataGridView1 = new DataGridView();
            this.tabControl1 = new TabControl();
            this.tabDisponibile = new TabPage();
            this.cartiList = new List<Carte>();
            this.listNume = new List<string>();
            this.listFrecventa = new int[100];
            this.imprList = new List<Carte>();
            this.chartArea = new ChartArea();
            this.tabImprum = new TabPage();
            this.tabStat = new TabPage();
            this.series = new Series();
            this.legend = new Legend();
            this.label1 = new Label();
            this.label2 = new Label();
            this.chart = new Chart();

            //Add
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);

            // label1
            labels(label1,new Point(12,9), "Email:");

            // label2
            labels(label2, new System.Drawing.Point(55, 9), email);

            // tabControl1
            tabControl();

            // tabDisponibile
            tabdisponibile();

            // tabImprum
            tabimprum();

            //chart
            createChart();

            //ComboBox
            createComboBox();
          
            // tabStat
            tabstart();

            // dataGridView1
            datagrid1();

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

            // dataGridView2
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.titlu2,
            this.autor2,
            this.dataImpr2,
            this.datadispon2});
            this.dataGridView2.Location = new System.Drawing.Point(8, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(901,300);
            this.dataGridView2.CellClick += new DataGridViewCellEventHandler(this.dataGridView2_CellClick);

            // id2
            this.id2.HeaderText = "Id";
            this.id2.MinimumWidth = 6;
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Width = 60;

            // titlu2
            this.titlu2.HeaderText = "Titlu";
            this.titlu2.MinimumWidth = 6;
            this.titlu2.Name = "titlu2";
            this.titlu2.ReadOnly = true;
            this.titlu2.Width = 250;
             
            // autor2
            this.autor2.HeaderText = "Autor";
            this.autor2.MinimumWidth = 6;
            this.autor2.Name = "autor2";
            this.autor2.ReadOnly = true;
            this.autor2.Width = 190;
             
            // dataimpr
            this.dataImpr2.HeaderText = "Data imprumutari";
            this.dataImpr2.MinimumWidth = 6;
            this.dataImpr2.Name = "dataImpr2";
            this.dataImpr2.ReadOnly = true;
            this.dataImpr2.Width = 180;

            // datadipsonipil
            this.datadispon2.HeaderText = "Data disponibilatate";
            this.datadispon2.MinimumWidth = 6;
            this.datadispon2.Name = "datadispon2";
            this.datadispon2.ReadOnly = true;
            this.datadispon2.Width = 180;

        }

        private void labels(Label label , Point point, string text)
        {

            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            label.Location = point;
            label.Text = text;


        }

        private void tabControl()
        {
            this.tabControl1.Controls.Add(this.tabDisponibile);
            this.tabControl1.Controls.Add(this.tabImprum);
            this.tabControl1.Controls.Add(this.tabStat);
            this.tabControl1.Location = new System.Drawing.Point(2, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(925, 586);

        }

        private void tabdisponibile() {

            this.tabDisponibile.Controls.Add(this.dataGridView1);
            this.tabDisponibile.Location = new System.Drawing.Point(4, 25);
            this.tabDisponibile.Name = "tabDisponibile";
            this.tabDisponibile.Size = new System.Drawing.Size(917, 557);
            this.tabDisponibile.Text = "Carti disponibile";

        }

        private void tabimprum()
        {

            this.tabImprum.Controls.Add(this.dataGridView2);
            this.tabImprum.Location = new System.Drawing.Point(4, 25);
            this.tabImprum.Name = "tabImprum";
            this.tabImprum.Size = new System.Drawing.Size(917, 557);
            this.tabImprum.Text = "Carti imprumutate";

        }

        private void createChart()
        {
            listFrecventa = controllerImprumutari.frecventaMaxi();
            listNume = controllerImprumutari.listNume();

            this.chart.Location = new System.Drawing.Point(10, 51);
            this.chart.Size = new System.Drawing.Size(611, 412);
            this.chart.Legends.Add(legend);
            this.chart.Name = "chart";
            this.chart.Text = "chart";
            this.chart.Series.Add(series);
            this.chart.ChartAreas.Add(chartArea);

            this.chartArea.Name = "ChartArea";
            this.legend.Name = "Legend";
            this.series.ChartType = SeriesChartType.Pie;

            for (int i = 0; i < listNume.Count; i++)
            {
                DataPoint datapoint = new DataPoint(0, listFrecventa[i]);
                datapoint.Label = listFrecventa[i].ToString();
                datapoint.LegendText = listNume[i];
                series.Points.Add(datapoint);
            }
        }

        private void createComboBox()
        {
            this.comboBox.Location = new System.Drawing.Point(670, 68);
            this.comboBox.Size = new System.Drawing.Size(130, 30);
            this.comboBox.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.comboBox.Text = "Style";
            this.comboBox.Items.Add("StackedArea");
            this.comboBox.Items.Add("Pie");
            this.comboBox.Items.Add("Column");
            this.comboBox.Items.Add("Pyramid");
            this.comboBox.Items.Add("Area");
            this.comboBox.Sorted = true;
            this.comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);

        }

        private void datagrid1()
        {

            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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

            stringCarti = controllerImprumutari.getBooks(DateTime.Now);
            cartiList = controllerCarti.getCartiNeimprum(stringCarti);

            foreach (var produs in cartiList)
            {
                dataGridView1.Rows.Add(produs.getId(), produs.getTitlu(), 
                                 produs.getAutor(), produs.getGen(), "");
            }

        }

        private void tabstart()
        {
            this.tabStat.Controls.Add(chart);
            this.tabStat.Controls.Add(comboBox);
            this.tabStat.Location = new System.Drawing.Point(4, 25);
            this.tabStat.Name = "tabStat";
            this.tabStat.Size = new System.Drawing.Size(917, 557);
            this.tabStat.Text = "Statistici biblioteca";
        }

        private void styleOne()
        {

            this.series.Points.Clear();

            for(int i=0;i<listNume.Count;i++)
            {
                DataPoint dataPoint = new DataPoint(0, listFrecventa[i]);
                dataPoint.Label = listNume[i];
                this.series.Points.Add(dataPoint);
            }
            this.series.Name = "Carti";

        }

        private void styleTwo()
        {
            this.series.Points.Clear();

            for( int i=0; i < listNume.Count; i++)
            {
                DataPoint dataPoint = new DataPoint(0, listFrecventa[i]);
                dataPoint.Label = listFrecventa[i].ToString();
                dataPoint.LegendText = listNume[i];
                this.series.Points.Add( dataPoint );
            }

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox.SelectedItem.ToString().Equals("Area"))
            {
                this.series.ChartType = SeriesChartType.Area;
                styleOne();
            }

            if (comboBox.SelectedItem.ToString().Equals("Column"))
            {
                this.series.ChartType = SeriesChartType.Column;
                styleOne();
            }

            if (comboBox.SelectedItem.ToString().Equals("Pie"))
            {
                this.series.ChartType = SeriesChartType.Pie;
                styleTwo();
            }

            if (comboBox.SelectedItem.ToString().Equals("Pyramid"))
            {
                this.series.ChartType = SeriesChartType.Pyramid;
                styleTwo();
            }

            if (comboBox.SelectedItem.ToString().Equals("StackedArea"))
            {
                this.series.ChartType = SeriesChartType.StackedArea;
                styleOne();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (imprList.Count < 3)
            {
                if (e.ColumnIndex == dataGridView1.Columns["imprumutare"].Index && e.RowIndex >= 0)
                {

                    if (imprList.Count > 1)
                    {

                        MessageBox.Show("Poti sa imprumuti maxim 3 carti");
                        tabControl1.SelectTab("tabImprum");

                    }

                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    string titlu = dataGridView1.Rows[e.RowIndex].Cells["titlu"].Value.ToString();
                    string autor = dataGridView1.Rows[e.RowIndex].Cells["autor"].Value.ToString();
                    string gen = dataGridView1.Rows[e.RowIndex].Cells["gen"].Value.ToString();
                    Carte a = new Carte(id, titlu, autor, gen);
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    dataGridView1.Rows.Remove(row);
                    string text = controllerImprumutari.generareId().ToString() + "*" + titlu + "*" + email + "*" + DateTime.Now.ToString();
                    controllerImprumutari.saveNewImprumut(text);
                    dataGridView2.Rows.Add(a.getId(), a.getTitlu(), a.getAutor(), DateTime.Now, DateTime.Now.AddDays(30));
                    imprList.Add(a);



                }
            }


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView2.Columns["titlu2"].Index && e.RowIndex >= 0)
            {
                int id1 = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["id2"].Value.ToString());




            }
            


        }

    }
}
