using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Modul 2 Program 1
            InitializeComponent();
            chart1.Series[0].Name = "Sin1";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].Color = Color.Orange;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";

            chart3.Series[0].Name = "Sin2";
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart3.Series[0].BorderWidth = 5;
            chart3.Series[0].Color = Color.Purple;
            chart3.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chart3.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            timer2.Enabled = !(timer2.Enabled);
            if (timer1.Enabled && timer2.Enabled == true)
                button1.Text = "STOP";
            else
                button1.Text = "START";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
            double y = amplitude * Math.Sin(2 * Math.PI * frequency * time);
            chart1.Series[0].Points.AddXY(time, y);
            time += 0.01;

            if (chart1.Series[0].Points.Count > 40)
            {
                chart1.ChartAreas[0].AxisX.Minimum = time - (0.01*40);
                chart1.ChartAreas[0].AxisX.Maximum = time;
                
            }
           
        }
        private double time = 0.0;
        private double amplitude = 50.0;
        private double frequency = 2.0;

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = (int)numericUpDown2.Value;
            double y2 = amplitude * Math.Sin(2 * Math.PI * frequency * time);
            chart3.Series[0].Points.AddXY(time, y2);
            time += 0.01;

            if (chart3.Series[0].Points.Count > 40)
            {
                chart3.ChartAreas[0].AxisX.Minimum = time - (0.01 * 40);
                chart3.ChartAreas[0].AxisX.Maximum = time;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = !(numericUpDown1.Enabled);
            numericUpDown2.Enabled = !(numericUpDown2.Enabled);
            if (numericUpDown1.Enabled && numericUpDown2.Enabled == true)
                button2.Text = "Set";
            else
                button2.Text = "Reset";
        }
    }
}
