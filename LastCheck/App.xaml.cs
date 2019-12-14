using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LastCheck
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string databaseName = "Academics.db";
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);
    }
}
