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
        public Random random;
        public Customer(Weather weather, Recipe recipe, Random random)
        {
            this.weather = weather;
            this.recipe = recipe;
            this.random = random;
            PreferSugar();
            PreferIce();
            PreferLemons();
            PreferPrice();
            purchaseChance = preferSugar + preferLemons + preferIce + preferPrice;
        }
        public void PreferSugar()
        {
            if (recipe.sugars < 2 || recipe.sugars > 7)
            {
                
                preferSugar = random.Next(0, 6);
            }
            else if (recipe.sugars < 4 || recipe.sugars > 5)
            {
                
                preferSugar = random.Next(10, 16);
            }
            else if (recipe.sugars == 5 || recipe.sugars == 4)
            {
                
                preferSugar = random.Next(21, 26);
            }
        }
        public void PreferLemons()
        {
            if (recipe.lemons < 2 || recipe.lemons > 7)
            {
                
                preferLemons = random.Next(0, 6);
            }
            else if (recipe.lemons < 4 || recipe.lemons > 5)
            {
                
                preferLemons = random.Next(10, 16);
            }
            else if (recipe.lemons == 5 || recipe.lemons == 4)
            {
                
                preferLemons = random.Next(20, 26);
            }
        }
        public void PreferIce()
        {
            if (weather.randomTemp > 50 && weather.randomTemp <= 65)
            {
                if (recipe.iceCubes < 2)
                {
                    
                    preferIce = random.Next(20, 26);
                }
                else if (recipe.iceCubes < 4 && recipe.iceCubes >= 2)
                {
                    
                    preferIce = random.Next(15, 21);
                }
                else if (recipe.iceCubes >= 4)
                {
                    
                    preferIce = random.Next(0, 16);
                }
            }
            else if (weather.randomTemp > 65 && weather.randomTemp <= 80)
            {
                if (recipe.iceCubes < 2)
                {
                    
                    preferIce = random.Next(15, 21);
                }
                else if (recipe.iceCubes < 4 && recipe.iceCubes >= 2)
                {
                    
                    preferIce = random.Next(15, 26);
                }
                else if (recipe.iceCubes >= 4)
                {
                    
                    preferIce = random.Next(15, 21);
                }
            }
            else if (weather.randomTemp > 80 && weather.randomTemp <= 90)
            {
                if (recipe.iceCubes < 2)
                {
                    
                    preferIce = random.Next(0, 16);
                }
                else if (recipe.iceCubes < 4 && recipe.iceCubes >= 2)
                {
                    
                    preferIce = random.Next(11, 16);
                }
                else if (recipe.iceCubes >= 4)
                {
                    
                    preferIce = random.Next(15, 26);
                }
            }
            else if (weather.randomTemp > 90 && weather.randomTemp <= 100)
            {
                if (recipe.iceCubes < 2)
                {
                    
                    preferIce = random.Next(0, 5);
                }
                else if (recipe.iceCubes < 4 && recipe.iceCubes >= 2)
                {
                    
                    preferIce = random.Next(5, 10);
                }
                else if (recipe.iceCubes >= 4)
                {
                    
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
                    
                    preferPrice = random.Next(20, 26);
                }
                else if (recipe.cupPrice < .4 && recipe.cupPrice >= .2)
                {
                    
                    preferPrice = random.Next(15, 21);
                }
                else if (recipe.cupPrice >= .4)
                {
                    
                    preferPrice = random.Next(0, 16);
                }
            }
            else if (weather.randomTemp > 65 && weather.randomTemp <= 80)
            {
                if (recipe.cupPrice < .30)
                {
                    
                    preferPrice = random.Next(20, 26);
                }
                else if (recipe.cupPrice < .7 && recipe.cupPrice >= .3)
                {
                    
                    preferPrice = random.Next(15, 21);
                }
                else if (recipe.cupPrice >= .7)
                {
                    
                    preferPrice = random.Next(0, 16);
                }
            }
            else if (weather.randomTemp > 80 && weather.randomTemp <= 90)
            {
                if (recipe.cupPrice < .60)
                {
                    
                    preferPrice = random.Next(20, 26);
                }
                else if (recipe.cupPrice < .9 && recipe.cupPrice >= .6)
                {
                    
                    preferPrice = random.Next(15, 21);
                }
                else if (recipe.cupPrice >= .9)
                {
                    
                    preferPrice = random.Next(0, 16);
                }
            }
            if (weather.randomTemp > 90 && weather.randomTemp <= 100)
            {
                if (recipe.cupPrice < .80)
                {
                    
                    preferPrice = random.Next(20, 26);
                }
                else if (recipe.cupPrice < 1.2 && recipe.cupPrice >= .8)
                {
                    
                    preferPrice = random.Next(15, 21);
                }
                else if (recipe.cupPrice >= 1.2)
                {
                    
                    preferPrice = random.Next(0, 16);
                }
            }
        }
    }
}
