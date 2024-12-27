﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GairabekovMR.Sprint7.Project.V13.Lib;
namespace Tyuiu.GairabekovMR.Sprint7.Project.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"F:\Программирование 1 курс\Tyuiu.GairabekovMR.Sprint7\Tyuiu.GairabekovMR.Sprint7.Project.V13\mass.csv;
            string[,] array = {{ "Russia", "Moscow", "2nd world", "17 098 246" },
                                { "USA", "Washington" , "1st world" , "9 826 675"},
                               { "India","New Delhi","2nd world","3 287 263"},
                            { "Pakistan", "Islamabdad", "2nd world", "881 913"},
                                { "Niger", "Niamey", "3rd world", "1 267 000"} };
            var res = ds.GetTextFromFile(path);
            CollectionAssert.AreEqual(array, res);
        }
    }
}