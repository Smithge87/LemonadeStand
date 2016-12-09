using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public int lemons;
        public int sugars;
        public int iceCubes;
        public double cupPrice;

        public void DisplayRecipeMenu()
        {
            DisplayCurrentRecipe();
            DisplayCurrentPrice();
            ChangeRecipeOrPrice();
            
        }

        public void DisplayCurrentRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n YOUR RECIPE");
            Console.WriteLine("=============");
            Console.ResetColor();
            Console.WriteLine("\n {0} Lemons", lemons);
            Console.WriteLine("\n {0} Sugars", sugars);
            Console.WriteLine("\n {0} Ice Cubes,", iceCubes);
        }
        public void DisplayCurrentPrice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n YOUR PRICE PER CUP");
            Console.WriteLine("====================\n");
            Console.ResetColor();
            Console.WriteLine(" ${0} per cup", String.Format("{0:0.00}", cupPrice) );
        }
        public void ChangeRecipeOrPrice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n WHAT WOULD YOU LIKE TO CHNGE?");
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine("\n 1) Number of Lemons\n");
            Console.WriteLine("\n 2) Cups of Sugar\n");
            Console.WriteLine("\n 3) Number of Ice Cubes\n");
            Console.WriteLine("\n 4) Price per Cup\n");
            Console.WriteLine("\n 5) Return to Main Menu\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddLemons();
                    break;
                case "2":
                    AddSugars();
                    break;
                case "3":
                    AddIceCubes();
                    break;
                case("4"):
                    SetPrice();
                    break;
                case ("5"):
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n Please enter a number 1-5\n");
                    DisplayRecipeMenu();
                    break;
            }


        }
        public void AddLemons()
        {
            try
            {
                Console.WriteLine("\n How many lemons would you like to use per pitcher?\n");
                int lemonAdd = int.Parse(Console.ReadLine());
                if (lemonAdd >= 0)
                {
                    lemons = lemonAdd;
                    Console.Clear();
                    DisplayRecipeMenu();
                }
                
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\n Oops! I didn't catch that. Please enter a positive, whole number.\n");
                DisplayRecipeMenu();
                AddLemons();
            }
        }
        public void AddSugars()
        {
            try
            {
                Console.WriteLine("\n How many cups of sugar would you like to use per pitcher?\n");
                int sugarAdd = int.Parse(Console.ReadLine());
                sugars = sugarAdd;
                Console.Clear();
                DisplayRecipeMenu();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\n Oops! I didn't catch that.");
                Console.WriteLine("\n Please try that again.\n");
                DisplayRecipeMenu();
                AddSugars();
            }
        }
        public void AddIceCubes()
        {
            try
            {
                Console.WriteLine("\n How many Ice Cubes would you like to use per pitcher?\n");
                int iceAdd = int.Parse(Console.ReadLine());
                iceCubes = iceAdd;
                Console.Clear();
                DisplayRecipeMenu();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\n Oops! I didn't catch that.");
                Console.WriteLine("\n Please try that again.\n");
                DisplayRecipeMenu();
                AddIceCubes();
            }
        }
        public void SetPrice()
        {
            try
            {
                Console.WriteLine("\n How much would you like to charge per cup? ($0.00)\n");
                cupPrice = double.Parse(Console.ReadLine());
                Console.Clear();
                DisplayRecipeMenu();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\n Oops! I didn't catch that.");
                Console.WriteLine("\n Please try that again \n");
                DisplayRecipeMenu();
                SetPrice();
            }
        }

    }
}