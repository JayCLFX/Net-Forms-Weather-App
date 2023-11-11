using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual_Weather_App.Windows;

namespace VisualWeatherApp
{
    public static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string result = Library.LoadData();

            if (result == "Success")
            {
                Application.Run(new MainWindow());
            }
            else
            {
                Application.Run(new PreferenceWindow());
            }
            //Application.Run(new PreferencesWindow());
        }
    }
}
