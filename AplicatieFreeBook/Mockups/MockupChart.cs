using AplicatieFreeBook.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AplicatieFreeBook.Mockups
{
    public partial class MockupChart : Form
    {
        ControllerImprumutari controllerImprumutari;
        private List<string> listName;
        DataPoint dataPoint;
        Series series;
        double[] list;
        public MockupChart()
        {
            InitializeComponent();
            dataPoint = new DataPoint(); 
            series = new Series();
            list = new double[2];
            list[0] = 23;
            list[1] = 12;
            dataPoint.XValue = 12;
            dataPoint.YValues = list;
            
           
            series.Points.Add(dataPoint);
           // chart1.Series.Add(series);
        }
    }
}
