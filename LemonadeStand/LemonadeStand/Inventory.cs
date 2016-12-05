using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public List<Lemon> lemons = new List<Lemon>();
        public List<Sugar> cupsOfSugar = new List<Sugar>();
        public List<IceCube> iceCubes = new List<IceCube>();
        public List<Cup> cups = new List<Cup>();

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
        public void UseLemons(int amountToUse)
        {
            for (int i = 0; i < amountToUse; i--)
            {
                lemons.Remove(new Lemon());
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
    }
}
