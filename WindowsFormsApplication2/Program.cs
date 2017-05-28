using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Data
    {
        public static string Name { get; set; }
        public static string Adress { get; set; }
        public static string Job { get; set; }
        public static string Education { get; set; }
        public static string Rank { get; set; }
        public static string DateRank { get; set; }
        public static string Post { get; set; }
        public static string Unit { get; set; }
        public static string ServiceForm { get; set; }
        public static string ServicePeriod { get; set; }
        public static string Character { get; set; }
        public static int Ch { get; set; }
        public static int Row { get; set; }
        public static string Search { get; set; }
        public static string WhatSearch { get; set; }

    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
