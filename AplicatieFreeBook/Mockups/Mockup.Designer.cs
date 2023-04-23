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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDisponibile = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprumutare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabImprum = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.titlu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStat = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabDisponibile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabImprum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDisponibile);
            this.tabControl1.Controls.Add(this.tabImprum);
            this.tabControl1.Controls.Add(this.tabStat);
            this.tabControl1.Location = new System.Drawing.Point(2, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 586);
            this.tabControl1.TabIndex = 2;
            // 
            // tabDisponibile
            // 
            this.tabDisponibile.Controls.Add(this.dataGridView1);
            this.tabDisponibile.Location = new System.Drawing.Point(4, 25);
            this.tabDisponibile.Name = "tabDisponibile";
            this.tabDisponibile.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisponibile.Size = new System.Drawing.Size(917, 557);
            this.tabDisponibile.TabIndex = 0;
            this.tabDisponibile.Text = "Carti disponibile";
            this.tabDisponibile.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titlu,
            this.autor,
            this.gen,
            this.imprumutare});
            this.dataGridView1.Location = new System.Drawing.Point(6, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 542);
            this.dataGridView1.TabIndex = 0;
            // 
            // titlu
            // 
            this.titlu.HeaderText = "Titlu";
            this.titlu.MinimumWidth = 6;
            this.titlu.Name = "titlu";
            this.titlu.ReadOnly = true;
            this.titlu.Width = 250;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.MinimumWidth = 6;
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            this.autor.Width = 190;
            // 
            // gen
            // 
            this.gen.HeaderText = "Gen";
            this.gen.MinimumWidth = 6;
            this.gen.Name = "gen";
            this.gen.ReadOnly = true;
            this.gen.Width = 200;
            // 
            // imprumutare
            // 
            this.imprumutare.HeaderText = "Imprumutare carte";
            this.imprumutare.MinimumWidth = 6;
            this.imprumutare.Name = "imprumutare";
            this.imprumutare.ReadOnly = true;
            this.imprumutare.Width = 207;
            // 
            // tabImprum
            // 
            this.tabImprum.Controls.Add(this.dataGridView2);
            this.tabImprum.Location = new System.Drawing.Point(4, 25);
            this.tabImprum.Name = "tabImprum";
            this.tabImprum.Padding = new System.Windows.Forms.Padding(3);
            this.tabImprum.Size = new System.Drawing.Size(917, 557);
            this.tabImprum.TabIndex = 1;
            this.tabImprum.Text = "Carti imprumutate";
            this.tabImprum.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titlu2,
            this.autor2,
            this.gen2,
            this.impr2});
            this.dataGridView2.Location = new System.Drawing.Point(8, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(901, 542);
            this.dataGridView2.TabIndex = 1;
            // 
            // titlu2
            // 
            this.titlu2.HeaderText = "Titlu";
            this.titlu2.MinimumWidth = 6;
            this.titlu2.Name = "titlu2";
            this.titlu2.ReadOnly = true;
            this.titlu2.Width = 250;
            // 
            // autor2
            // 
            this.autor2.HeaderText = "Autor";
            this.autor2.MinimumWidth = 6;
            this.autor2.Name = "autor2";
            this.autor2.ReadOnly = true;
            this.autor2.Width = 190;
            // 
            // gen2
            // 
            this.gen2.HeaderText = "Gen";
            this.gen2.MinimumWidth = 6;
            this.gen2.Name = "gen2";
            this.gen2.ReadOnly = true;
            this.gen2.Width = 200;
            // 
            // impr2
            // 
            this.impr2.HeaderText = "Imprumutare carte";
            this.impr2.MinimumWidth = 6;
            this.impr2.Name = "impr2";
            this.impr2.ReadOnly = true;
            this.impr2.Width = 207;
            // 
            // tabStat
            // 
            this.tabStat.Controls.Add(this.comboBox1);
            this.tabStat.Controls.Add(this.chart1);
            this.tabStat.Location = new System.Drawing.Point(4, 25);
            this.tabStat.Name = "tabStat";
            this.tabStat.Size = new System.Drawing.Size(917, 557);
            this.tabStat.TabIndex = 2;
            this.tabStat.Text = "Statistici biblioteca";
            this.tabStat.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(21, 56);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(611, 412);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "a"});
            this.comboBox1.Location = new System.Drawing.Point(638, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 43);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Mockup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(939, 648);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mockup";
            this.Text = "Mockup";
            this.tabControl1.ResumeLayout(false);
            this.tabDisponibile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabImprum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDisponibile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn imprumutare;
        private System.Windows.Forms.TabPage tabImprum;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn impr2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}