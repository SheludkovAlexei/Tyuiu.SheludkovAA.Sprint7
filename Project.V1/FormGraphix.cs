using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.V1.Lib;
using System.IO;

namespace Project.V1
{
    public partial class FormGraphix : Form
    {
        DataService ds = new DataService();
        public FormGraphix()
        {
            InitializeComponent();
        }
        public string path1;
        static int rows;
        static int coll;
        static int cost;
        static int date;
            
        private void FormGraphix_Load(object sender, EventArgs e)
        {
            this.chartCost_SAA.ChartAreas[0].AxisX.Title = "Номер заказа";
            this.chartCost_SAA.ChartAreas[0].AxisY.Title = "Цена услуги";
            this.chartCost_SAA.Titles.Add("График прибыли");
            chartCost_SAA.Series[0].Points.Clear();
            string[,] res = Array(path1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if (i > 0)
                    {
                        chartCost_SAA.Series[0].Points.AddXY(i, res[i, j]);
                    }
                }
            }
            try
            {
                this.chartMec_SAA.ChartAreas[0].AxisX.Title = "День недели";
                this.chartMec_SAA.ChartAreas[0].AxisY.Title = "Количество посещений";
                this.chartMec_SAA.Titles.Add("График посещения");
                int[] mec = ds.mount(path1, date);
                for (int i = 1; i < mec.Length; i++)
                {
                    chartMec_SAA.Series[0].Points.AddXY(i, mec[i]);
                }
            }
            catch
            {
                chartMec_SAA.Visible = false;
            }

        }
        public static string[,] Array(string path)
        {
            
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            coll = lines[0].Split(';').Length;
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < coll; j++)
                {
                    try
                    {
                        int lin = Convert.ToInt32(strok[j]);
                        cost = j;
                    }
                    catch
                    {
                        continue;
                    }

                }
            }
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < coll; j++)
                {
                    try
                    {
                        DateTime lin1 = Convert.ToDateTime(strok[j]);
                        date = j;
                    }
                    catch
                    {
                        continue;
                    }

                }
            }
            string[,] mtr = new string[rows, coll];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < coll; j++)
                {
                    mtr[i, j] = strok[j];
                }
            }
            return mtr;
        }

        private void buttonCloseGraph_SAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
