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
        Store store;
        Random random;

        public Game()
        {
            random = new Random();
            store = new Store();
            rules = new Rules();
            weather = new Weather(random);
            player = new Player(store);
            customer = new Customer(weather, player.recipe, random);
            day = new Day(weather, player, random);
        }

        public void StartGame()
        {
            EnterGame();
            SetGameLength();
            DisplayDailyMenu();
        }
        public void EnterGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n\n\n\n\n\n                          WELCOME TO LEMONADE STAND!");
            Console.WriteLine("                         ============================\n");
            Console.ResetColor();
            Console.WriteLine("                         Please press'enter' to begin");
            Console.ReadLine();
            Console.Clear();
        }
        public void SetGameLength()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n HOW MANY DAYS WOULD YOU LIKE TO PLAY?");
                Console.WriteLine("=========================================\n");
                Console.ResetColor();
                Console.WriteLine("~ 7 days (one week)\n");
                Console.WriteLine("~ 14 days (two weeks)\n");
                Console.WriteLine("~ 30 days (one month)\n");
                Console.WriteLine("~ 180 days (six month)\n");
                Console.WriteLine("~ 365 days (one year)\n");
                Console.WriteLine("~ Other (enter your own number of days)\n");
                Console.WriteLine("\nPlease enter a number\n");
                day.days = int.Parse(Console.ReadLine());
                weather.CreateNewWeather();
                Console.Clear();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\n\nOops! I didn't catch that. Please enter any whole number.\n");
                SetGameLength();
            }
        }
        public void DisplayDailyMenu()
        {
            bool chosen = true;
            while (chosen == true)
            {
                Console.Clear();
                DisplayDailyHeader();
                DisplayDailyInventory();
                DisplayDailyChoices();
            }
        }
        public void DisplayDailyHeader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n LETS GET READY FOR YOUR DAY!");
            Console.WriteLine("==============================\n");
            Console.ResetColor();
            Console.WriteLine("You have {0} days left and ${1} in your wallet\n", day.days, String.Format("{0:0.00}", player.wallet.startingCash));
            weather.DisplayWeather();
        }
        public void DisplayDailyInventory()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n INVENTORY");
            Console.WriteLine("===========\n");
            Console.ResetColor();
            Console.WriteLine(" {0} lemons\n", (player.items.lemons.Count));
            Console.WriteLine(" {0} paper cups\n", player.items.cups.Count);
            Console.WriteLine(" {0} cups of sugar\n", player.items.cupsOfSugar.Count);
            Console.WriteLine(" {0} ice cubes\n", player.items.iceCubes.Count);
            Console.WriteLine(" {0} pitchers mixed", player.items.pitchers.Count);
        }
        public void DisplayDailyChoices()
        {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n\n\n WHAT WOULD YOU LIKE TO DO?");
                Console.WriteLine("============================\n");
                Console.ResetColor();
                Console.WriteLine("1) Buy Inventory\n");
                Console.WriteLine("2) Change Recipe or Price per Cup\n");
                Console.WriteLine("3) Make Pitchers of Lemonade\n");
                Console.WriteLine("4) See the Rules\n");
                Console.WriteLine("5) Start your day!\n");
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case ("1"):
                        Console.Clear();
                        store.BuyInventoryMenu(player, this);
                        break;
                    case ("2"):
                        Console.Clear();
                        player.recipe.DisplayRecipeMenu();
                        break;
                    case ("3"):
                        Console.Clear();
                        player.items.DisplayPitcherMenu();
                        break;
                    case ("4"):
                        rules.GetRules();
                        break;
                    case ("5"):
                        Console.Clear();
                        day.ExecuteDay();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please enter a number 1-5");
                        DisplayDailyInventory();
                        DisplayDailyChoices();
                        break;
                }
        }
        public void TheEndOFDays()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\nGAME OVER\n\n");
            Console.WriteLine(" In total, you sold {0} cups of lemonade for a profit of {1}.\n");
            Console.WriteLine(" Great job! Come Back soon!\n\n ");
            Console.WriteLine(" Would you like to start another game? (y/n)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case ("y"):
                    EnterGame();
                    break;
                case ("n"):
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number 1-5");
                    TheEndOFDays();
                    break;            }
        }
        
    } 
}
