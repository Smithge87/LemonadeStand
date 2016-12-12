using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public Inventory items;
        public Wallet wallet;
        public Store store;
        public Recipe recipe;
        public bool balanced = true;
        public Player(Store store)
        {
            recipe = new Recipe();
            this.store = store;
            wallet = new Wallet();
            items = new Inventory(recipe);
        }
    }

}

