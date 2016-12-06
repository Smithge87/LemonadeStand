using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string randomCloud;

        public int days;
        public List<string> clouds = new List<string> { "Rainy", "Cloudy", "Sunny", "Overcast", "Stormy", "Partly Cloudy" };

        public void DisplayWeather()
        {
            Console.WriteLine("\n\n TODAY'S WEATHER:");
            Console.WriteLine("=================\n");
            Console.WriteLine("Today's weather will be {0} with a high of {1}",SetClouds(), SetTemp());
        }
        public string SetClouds()
        {
            Random random = new Random();
            int randomWeather = random.Next(clouds.Count);
            string randomCloud = clouds[randomWeather];
            return randomCloud;
        }
        public int SetTemp()
        {
            switch(randomCloud)
            {
                case "Sunny":
                case "Partly Cloudy":
                    Random random = new Random();
                    int randomTemp = random.Next(75,100);
                    return randomTemp;
                case "Cloudy":
                case "Overcast":
                    Random randoms = new Random();
                    randomTemp = randoms.Next(75, 100);
                    return randomTemp;
                case "Rainy":
                case "Stormy":
            }
           (randomCloud == "")
        }

               

        

    }
    

}
