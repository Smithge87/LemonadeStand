using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        int preferSugar;
        int preferLemons;
        int preferIce;
        int preferPrice;
        public int purchaseChance;
        public Recipe recipe;
        public Weather weather;
        public List<Customer> customer = new List<Customer>();
        public Customer(Weather weather, Recipe recipe)
        {
            this.weather = weather;
            this.recipe = recipe;
            PreferSugar();
            PreferIce();
            PreferLemons();
            PreferPrice();
            purchaseChance = preferSugar + preferLemons + preferIce + preferPrice;
        }
        public void CreateCustomerList()
        {
            for (int i = 0; i < weather.randomTemp; i++)
            {
                if (weather.randomTemp > 0)
                {
                    customer.Add(new Customer(weather, recipe));
                }
            }
        }
        public void PreferSugar()
        {
            if (recipe.sugars < 2 || recipe.sugars > 7)
            {
                Random random = new Random();
                preferSugar = random.Next(0, 6);
            }
            else if (recipe.sugars < 4 || recipe.sugars > 5)
            {
                Random random = new Random();
                preferSugar = random.Next(10, 16);
            }
            else if (recipe.sugars == 5 || recipe.sugars == 4)
            {
                Random random = new Random();
                preferSugar = random.Next(21, 26);
            }
        }
        public void PreferLemons()
        {
            if (recipe.lemons < 2 || recipe.lemons > 7)
            {
                Random random = new Random();
                preferLemons = random.Next(0, 6);
            }
            else if (recipe.lemons < 4 || recipe.lemons > 5)
            {
                Random random = new Random();
                preferLemons = random.Next(10, 16);
            }
            else if (recipe.lemons == 5 || recipe.lemons == 4)
            {
                Random random = new Random();
                preferLemons = random.Next(20, 26);
            }
        }
        public void PreferIce()
        {
            if (weather.randomTemp > 50 && weather.randomTemp <= 65)
            {
                if (recipe.iceCubes < 2)
                {
                    Random random = new Random();
                    preferIce = random.Next(20, 26);
                }
                else if (recipe.iceCubes < 4 && recipe.iceCubes >= 2)
                {
                    Random random = new Random();
                    preferIce = random.Next(15, 21);
                }
                else if (recipe.iceCubes >= 4)
                {
                    Random random = new Random();
                    preferIce = random.Next(0, 16);
                }
            }
            else if (weather.randomTemp > 65 && weather.randomTemp <= 80)
            {
                if (recipe.iceCubes < 2)
                {
                    Random random = new Random();
                    preferIce = random.Next(15, 21);
                }
                else if (recipe.iceCubes < 4 && recipe.iceCubes >= 2)
                {
                    Random random = new Random();
                    preferIce = random.Next(15, 26);
                }
                else if (recipe.iceCubes >= 4)
                {
                    Random random = new Random();
                    preferIce = random.Next(15, 21);
                }
            }
            else if (weather.randomTemp > 80 && weather.randomTemp <= 90)
            {
                if (recipe.iceCubes < 2)
                {
                    Random random = new Random();
                    preferIce = random.Next(0, 16);
                }
                else if (recipe.iceCubes < 4 && recipe.iceCubes >= 2)
                {
                    Random random = new Random();
                    preferIce = random.Next(11, 16);
                }
                else if (recipe.iceCubes >= 4)
                {
                    Random random = new Random();
                    preferIce = random.Next(15, 26);
                }
            }
            else if (weather.randomTemp > 90 && weather.randomTemp <= 100)
            {
                if (recipe.iceCubes < 2)
                {
                    Random random = new Random();
                    preferIce = random.Next(0, 5);
                }
                else if (recipe.iceCubes < 4 && recipe.iceCubes >= 2)
                {
                    Random random = new Random();
                    preferIce = random.Next(5, 10);
                }
                else if (recipe.iceCubes >= 4)
                {
                    Random random = new Random();
                    preferIce = random.Next(20, 26);
                }
            }
        }
        public void PreferPrice()
        {
            if (weather.randomTemp > 50 && weather.randomTemp <= 65)
            {
                if (recipe.cupPrice < .20)
                {
                    Random random = new Random();
                    preferPrice = random.Next(20, 26);
                }
                else if (recipe.cupPrice < .4 && recipe.cupPrice >= .2)
                {
                    Random random = new Random();
                    preferPrice = random.Next(15, 21);
                }
                else if (recipe.cupPrice >= .4)
                {
                    Random random = new Random();
                    preferPrice = random.Next(0, 16);
                }
            }
            else if (weather.randomTemp > 65 && weather.randomTemp <= 80)
            {
                if (recipe.cupPrice < .30)
                {
                    Random random = new Random();
                    preferPrice = random.Next(20, 26);
                }
                else if (recipe.cupPrice < .7 && recipe.cupPrice >= .3)
                {
                    Random random = new Random();
                    preferPrice = random.Next(15, 21);
                }
                else if (recipe.cupPrice >= .7)
                {
                    Random random = new Random();
                    preferPrice = random.Next(0, 16);
                }
            }
            else if (weather.randomTemp > 80 && weather.randomTemp <= 90)
            {
                if (recipe.cupPrice < .60)
                {
                    Random random = new Random();
                    preferPrice = random.Next(20, 26);
                }
                else if (recipe.cupPrice < .9 && recipe.cupPrice >= .6)
                {
                    Random random = new Random();
                    preferPrice = random.Next(15, 21);
                }
                else if (recipe.cupPrice >= .9)
                {
                    Random random = new Random();
                    preferPrice = random.Next(0, 16);
                }
            }
            if (weather.randomTemp > 90 && weather.randomTemp <= 100)
            {
                if (recipe.cupPrice < .80)
                {
                    Random random = new Random();
                    preferPrice = random.Next(20, 26);
                }
                else if (recipe.cupPrice < 1.2 && recipe.cupPrice >= .8)
                {
                    Random random = new Random();
                    preferPrice = random.Next(15, 21);
                }
                else if (recipe.cupPrice >= 1.2)
                {
                    Random random = new Random();
                    preferPrice = random.Next(0, 16);
                }
            }
        }
    }
}
