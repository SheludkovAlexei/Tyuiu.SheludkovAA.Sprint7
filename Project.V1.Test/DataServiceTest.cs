using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project.V1.Lib;

namespace Project.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\alex3\Desktop\11.csv";
            string[,] res = ds.VivodVSpisok(path);
            string[,] wait = new string[3, 3];
            wait[0,0] = "dwdwd";
            Assert.AreEqual(wait[0,0], res[0,2]);
        }
    }
}
