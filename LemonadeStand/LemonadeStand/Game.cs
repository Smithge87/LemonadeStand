using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Rules rules = new Rules();
        Inventory items = new Inventory();
        Weather weather = new Weather();
        Store store = new Store();
        Player player = new Player();
        Recipe recipe = new Recipe();
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
            weather.days = int.Parse(Console.ReadLine());
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
            Console.WriteLine("==============================\n\n");
            Console.WriteLine("You have ${0} left to spend\n\n", player.money);
            Console.WriteLine(" INVENTORY");
            Console.WriteLine("===========\n");
            Console.WriteLine(" {0} lemons\n", player.lemons);
            Console.WriteLine(" {0} paper cups\n", player.cups);
            Console.WriteLine(" {0} cups of sugar\n", player.sugars);
            Console.WriteLine(" {0} ice cubes\n", player.iceCubes);
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
                        store.BuyInventoryMenu(player);
                        Console.Clear();
                        DisplayDailyMenu();
                        break;
                    case ("2"):
                        Console.Clear();
                        recipe.DisplayRecipeMenu();
                        break;
                    case ("3"):
                        break;
                    case ("4"):
                        rules.GetRules();
                        DisplayDailyMenu();
                        chosen = false;
                        break;
                    case ("5"):
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
