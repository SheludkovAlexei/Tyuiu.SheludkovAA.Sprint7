﻿using System;
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
        
        static int cost;
        static int date;
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

        public void buttonOpen_SAA_Click(object sender, EventArgs e)
        {
            textBoxSearch_SAA.Text = "";
            buttonSave_SAA.Enabled = true;
            openFileDialog_SAA.ShowDialog();
            path = openFileDialog_SAA.FileName;
            string[,] res = Array(path);
            textBoxZarabotok_SAA.Text = Convert.ToString(ds.Pribil(path,cost));
            textBoxYslyg_SAA.Text = Convert.ToString(rows-1);
            textBoxMax_SAA.Text = Convert.ToString(ds.Max(path,cost));
            textBoxMin_SAA.Text = Convert.ToString(ds.Min(path,cost));
            textBoxSred_SAA.Text = Convert.ToString(ds.Pribil(path,cost) / (rows-1));
            dataGridViewTabl_SAA.Columns.Clear();
            dataGridViewTabl_SAA.Rows.Clear();
            dataGridViewTabl_SAA.ColumnCount = coll;
            dataGridViewTabl_SAA.RowCount = rows;
            textBoxSearch_SAA.Enabled = true;
            buttonSearch_SAA.Enabled = true;
            buttonExit_SAA.Enabled = true;
            buttonFunk_SAA.Enabled = true;
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
                MessageBox.Show("Выйдите из режима поиска!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonExit_SAA_Click(object sender, EventArgs e)
        {
            string[,] res = Array(path);
            dataGridViewTabl_SAA.Columns.Clear();
            dataGridViewTabl_SAA.Rows.Clear();
            dataGridViewTabl_SAA.ColumnCount = coll;
            dataGridViewTabl_SAA.RowCount = rows;
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
            textBoxSearch_SAA.Text = "";
        }

        private void buttonFunk_SAA_Click(object sender, EventArgs e)
        {
            FormGraphix form = new FormGraphix();
            form.path1 = path;
            form.Show();
        }

    }
}
