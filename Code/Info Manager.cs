using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace VisualWeatherApp
{
    public static class Info_Manager
    {
        static WebClient weather_webClient = new WebClient();
        public static string json_weather;
        public static dynamic data_weather;

        public static string json_geo;
        public static dynamic data_geo;


        public static string GetGeoData()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    json_geo = webClient.DownloadString(Library.ReturnGeoURL());
                    data_geo = JObject.Parse(json_geo);

                    Library.latitude = data_geo.results[0].latitude;
                    Library.longitude = data_geo.results[0].longitude;
                }
                return "Success";
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                MessageBox.Show(e.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        public static string GetWeatherData()
        {
            try
            {
                json_weather = weather_webClient.DownloadString(Library.ReturnWeatherURL());
                data_weather = JObject.Parse(json_weather);
                return "Success";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        public static int GetSunset()
        {
            try
            {
                int Sunset = data_weather.sys.sunset;
                return Sunset;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return 0;
            }
        }

        public static int GetSunrise()
        {
            try
            {
                int Sunrise = data_weather.sys.sunrise;
                return Sunrise;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return 0;
            }
        }

        public static string GetCityname()
        {
            try
            {
                var CityName = data_weather.name;
                return CityName;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetCountry()
        {
            try
            {
                var Country = data_weather.sys.country;
                return Country;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetWindgusts()
        {
            try
            {
                var WindGusts = data_weather.wind.gust;
                return WindGusts;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetWinddirection()
        {
            try
            {
                var WindDirection = data_weather.wind.deg;
                return WindDirection;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetWindspeed()
        {
            try
            {
                var WindSpeed = data_weather.wind.speed;
                return WindSpeed;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetVisibility()
        {
            try
            {
                var visibility = data_weather.visibility;
                return visibility;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetHumidity()
        {
            try
            {
                var Humidity = data_weather.main.humidity;
                return Humidity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetPressure()
        {
            try
            {
                var Pressure = data_weather.main.pressure;
                return Pressure;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static int GetTemperatureMax()
        {
            try
            {
                int Temperature_Max = data_weather.main.temp_max - 273;
                return Temperature_Max;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return 0;
            }
        }

        public static int GetTemperatureMin()
        {
            try
            {
                int Temperature_Min = data_weather.main.temp_min - 273;
                return Temperature_Min;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return 0;
            }
        }

        public static int GetTemperature()
        {
            try
            {
                int Temperature = data_weather.main.temp - 273;
                return Temperature;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return 0;
            }
        }

        public static string GetDescription()
        {
            try
            {
                var Description = data_weather.weather[0].description;
                return Description;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return "Error";
            }
        }

        public static string GetWeather()
        {
            try
            {
                var Weather = data_weather.weather[0].main;
                return Weather;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return "Error";
            }
        }
    }
}
