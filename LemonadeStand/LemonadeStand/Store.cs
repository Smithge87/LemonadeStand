﻿using LemonadeStand;
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

        public void BuyInventoryMenu(Player player)
        {
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
                    BuyInventory(25, .50, "CUPS", player.items.BuyCups, player);
                    break;
                case ("2"):
                    BuyInventory(15, .40, "LEMONS", player.items.BuyLemons, player);
                    break;
                case ("3"):
                    BuyInventory(20, .45, "SUGARS", player.items.BuySugar, player);
                    break;
                case ("4"):
                    BuyInventory(35, .30, "ICE CUBES", player.items.BuyIceCubes, player);
                    break;
                case ("5"):
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please enter a number 1-4");
                    BuyInventoryMenu(player);
                    break;
            }
        }
        public void BuyInventory(int quantity, double price, string buying, Action<int> Purchase, Player player)
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
                    amountToBuy = +quantity;
                    player.money -= price;
                    Purchase(amountToBuy);
                }
                else if (choice == "2")
                {
                    amountToBuy += (quantity * 2);
                    player.money -= (price * 2);
                    Purchase(amountToBuy);

                }
                else if (choice == "3")
                {
                    amountToBuy = +(quantity * 3);
                    player.money -= (price * 3);
                    Purchase(amountToBuy);
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nYOU BOUGHT {0} {1},", quantity, buying);
                Console.ResetColor();
                BuyInventoryMenu(player);

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
