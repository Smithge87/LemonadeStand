﻿using System;
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
        Player player;
        int purchaseComparer;
        double dailyTotal;
        int customerCount;
        public int days;
        double gameTotal;

        public Day(Customer customer, Weather weather, Player player)
        {
            this.customer = customer;
            this.weather = weather;
            this.player = player;
        }
        public void ExecuteDay()
        {
            customer.CreateCustomerList();
            CompareLoop();
            CreateOverallTotal();
            DisplayDayResults();
            CheckDays();
        }
        public void CreateRandomNumber()
        {
            Random random = new Random();
            purchaseComparer = random.Next(0,100);
        }
        public void CompareLoop()
        {
            foreach (Customer customer in customer.customer)
            {
                PurchaseLemonade(customer);
            }
        }
        public void PurchaseLemonade(Customer customer)
        {
            CreateRandomNumber();
            if (customer.purchaseChance > purchaseComparer)
                {
                    if (player.items.CheckPitcherCups())
                    {
                        dailyTotal += player.recipe.cupPrice;
                        player.wallet.startingCash += player.recipe.cupPrice;
                        customerCount += 1;
                        player.items.pitcherCups -= 1;
                    }
                    else
                    {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\nYOU SOLD OUT OF LEMONADE!\n");
                    Console.ResetColor();
                    }
                }
            
        }
        public void CreateOverallTotal()
        {
            gameTotal += dailyTotal;
        }
        public void DisplayDayResults()
        {
            Console.Clear();
            Console.WriteLine("\n\n\nWooHoo! That was fun! Here's how the day went:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n DAILY RESULTS");
            Console.WriteLine("\n===============");
            Console.ResetColor();
            Console.WriteLine("\n Total number of customers : {0}", weather.randomTemp);
            Console.WriteLine("\n Total cups of lemonade sold: {0}", customerCount);
            Console.WriteLine("\n Amount of money made today: ${0}", String.Format("{0:0.00}", dailyTotal));
            Console.WriteLine("\n Total amount of money made: ${0}", String.Format("{0:0.00}", gameTotal));
            Console.WriteLine("\n\nPlease press 'enter' to continue");
            Console.ReadLine();
        }
        public void CheckDays()
        { 
                if (days > 0)
                {
                    weather.CreateNewWeather();
                    player.items.pitchers.Clear();
                    player.items.iceCubes.Clear();
                    days -= 1;                   
                }
                else
                {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("GAME OVER");
                Console.ResetColor();
                }
            }
        }
    }
              

