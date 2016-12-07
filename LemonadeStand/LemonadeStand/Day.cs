using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Customer customer;
        Weather weather;
        Player player;
        int purchaseComparer;
        double dailyTotal;
        int customerCount;
        public int days;
        double gameTotal;

        public Day(Customer customer, Weather weather, Player player)
        {
            this.customer = customer;
            this.weather = weather;
            this.player = player;
        }
        public void ExecuteDay()
        {
            customer.CreateCustomerList();
            CreateRandomNumber();
            PurchaseLemonade();
            DisplayDayResults();
            CheckDays();
        }
        public void CreateRandomNumber()
        {
            Random random = new Random();
            purchaseComparer = random.Next(0, 101);
        }
        public void PurchaseLemonade()
        {
            foreach (Customer customer in customer.customer)
            {
                if (customer.purchaseChance > purchaseComparer)
                {
                    if (player.items.CheckPitcherCups())
                    {
                        dailyTotal += player.recipe.cupPrice;
                        player.wallet.startingCash += player.recipe.cupPrice;
                        customerCount += 1;
                        player.items.pitcherCups -= 1;
                        gameTotal += dailyTotal;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nYOU SOLD OUT OF LEMONADE!");
                        DisplayDayResults();
                        Console.ReadLine();
                    }
                }
            }
        }
        public void DisplayDayResults()
        {
            Console.WriteLine("\n\n\nWooHoo! That was fun! Here's how the day went:");
            Console.WriteLine("\n DAILY RESULTS");
            Console.WriteLine("\n===============");
            Console.WriteLine("\n Total number of customers : {0}", weather.randomTemp);
            Console.WriteLine("\n Total cups of lemonade sold: {0}", customerCount);
            Console.WriteLine("\n Amount of money made today: ${0}", dailyTotal);
            Console.WriteLine("\n Total amount of money made: ${0}", gameTotal);
        }
        public void CheckDays()
        { 
            for (int i = 0; i < days; i--)
            {
                if (days > 0)
                {
                    weather.CreateNewWeather();
                    days -= 1;
                    
                }
            }
        }
    }
              
}
