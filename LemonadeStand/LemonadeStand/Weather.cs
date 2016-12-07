using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {

        string randomCloud;
        public int randomTemp;
        public List<string> clouds = new List<string> { "Rainy", "Cloudy", "Sunny", "Overcast", "Stormy", "Partly Cloudy" };

        public void DisplayWeather()
        {
            Console.WriteLine(" TODAY'S WEATHER:");
            Console.WriteLine("=================\n");
            Console.WriteLine("Today's weather will be {0} with a high of {1}\n\n\n", randomCloud, randomTemp);
        }
        public string SetClouds()
        {
            Random random = new Random();
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
                    Random random = new Random();
                    randomTemp = random.Next(80,100);
                    break;
                    
                case "Cloudy":
                case "Overcast":
                    Random randoms = new Random();
                    randomTemp = randoms.Next(65, 85);
                    break;
                    
                case "Rainy":
                case "Stormy":
                    Random randome = new Random();
                    randomTemp = randome.Next(50, 70);
                    break;
                    
                default:
                    break;
                    
            }
            return randomTemp;
        }

    }
}
    


