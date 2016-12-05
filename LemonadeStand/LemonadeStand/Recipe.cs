﻿using System;
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
            Console.WriteLine("\n\n\n YOUR RECIPE");
            Console.WriteLine("=============");
            Console.WriteLine("\n {0} Lemons", lemons);
            Console.WriteLine("\n {0} Sugars", sugars);
            Console.WriteLine("\n {0} Ice Cubes,", iceCubes);
        }
        public void DisplayCurrentPrice()
        {
            Console.WriteLine("\n\n\n YOUR PRICE PER CUP");
            Console.WriteLine("====================\n");
            Console.WriteLine("${0} per cup", cupPrice);
        }
        public void ChangeRecipeOrPrice()
        {
            Console.WriteLine("\n\n\n WHAT WOULD YOU LIKE TO CHNGE?");
            Console.WriteLine("===============================");
            Console.WriteLine("\n 1) Number of Lemons\n");
            Console.WriteLine("\n 2) Number of Sugars\n");
            Console.WriteLine("\n 3) Number of Ice Cubes\n");
            Console.WriteLine("\n 4) Price per Cup\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nHow many lemons would you like to add?");
                    int lemonAdd = int.Parse(Console.ReadLine());
                    lemons += lemonAdd;
                    Console.Clear();
                    DisplayRecipeMenu();
                    break;
                case "2":
                    Console.WriteLine("\nHow many sugars would you like to add?");
                    int sugarAdd = int.Parse(Console.ReadLine());
                    sugars += sugarAdd;
                    Console.Clear();
                    DisplayRecipeMenu();
                    break;
                case "3":
                    Console.WriteLine("\nHow many Ice Cubes would you like to add?");
                    int iceAdd = int.Parse(Console.ReadLine());
                    iceCubes += iceAdd;
                    Console.Clear();
                    DisplayRecipeMenu();
                    break;
                case("4"):
                    Console.WriteLine("How much would you like to charge per cup? ($0.00)");
                    double cupPrice = double.Parse(Console.ReadLine());
                    break;
                case ("5"):

                    break;
                default:
                    Console.WriteLine("Please enter a number 1-3");
                    Console.ReadKey();
                    break;
            }


        }

    }
}