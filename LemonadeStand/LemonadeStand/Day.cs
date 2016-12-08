using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
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
        int purchaseComparer;
        double dailyTotal;
        int customerCount;
        public int days;
        double gameTotal;
        int customerTotal;
        bool soldOut = false;
        public List<Customer> customer = new List<Customer>();
        public void ExecuteDay()
        {
            CreateCustomerList();
            ProcessPotentials();
            CreateOverallTotal();
            DisplayDayResults();
            CheckDays();
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
                    CreateRandomNumber();
                    PurchaseLemonade(customer);
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
        public void CreateOverallTotal()
        {
            gameTotal += dailyTotal;
            customerTotal += customerCount;
        }
        public void DisplayDayResults()
        {
            Console.WriteLine("\n\n\nWooHoo! That was fun! Here's how the day went:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n DAILY RESULTS");
            Console.WriteLine("\n===============");
            Console.ResetColor();
            Console.WriteLine("\n Total number of customers : {0}", weather.randomTemp);
            Console.WriteLine("\n Total cups of lemonade sold: {0}", customerCount);
            Console.WriteLine("\n Amount of money made today: ${0}", String.Format("{0:0.00}", dailyTotal));
            Console.WriteLine("\n Total amount of money made: ${0}", String.Format("{0:0.00}", gameTotal));
            Console.WriteLine("\n\nPlease press 'enter' to continue");
            Console.ReadLine();
        }
        public void CheckDays()
        {
            days -= 1;
            if (days > 0)
            {
                weather.CreateNewWeather();
                player.items.pitchers.Clear();
                player.items.iceCubes.Clear();
                dailyTotal = 0;
                customerCount = 0;
                player.items.pitcherCups = 0;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\nGAME OVER\n\n");
                Console.WriteLine(" In total, you sold {0} cups of lemonade for a profit of {1}.\n");
                Console.WriteLine(" Great job! Come Back soon!\n\n ");
                Console.WriteLine(" Would you like to start another game? (y/n)");
                Console.ReadLine();
                Environment.Exit(0);
                Console.ResetColor();
            }
        }
    }
}
              

