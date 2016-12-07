using LemonadeStand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public int amountToBuy;
        public double cost;
        int quantity;
        string buying;

        public void BuyInventoryMenu(Player player, Game game)
        {
            game.DisplayDailyInventory();
            Console.WriteLine("\n\n\n WHAT WOULD YOU LIKE TO BUY?");
            Console.WriteLine("=============================\n\n");
            Console.WriteLine(" 1) Cups\n");
            Console.WriteLine(" 2) Lemons\n");
            Console.WriteLine(" 3) Sugar\n");
            Console.WriteLine(" 4) Ice\n");
            Console.WriteLine(" 5) Return to Main Menu\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case ("1"):
                    BuyInventory(25, .50, "CUPS", player.items.BuyCups, player, game);
                    break;
                case ("2"):
                    BuyInventory(15, .40, "LEMONS", player.items.BuyLemons, player, game);
                    break;
                case ("3"):
                    BuyInventory(20, .45, "CUPS OF SUGAR", player.items.BuySugar, player, game);
                    break;
                case ("4"):
                    BuyInventory(35, .30, "ICE CUBES", player.items.BuyIceCubes, player, game);
                    break;
                case ("5"):
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please enter a number 1-4");
                    BuyInventoryMenu(player, game);
                    break;
            }
        }
        public void BuyInventory(int quantity, double price, string buying, Action<int> Purchase, Player player, Game game)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n HOW MANY {0} WOULD YOU LIKE TO BUY?", buying);
            Console.WriteLine("===========================================\n\n");
            Console.ResetColor();
            Console.WriteLine("1) {0} for ${1}\n", quantity, String.Format("{0:0.00}", price));
            Console.WriteLine("2) {0} for ${1}\n", quantity * 2, String.Format("{0:0.00}", (price * 1.9)));
            Console.WriteLine("3) {0} for ${1}\n", quantity * 3, String.Format("{0:0.00}", (price * 2.8)));
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                amountToBuy = quantity;
                cost = price;
                if (player.wallet.CheckBalance(cost) == true)
                {
                    Purchase(amountToBuy);
                    player.wallet.MakeWithdrawl(cost);
                    CompleteTransaction(player, game);
                }
                else
                {
                    CompleteTransaction(player, game);
                }
            }
            else if (choice == "2")
            {
                quantity = (quantity * 2);
                amountToBuy = quantity;
                cost = (price * 1.9);
                if (player.wallet.CheckBalance(cost) == true)
                {
                    Purchase(amountToBuy);
                    player.wallet.MakeWithdrawl(cost);
                    CompleteTransaction(player, game);
                }
                else
                {
                    CompleteTransaction(player, game);
                }
            }
            else if (choice == "3")
            {
                quantity = (quantity * 3);
                amountToBuy = quantity;
                cost = (price * 2.8);
                if (player.wallet.CheckBalance(cost) == true)
                {
                    Purchase(amountToBuy);
                    player.wallet.MakeWithdrawl(cost);
                    CompleteTransaction(player, game);
                }
                else
                {
                    CompleteTransaction(player, game);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInvalid entry, Please press 'enter' and try agin\n");
                BuyInventoryMenu(player, game);
            }
        }
        public void CompleteTransaction(Player player, Game game)
        {
            Console.Clear();
            if (player.wallet.CheckBalance(cost) == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Transaction complete!");
                Console.WriteLine("You have ${0} left in your wallet", String.Format("{0:0.00}", player.wallet.startingCash));
                Console.ResetColor();
                BuyInventoryMenu(player, game);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nYou dont have enough money for that!");
                Console.WriteLine("\nYou only have ${0} left in your wallet", String.Format("{0:0.00}", player.wallet.startingCash));
                Console.ResetColor();
                BuyInventoryMenu(player, game);
            }
        }
    }
}

           
       

