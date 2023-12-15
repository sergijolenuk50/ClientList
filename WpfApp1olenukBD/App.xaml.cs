﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1olenukBD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string dbName = "Database.db";
        static string folder = Directory.GetCurrentDirectory();
        public static string dbPath = System.IO.Path.Combine(folder, dbName);
    }
}
