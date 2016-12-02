using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public double money = 10.00;
        public int lemons;
        public int cups;
        public int sugars;
        public int iceCubes;

        public void BalanceCheck()
        {
            if (money >= 0)
            {
                Console.WriteLine("Purchase Complete");
            }
            else if (money < 0)
            {
                Console.WriteLine("Sorry, you can't afford to do that");
            }

        }


    }
}

