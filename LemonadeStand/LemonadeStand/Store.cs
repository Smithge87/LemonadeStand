using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public void BuyInventoryMenu(Player player)
        {
            Console.WriteLine("\n\n\n WHAT WOULD YOU LIKE TO BUY?");
            Console.WriteLine("=============================\n\n");
            Console.WriteLine(" 1) Cups\n");
            Console.WriteLine(" 2) Lemons\n");
            Console.WriteLine(" 3) Sugar\n");
            Console.WriteLine(" 4) Ice\n");
            Console.WriteLine(" 5) Return to Main Menu\n");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case (1):

                    BuyInventory(player, 25, .50, "CUPS", ref player.cups);
                    break;
                case (2):

                    BuyInventory(player, 15, .40, "LEMONS", ref player.lemons);
                    break;
                case (3):

                    BuyInventory(player, 20, .45, "SUGARS", ref player.sugars);
                    break;
                case (4):

                    BuyInventory(player, 35, .30, "ICE CUBES", ref player.iceCubes);
                    break;
                case (5):
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please enter a number 1-4");
                    BuyInventoryMenu(player);
                    break;
            }
        }
        public int BuyInventory(Player player, int quantity, double price, string buying, ref int purchasing)
        {
            {
                Console.WriteLine("\n\n HOW MANY {0} WOULD YOU LIKE TO BUY?", buying);
                Console.WriteLine("===========================================\n\n");
                Console.WriteLine("1) {0} for ${1}0\n", quantity, price);
                Console.WriteLine("2) {0} for ${1}0\n", quantity * 2, price * 2);
                Console.WriteLine("3) {0} for ${1}0\n", quantity * 3, price * 3);
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    purchasing = +quantity;
                    player.money -= price;
                }
                else if (choice == "2")
                {
                    purchasing += (quantity * 2);
                    player.money -= (price * 2);

                }
                else if (choice == "3")
                {
                    purchasing = +(quantity * 3);
                    player.money -= (price * 3);
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nYOU BOUGHT {0} {1},", quantity, buying);
                Console.ResetColor();
                BuyInventoryMenu(player);
                return purchasing;
            }
            

        }
        public void BalanceCheck(Player player)
        {
            if (player.money >= 0)
            {
                Console.WriteLine("Purchase Complete");
            }
            else if (player.money < 0)
            {
                Console.WriteLine("Sorry, you can't afford to do that");
            }

        }
    }


    
}
