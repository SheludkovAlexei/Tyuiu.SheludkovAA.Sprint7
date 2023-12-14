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
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        static int coll;
        static int rows;
        public FormMain()
        {
            InitializeComponent();
        }
        public string path;
        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonSave_SAA.Enabled = false;

        }
        public static string[,] Array(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            coll = lines[0].Split(';').Length;
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

        public void buttonOpen_SAA_Click(object sender, EventArgs e)
        {
            textBoxSearch_SAA.Text = "";
            buttonSave_SAA.Enabled = true;
            openFileDialog_SAA.ShowDialog();
            path = openFileDialog_SAA.FileName;
            string[,] res = Array(path);
            dataGridViewTabl_SAA.Columns.Clear();
            dataGridViewTabl_SAA.Rows.Clear();
            dataGridViewTabl_SAA.ColumnCount = coll;
            dataGridViewTabl_SAA.RowCount = rows;
            textBoxSearch_SAA.Enabled = true;
            buttonSearch_SAA.Enabled = true;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if (j == 0)
                    {
                        dataGridViewTabl_SAA.Rows[i].Cells[j].Value = res[i, j];
                        dataGridViewTabl_SAA.Columns[j].Width = 25;
                    }
                    else
                    {
                        dataGridViewTabl_SAA.Rows[i].Cells[j].Value = res[i, j];
                        dataGridViewTabl_SAA.Columns[j].Width = 100;
                        dataGridViewTabl_SAA.Rows[i].Height = 25;
                    }


                }
            }
        }

        private void buttonSave_SAA_Click(object sender, EventArgs e)
        {
            string ID = textBoxSearch_SAA.Text;
            if (ID == "")
            {
                saveFileDialog.FileName = "*.csv";
                saveFileDialog.InitialDirectory = @"C:\Users\Desktop";
                saveFileDialog.ShowDialog();


                string path1 = saveFileDialog.FileName;
                FileInfo fi = new FileInfo(path1);
                bool fe = fi.Exists;
                if (fe)
                {
                    File.Delete(path1);
                }
                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < coll; j++)
                    {
                        if (j != coll - 1)
                        {
                            str = str + dataGridViewTabl_SAA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewTabl_SAA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path1, str + Environment.NewLine);
                    str = "";
                }
            }
            else
            {
                MessageBox.Show("Выйдите из режима поиска \r(нажмите кнопку открыть файл)", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();

        }

        private void buttonSearch_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxSearch_SAA.Text);
                dataGridViewTabl_SAA.Columns.Clear();
                dataGridViewTabl_SAA.Rows.Clear();
                string[,] res = Array(path);
                dataGridViewTabl_SAA.ColumnCount = coll;
                dataGridViewTabl_SAA.RowCount = ID + 1;
                if (ID < rows)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < coll; j++)
                        {
                            if (i == ID)
                            {
                                if (j == 0)
                                {
                                    dataGridViewTabl_SAA.Rows[1].Cells[j].Value = res[i, j];
                                    dataGridViewTabl_SAA.Columns[j].Width = 25;
                                }
                                else
                                {
                                    dataGridViewTabl_SAA.Rows[1].Cells[j].Value = res[i, j];
                                    dataGridViewTabl_SAA.Columns[j].Width = 100;
                                    dataGridViewTabl_SAA.Rows[i].Height = 25;
                                }
                            }
                            else if (i == 0)
                            {
                                dataGridViewTabl_SAA.Rows[i].Cells[j].Value = res[i, j];
                            }

                        }
                    }

                }
                else
                {
                    dataGridViewTabl_SAA.Columns.Clear();
                    dataGridViewTabl_SAA.Rows.Clear();
                    MessageBox.Show("В базе данных нет такого количества элементов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Введите верные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListSortDirection list = new ListSortDirection();
            list = ListSortDirection.Ascending;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if (i > 0)
                    {
                        dataGridViewTabl_SAA.Sort(dataGridViewTabl_SAA.Columns[4], list);
                    }
                }
            }
        }
    }
}
