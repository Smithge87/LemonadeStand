using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public Recipe recipe;
        public Pitcher pitcher;
        public int pitcherCups;
        public Inventory(Recipe recipe)
        {
            this.recipe = recipe;
            pitcher = new Pitcher();

        }
        public List<Lemon> lemons = new List<Lemon>();
        public List<Sugar> cupsOfSugar = new List<Sugar>();
        public List<IceCube> iceCubes = new List<IceCube>();
        public List<Cup> cups = new List<Cup>();
        public List<Pitcher> pitchers = new List<Pitcher>();
    

        public void BuyLemons(int amountToBuy)
        {
            for (int i = 0; i < amountToBuy; i++)
                if (amountToBuy > 0)
                {
                    lemons.Add(new Lemon());
                }
                else
                {
                    amountToBuy = 0;
                }
        }
        public void BuyCups(int amountToBuy)
        {
            for (int i = 0; i < amountToBuy; i++)
                if (amountToBuy > 0)
                {
                    cups.Add(new Cup());
                }
                else
                {
                    amountToBuy = 0;
                }
        }
        public void BuySugar(int amountToBuy)
        {
            for (int i = 0; i < amountToBuy; i++)
                if (amountToBuy > 0)
                {
                    cupsOfSugar.Add(new Sugar());
                }
                else
                {
                    amountToBuy = 0;
                }
        }
        public void BuyIceCubes(int amountToBuy)
        {
            for (int i = 0; i < amountToBuy; i++)
                if (amountToBuy > 0)
                {
                    iceCubes.Add(new IceCube());
                }
                else
                {
                    amountToBuy = 0;
                }
        }
        public void UseLemons(int amountToUse)
        {
            for (int i = 0; i < amountToUse; i--)
            {
                lemons.Remove(new Lemon());
            }
        }
        public void UseSugar(int amountToUse)
        {
            for (int i = 0; i < amountToUse; i--)
            {
                cupsOfSugar.Remove(new Sugar());
            }
        }
        public void UseIceCubes(int amountToUse)
        {
            for (int i = 0; i < amountToUse; i--)
            {
                iceCubes.Remove(new IceCube());
            }
        }
        public void UseCups(int amountToUse)
        {
            for (int i = 0; i < amountToUse; i--)
            {
                cups.Remove(new Cup());
            }
        }
        public void MakePitcher()
        {
            pitchers.Add(new Pitcher());
            UseSugar(recipe.sugars);
            UseLemons(recipe.lemons);
            UseIceCubes(recipe.iceCubes);
            UseCups(-10);
        }
        public void DisplayPitcherMenu()
        {
            Console.WriteLine("\n\n PITCHER MENU");
            Console.WriteLine("==============");
            Console.WriteLine("\nYou curently have {0} pitchers mixed. (10 cups per pitcher)", pitchers.Count);
            CreatePitcherMenu();
            Console.ReadLine();
        }
        public void CreatePitcherMenu()
        {
            Console.WriteLine("\n\n WHAT WOULD YOU LIKE TO DO?");
            Console.WriteLine("============================\n");
            Console.WriteLine(" 1) Mix a pitcher\n");
            Console.WriteLine(" 2) Back to Main Menu\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case ("1"):
                   
                    if (pitcher.CheckRecipe(lemons, iceCubes, cupsOfSugar, recipe))
                    {
                        MakePitcher();
                        Console.WriteLine("\nPitcher Mixed!\n");
                        pitcherCups += 10;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nYou do not have enough resources to do that\n");
                        DisplayPitcherMenu();
                    }                                        
                    break;
                case ("2"):
                    break;
                default:
                    Console.WriteLine("Please enter a number 1-2");
                    Console.ReadKey();
                    break;

            }
        }
        public bool CheckPitcherCups()
        {
            bool canMake = false;

            if (pitcherCups > 0)
            {

                canMake = true;
            }
            else
            {
                canMake = false;
            }
            return canMake;
        }
    }

}

