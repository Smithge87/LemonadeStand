using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
         public void StartGame()
        {
            EnterGame();
        }
        public void EnterGame()
        {
            Console.WriteLine("\n\n\n\n\n\n\nWELCOME TO LEMONADE STAND!");
            Console.WriteLine("==========================\n");
            Console.WriteLine("Please press'enter' to begin");
            Console.ReadLine();
        }
    }
}
