using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project.V1.Lib
{
    public class DataService
    {
        public string[,] sortPrice(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int coll = lines[0].Split(';').Length;
            string[,] mtr = new string[rows, coll];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < coll; j++)
                {
                    mtr[i, j] = strok[j];
                }
            }
            int[] ln1 = new int[rows];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if ((j == 4)&&(i>0))
                    {
                        ln1[i] = Convert.ToInt32(mtr[i, j]);
                    }
                }
            }
            string[] lines2 = new string[coll];
            Array.Sort(ln1);
            string[,] mtr1 = new string[rows, coll];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if ((j == 4)&&(i>0))
                    {
                        mtr1[i, j] = Convert.ToString(ln1[i]);
                    }
                    if (lines[i].Split(';')[4] == mtr1[i, j])
                    {
                        lines2 = lines[i].Split(';');

                    }
                }
            }



            return mtr1;
        }
    }
}
