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
        public Inventory items;
        public Wallet wallet;
        public Store store;
        public Recipe recipe;
        public Player()
        {
            recipe =new Recipe();
            store = new Store();
            wallet = new Wallet();
            items= new Inventory(recipe);
        }
        public void CheckBalance()
        {
            bool balanced = true;
            while (balanced == true)
            {
                if ((wallet.startingCash - store.cost) >= 0)
                {
                    wallet.startingCash -= store.cost;
                    balanced = false;
                }
                else
                {
                    Console.WriteLine("You dont have enough money to do that");
                    balanced = false;
                }
            }
        }

    }
}

