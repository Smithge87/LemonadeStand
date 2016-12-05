using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        int pitcher;
       public void DisplayPitcherMenu()
        {
            Console.WriteLine("\n\n PITCHER MENU");
            Console.WriteLine("==============");
            DisplayPitchers();
            CreatePitcherMenu();
        }
        public void DisplayPitchers()
        {
            Console.WriteLine("\nYou curently have {0} pitchers mixed. (10 cups per pitcher)", pitcher);
        }
        public void CreatePitcherMenu()
        {
            Console.WriteLine("\n\n WHAT WOULD YOU LIKE TO DO?");
            Console.WriteLine("============================");
            Console.WriteLine(" 1) Mix a pitcher");
            Console.WriteLine(" 2) Back to Main Menu");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case ("1"):
                    
                    break;
                case ("2"):
                    break;
                default:
                    Console.WriteLine("Please enter a number 1-2");
                    Console.ReadKey();
                    break;

            }
        }



        }

    
    
}
