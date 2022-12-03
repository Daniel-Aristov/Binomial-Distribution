using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teorVer_4
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.ChartDistribution.Series[0].Points.Clear();
            this.ChartDistribution.Series[1].Points.Clear();
        }

        private void btn_modelling_Click(object sender, EventArgs e)
        {
            this.ChartDistribution.Series[0].Points.Clear();
            this.ChartDistribution.Series[1].Points.Clear();

            double p = Convert.ToDouble(ProbabilityInput.Text.Replace(".", ","));
            double q = 1 - p;

            int n = Convert.ToInt32(TestsInSeriesInput.Text);
            int N = Convert.ToInt32(CountSeriesInput.Text);

            int[] Nk = new int[n + 1];
            int num;
            double x;
            Random r = new Random();

            for (int i = 0; i < N; i++)
            {
                num = 0;
                for (int j = 0; j < n; j++)
                {
                    x = r.NextDouble();
                    if (x <= p)
                    {
                        num += 1;
                    }
                }

                Nk[num] += 1;
            }

            for (int k = 0; k <= n; k++)
            {
                Console.WriteLine(Nk[k] / (double)N);
                this.ChartDistribution.Series[0].Points.AddXY(k, Nk[k] / (double)N);
            }

            double g, n1, n2, n3;

            for (int k = 0; k <= n; k++)
            {
                n1 = 0; n2 = 0; n3 = 0;

                if (k == 0)
                {
                    g = n * Math.Log(q);
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        n1 += Math.Log(i);
                    }

                    for (int i = 1; i <= k; i++)
                    {
                        n2 += Math.Log(i);
                    }

                    for (int i = 1; i <= n - k; i++)
                    {
                        n3 += Math.Log(i);
                    }

                    g = n1 - n2 - n3 + k * Math.Log(p) + (n - k) * Math.Log(q);
                }

                this.ChartDistribution.Series[1].Points.AddXY(k, Math.Exp(g));
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.ChartDistribution.Series[0].Points.Clear();
            this.ChartDistribution.Series[1].Points.Clear();

            ProbabilityInput.Clear();
            TestsInSeriesInput.Clear();
            CountSeriesInput.Clear();
        }
    }
}
