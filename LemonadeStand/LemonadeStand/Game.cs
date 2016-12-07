using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Rules rules;
        Weather weather;
        Player player;
        Customer customer;
        Day day;

        public Game()
        {
            rules = new Rules();
            weather = new Weather();
            player = new Player();
            customer = new Customer(weather, player.recipe);
            day = new Day(customer, weather, player);
        }

        public void StartGame()
        {
            EnterGame();
            SetGameLength();
            DisplayDailyMenu();
        }
        public void EnterGame()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\nWELCOME TO LEMONADE STAND!");
            Console.WriteLine("==========================\n");
            Console.WriteLine("Please press'enter' to begin");
            Console.ReadLine();
            Console.Clear();
        }
        public void SetGameLength()
        {
            Console.WriteLine("\n\n HOW MANY DAYS WOULD YOU LIKE TO PLAY?");
            Console.WriteLine("=========================================\n");
            Console.WriteLine("~ 7 days (one week)\n");
            Console.WriteLine("~ 14 days (two weeks)\n");
            Console.WriteLine("~ 30 days (one month)\n");
            Console.WriteLine("~ 180 days (six month)\n");
            Console.WriteLine("~ 365 days (one year)\n");
            Console.WriteLine("~ Other (enter your own number of days)");
            day.days = int.Parse(Console.ReadLine());
            weather.SetClouds();
            weather.SetTemp();
            Console.Clear();
        }
        public void DisplayDailyMenu()
        {
            DisplayDailyInventory();
            DisplayDailyChoices();
            Console.ReadLine();            
        }
        public void DisplayDailyInventory()
        {
            Console.WriteLine("\n\n LETS GET READY FOR YOUR DAY!");
            Console.WriteLine("==============================\n");
            Console.WriteLine("You have {0} days left and ${1} in your wallet\n", day.days, player.wallet.startingCash);
            weather.DisplayWeather();
            Console.WriteLine(" INVENTORY");
            Console.WriteLine("===========\n");
            Console.WriteLine(" {0} lemons\n", (player.items.lemons.Count));
            Console.WriteLine(" {0} paper cups\n", player.items.cups.Count);
            Console.WriteLine(" {0} cups of sugar\n", player.items.cupsOfSugar.Count);
            Console.WriteLine(" {0} ice cubes\n", player.items.iceCubes.Count);
        }
        public void DisplayDailyChoices()
        {
            Console.WriteLine("\n\n WHAT WOULD YOU LIKE TO DO?");
            Console.WriteLine("============================\n");
            Console.WriteLine("1) Buy Inventory\n");
            Console.WriteLine("2) Change Recipe or Price per Cup\n");
            Console.WriteLine("3) Make Pitches of Lemonade\n");
            Console.WriteLine("4) See the Rules\n");
            Console.WriteLine("5) Start your day!\n");
            string choice = Console.ReadLine().ToLower();
            bool chosen = true;
            while (chosen = true)
            {
                switch (choice)
                {
                    case ("1"):
                        Console.Clear();
                        player.store.BuyInventoryMenu(player);
                        Console.Clear();
                        DisplayDailyMenu();
                        break;
                    case ("2"):
                        Console.Clear();
                        player.recipe.DisplayRecipeMenu();
                        DisplayDailyMenu();
                        break;
                    case ("3"):
                        Console.Clear();
                        player.items.DisplayPitcherMenu();
                        
                        Console.Clear();
                        DisplayDailyMenu();
                    
                        break;
                    case ("4"):
                        rules.GetRules();
                        DisplayDailyMenu();
                        chosen = false;
                        break;
                    case ("5"):
                        day.ExecuteDay();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number 1-5");
                        Console.ReadLine();
                        break;
                }
            }

            
        }

    }
}
