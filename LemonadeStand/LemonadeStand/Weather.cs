using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        Random random;

        public Weather(Random random)
        {
            this.random = random;
        }

        string randomCloud;
        public int randomTemp;
        public List<string> clouds = new List<string> { "Rainy", "Cloudy", "Sunny", "Overcast", "Stormy", "Partly Cloudy" };

        public void DisplayWeather()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" TODAY'S WEATHER:");
            Console.WriteLine("=================\n");
            Console.ResetColor();
            Console.WriteLine("Today's weather will be {0} with a high of {1}\n\n\n", randomCloud, randomTemp);
        }
        public string SetClouds()
        {
            int randomWeather = random.Next(clouds.Count);
            randomCloud = clouds[randomWeather];
            return randomCloud;
        }
        public int SetTemp()
        {
            switch (randomCloud)
            {
                case "Sunny":
                case "Partly Cloudy":
                    randomTemp = random.Next(80, 100);
                    break;

                case "Cloudy":
                case "Overcast":
                    randomTemp = random.Next(65, 85);
                    break;

                case "Rainy":
                case "Stormy":
                    randomTemp = random.Next(50, 70);
                    break;

                default:
                    break;
            }
            return randomTemp;
        }
        public void CreateNewWeather()
        {
            SetClouds();
            SetTemp();
        }
        //public void AddWeatherToArray()
        //{
        //    var dayCreated = [SetClouds(), SetTemp()];

        //}
        //string[,] weathers;
        //public void CreateWeek()
        //{

        //}

    }
}