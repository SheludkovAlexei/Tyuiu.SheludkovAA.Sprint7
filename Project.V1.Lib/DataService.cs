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
        public string[,] VivodVSpisok(string path)
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

            return mtr;
        }
    }
}
