using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualWeatherApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Library.LoadData();
            string geodata_result = Info_Manager.GetGeoData();
            if (geodata_result == "Success")
            {
                string weather_result = Info_Manager.GetWeatherData();
                if (weather_result == "Success")
                {
                    Loading_Finished();
                }
                else
                {
                    Debug.WriteLine("Couldnt Get Weather Data");
                    MessageBox.Show("Could Get Weather Data", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                Debug.WriteLine("Couldnt Get Geo Data");
                MessageBox.Show("Could Get Geo Data", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

        }

        private void Loading_Finished()
        {
            Debug.WriteLine($"Test:       Latitude:  {Library.latitude}   /  Longitude:  {Library.longitude}");

            //Display Weather Background
            string weather = Info_Manager.GetWeather();
            switch (weather)
            {
                case "Clouds":
                    this.BackgroundImage = Visual_Weather_App.Properties.Resources.Cloudy_Background;
                    Weather_Info.Image = Visual_Weather_App.Properties.Resources.Clouds_Info;
                    break;
                case "Clear":
                    this.BackgroundImage = Visual_Weather_App.Properties.Resources.Sunny_Background;
                    Weather_Info.Image = Visual_Weather_App.Properties.Resources.Sunny_Info;
                    break;
                case "Rain":
                    this.BackgroundImage = Visual_Weather_App.Properties.Resources.Rainy_Background;
                    Weather_Info.Image = Visual_Weather_App.Properties.Resources.Rainy_Info;
                    break;
                case "Drizzle":
                    this.BackgroundImage = Visual_Weather_App.Properties.Resources.Rainy_Background;
                    Weather_Info.Image = Visual_Weather_App.Properties.Resources.Rainy_Info;
                    break;
                case "Thunderstorm":
                    this.BackgroundImage = Visual_Weather_App.Properties.Resources.Thunder_Background;
                    Weather_Info.Image = Visual_Weather_App.Properties.Resources.Thunder_Info;
                    break;
                case "Snow":
                    this.BackgroundImage = Visual_Weather_App.Properties.Resources.Snowy_Background;
                    Weather_Info.Image = Visual_Weather_App.Properties.Resources.Snow_Info;
                    break;
            }

            //Set Parameters
            CityLabel.Text = Library.CityName;
            WeatherLabel.Text = weather;

            TemperatureLabel.Text = Info_Manager.GetTemperature().ToString() + "°C";
            DayLabel.Text = DateTime.Today.DayOfWeek.ToString();
            HumidityLabel.Text = Info_Manager.GetHumidity().ToString() + " %";
            AirPressureLabel.Text = Info_Manager.GetPressure().ToString() + " PS";
            WindSpeedLabel.Text = Info_Manager.GetWindspeed().ToString() + " km/h";
            VisibilityLabel.Text = Info_Manager.GetVisibility().ToString() + " m";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Library.DeleteData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
