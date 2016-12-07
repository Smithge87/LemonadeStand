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
                    }
                    else
                    {
                        Console.WriteLine("YOU SOLD OF LEMONADE!");
                        Console.ReadLine();
                    }
                }
            }
        }
        public void CheckDays()
        { 
            for (int i = 0; i < days; i--)
            {
                if (days > 0)
                {
                    ;
                }
            }
        }
    }
              
}
