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
            //INI Program 2 Modul 2

            InitializeComponent();
            //chart1
            chart1.Series[0].Name = "Series A";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].Color = Color.Red;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            //chart2
            chart2.Series[0].Name = "Series B";
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series[0].BorderWidth = 3;
            chart2.Series[0].Color = Color.Purple;
            chart2.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
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
            double amplitude = (double)numericUpDown4.Value;
            double frequency = (double)numericUpDown3.Value;
            //double y = amplitude * Math.Sin(2 * Math.PI * frequency * time);
            //chart1.Series[0].Points.AddXY(time, y);
            time += 0.01;
            if (checkBox1.Checked)
            {
                double ysin = amplitude * Math.Sin(2 * Math.PI * frequency * time);
                chart1.Series[0].Points.AddXY(time, ysin);
            }
            else if (checkBox2.Checked)
            {
                double ycos = amplitude * Math.Cos(2 * Math.PI * frequency * time);
                chart1.Series[0].Points.AddXY(time, ycos);
            }
            else if (checkBox3.Checked)
            {
                double ytan = amplitude * Math.Tan(2 * Math.PI * frequency * time);
                chart1.Series[0].Points.AddXY(time, ytan);
            }
           
            if (chart1.Series[0].Points.Count > 40)
            {
                chart1.ChartAreas[0].AxisX.Minimum = time - (0.01*40);
                chart1.ChartAreas[0].AxisX.Maximum = time;
            }
        }
        private double time = 0.0;

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = (int)numericUpDown2.Value;
            double amplitude = (double)numericUpDown4.Value;
            double frequency = (double)numericUpDown3.Value;
            //double y = amplitude * Math.Cos(2 * Math.PI * frequency * time);
            //chart2.Series[0].Points.AddXY(time, y);
            time += 0.01;
            if (checkBox6.Checked)
            {
                double y2sin = amplitude * Math.Sin(2 * Math.PI * frequency * time);
                chart2.Series[0].Points.AddXY(time, y2sin);
            }
            else if (checkBox5.Checked)
            {
                double y2cos = amplitude * Math.Cos(2 * Math.PI * frequency * time);
                chart2.Series[0].Points.AddXY(time, y2cos);
            }
            else if (checkBox4.Checked)
            {
                double y2tan = amplitude * Math.Tan(2 * Math.PI * frequency * time);
                chart2.Series[0].Points.AddXY(time, y2tan);
            }

            if (chart2.Series[0].Points.Count > 40)
            {
                chart2.ChartAreas[0].AxisX.Minimum = time - (0.01 * 40);
                chart2.ChartAreas[0].AxisX.Maximum = time;
            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = !(numericUpDown3.Enabled);
            numericUpDown4.Enabled = !(numericUpDown4.Enabled);
            if (numericUpDown3.Enabled && numericUpDown4.Enabled == true)
            {
                button2.Text = "Set";
            }
            else
            {
                button2.Text = "Reset";
            }
        }
    }
}
