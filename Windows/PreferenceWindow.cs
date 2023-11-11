using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualWeatherApp;

namespace Visual_Weather_App.Windows
{
    public partial class PreferenceWindow : Form
    {
        public PreferenceWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CityInput.Text != "")
            {
                Library.CityName = CityInput.Text;
                Library.Open_WeatherMap_Api_Key = ApiKeyInput.Text;
                string result = Library.SaveData();
                if (result == "Success")
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Couldnt Save File", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
    }
}
