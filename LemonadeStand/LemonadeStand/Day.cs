using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        Random random;
        Weather weather;
        Player player;
        public Day( Weather weather, Player player, Random random)
        {
            this.weather = weather;
            this.player = player;
            this.random = random;
        }
        public int purchaseComparer;
        public double dailyTotal;
        public int customerCount;
        public int days;
        public double gameTotal;
        public int customerTotal;
        bool soldOut = false;
        double beginningBalance;
        public List<Customer> customer = new List<Customer>();
        public void ExecuteDay()
        {
            CreateCustomerList();
            ProcessPotentials();
            CreateOverallTotals();
            DisplayDayResults();
            CleanDay();
        }
        public void SetBeginningValues()
        {
            beginningBalance = player.wallet.startingCash;
        }
        public void CreateCustomerList()
        {
            for (int i = 0; i < weather.randomTemp; i++)
            {
                if (weather.randomTemp > 0)
                {
                    customer.Add(new Customer(weather, player.recipe, random));
                }
            }
        }
        public void ProcessPotentials()
        {
            foreach (Customer customer in customer)
            {
                if (soldOut == false)
                {
                    CreateRandomNumber();
                    PurchaseLemonade(customer);
                }
            }
        }
        public void CreateRandomNumber()
        {
            purchaseComparer = random.Next(0, 100);
        }
        public void PurchaseLemonade(Customer customer)
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\nYOU SOLD OUT OF LEMONADE!\n");
                    Console.ResetColor();
                    soldOut = true;
                }
            }

        }
        public void CreateOverallTotals()
        {
            gameTotal += dailyTotal;
            customerTotal += customerCount;

        }
        public void DisplayDayResults()
        {
            Console.WriteLine("\n\n\nWooHoo! That was fun! Here's how the day went:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n DAILY RESULTS");
            Console.WriteLine("\n===============\n");
            Console.ResetColor();
            Console.WriteLine("\n Total number of customers : {0}", weather.randomTemp);
            Console.WriteLine("\n Total cups of lemonade sold: {0}", customerCount);
            Console.WriteLine("\n Amount of money made today: ${0}", String.Format("{0:0.00}", dailyTotal));
            Console.WriteLine("\n Total amount of money made total: ${0}", String.Format("{0:0.00}", gameTotal));
            Console.WriteLine("");
            Console.WriteLine("\n Total amount you've spent on supplies today: ${0})", String.Format("{0:0.00}", player.wallet.spentCashToday)) ;
            Console.WriteLine("\n Daily profit/loss: ${0}", (String.Format("{0:0.00}", (dailyTotal -= player.wallet.spentCashToday))));
            Console.WriteLine("\n Total profit/loss: ${0}", (String.Format("{0:0.00}", (gameTotal -= player.wallet.spentCashTotal))));
            Console.WriteLine("\n Your new balance: ${0}", (String.Format("{0:0.00}", player.wallet.startingCash )));
            Console.WriteLine("\n\nPlease press 'enter' to continue");
            Console.ReadLine();
        }
        public void CleanDay()
        {
            weather.CreateNewWeather();
            player.items.pitchers.Clear();
            player.items.iceCubes.Clear();
            dailyTotal = 0;
            player.wallet.spentCashToday = 0;
            customerCount = 0;
            player.items.pitcherCups = 0;
            soldOut = false;
            days -= 1;
            customer.Clear();
         }        
    }
}
              

