using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Customer customer;
        Weather weather;
        int purchaseComparer;
        double dailyTotal;
        int customerCount;

        public Day(Customer customer, Weather weather)
        {
            this.customer = customer;
            this.weather = weather;
        }
        public void ExecuteDay()
        {
            customer.CreateCustomerList();
            CreateRandomNumber();
            
        }
        public void CreateRandomNumber()
        {
            Random random = new Random();
            purchaseComparer = random.Next(0, 101);
        }
        public void PurchaseLemonade(Wallet wallet, Recipe recipe)
        {
            foreach (Customer customer in customer.customer)
            {
                if (customer.purchaseChance > purchaseComparer)
                {
                    dailyTotal += recipe.cupPrice;
                    wallet.startingCash += recipe.cupPrice;
                    customerCount += 1;
                }
            }
        }
    }
}
