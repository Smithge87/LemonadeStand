﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double spentCashToday;
        public double spentCashTotal;
        public double startingCash = 10;
        public bool CheckBalance(double cost)
        {
            if ((startingCash - cost) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MakeWithdrawl(double cost)
        {
            startingCash -= cost;
            spentCashToday += cost;
            spentCashTotal += cost;
        }
    }
}
