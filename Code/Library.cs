using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace VisualWeatherApp
{
    public static class Library
    {
        private static string Envoirment_Path = Environment.CurrentDirectory + @"\" + "save.dat";
        public static Dictionary<string, string> Main_Dictionary = new Dictionary<string, string>();

        //Weather
        public static string Open_WeatherMap_Api_Key = "";
        public static string latitude;
        public static string longitude;

        //Geo
        public static string CityName = "";

        public static void DeleteData()
        {
            Main_Dictionary.Clear();
            File.Delete(Envoirment_Path);
            Environment.Exit(0);
        }

        public static string SaveData()
        {
            try
            {
                Main_Dictionary.Clear();
                Main_Dictionary.Add("Api-Key", Open_WeatherMap_Api_Key);
                Main_Dictionary.Add("City-Name", CityName);

                string data = JsonConvert.SerializeObject(Main_Dictionary);

                File.WriteAllText(Envoirment_Path, data);
                return "Success";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string LoadData()
        {
            if (File.Exists(Envoirment_Path))
            {
                string data = File.ReadAllText(Envoirment_Path);
                Main_Dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);

                foreach (var item in Main_Dictionary)
                {
                    if (item.Key == "Api-Key")
                    {
                        Open_WeatherMap_Api_Key = item.Value;
                    }

                    if (item.Key == "City-Name")
                    {
                        CityName =  item.Value;
                    }
                }

                return "Success";
            }
            else
            {
                return "Error";
            }
        }

        public static string ReturnGeoURL()
        {
            string secondAPIUrl = $"https://geocoding-api.open-meteo.com/v1/search?name={CityName}&count=10&language=en&format=json";
            return secondAPIUrl;
        }

        public static string ReturnWeatherURL()
        {
            string ApiURL = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={Open_WeatherMap_Api_Key}";
            return ApiURL;

        }
    }
}
