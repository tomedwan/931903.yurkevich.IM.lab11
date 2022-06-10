using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] probs, freq, stat;
        int N; double chi = 9.488; double X;

        public double[] calculation(double[] probability, int number_experiment)
        {
            double[] Statistic = new double[5];
            Random rnd = new Random();
            
            for (int i = 0; i < number_experiment; i++)
            {
                double K = rnd.NextDouble();
                int event_id = 0;
                
                K -= probability[0];
                
                while (K > 0)
                {
                    event_id++;
                    K -= probability[event_id];
                };
                
                Statistic[event_id]++;
            }
            
            return Statistic;
        }

        public double Expected_value(double[] frenquesy)
        {
            double E = 0;

            for (int i = 0; i < 5; i++)
            {
                E += (i + 1) * frenquesy[i];
            }

            return E;
        }

        public double Dispersion(double[] frenquesy)
        {
            double E = Expected_value(frenquesy);
            double D = 0;

            for (int i = 0; i < 5; i++)
            {
                D += frenquesy[i] * ((i + 1) - E) * ((i + 1) - E);
            }

            return D;
        }

        public double Chi_square(double[] stat, double[] probs, int n)
        {
            double Chi = 0;

            for (int i = 0; i < 5; i++)
            {
                if (stat[i] != 0) Chi += (stat[i] * stat[i]) / (n * probs[i]);
            }

            return (Chi - n);
        }

        private void toGo_Click(object sender, EventArgs e)
        {
            double expected_value, dispersion_value;
            probs = new double[5]; stat = new double[5]; freq = new double[5];

            probs[0] = (double)prob1.Value;
            probs[1] = (double)prob2.Value;
            probs[2] = (double)prob3.Value;
            probs[3] = (double)prob4.Value;
            probs[4] = 1 - probs[0] - probs[1] - probs[2] - probs[3];
            prob5.Text = probs[4].ToString();

            N = (int)tbN.Value;

            double[] st = calculation(probs, N);
            Array.Copy(st, stat, 5);
           
            for( int i = 0; i < 5;i++)
            {
                freq[i] = st[i] / N;
            }

            expected_value = Expected_value(freq);
            dispersion_value = Dispersion(freq);

            textBox1.Text = expected_value.ToString();
            textBox2.Text = dispersion_value.ToString();

            chart1.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series.Add(series);
            for (int i = 0; i < 5; i++) chart1.Series[0].Points.AddXY(i + 1, freq[i]);

            X = Chi_square(st, probs, N);

            textBox4.Text = X.ToString();
            if (X < chi)
            {
                label12.Text = "<";
                label13.ForeColor = Color.Green;
                label13.Text = "TRUE";
            }
            else
            {
                label12.Text = ">";
                label13.ForeColor = Color.Red;
                label13.Text = "FALSE";
            }
        }
    }
}
