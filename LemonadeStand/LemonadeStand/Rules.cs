using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Rules
    {
        public void GetRules()           
        {
            Console.Clear();
            ExplainStart();
            ExplainStore();
            ExplainRecipe();
            ExplainWeather();
            ExplainGame();
            ExplainEnding();
            Console.WriteLine("\n\n\n\n\nPlease press 'enter' to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
        public void ExplainStart()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" THE START");
            Console.WriteLine("----------");
            Console.ResetColor();
            Console.WriteLine("The game is centered around a child's lemonade stand");
            Console.WriteLine("You will be able to buy inventory, set your price per");
            Console.WriteLine("cup, and create your own recipe for making lemonade.");
            Console.WriteLine("Be mindful though! Your business will be affected by");
            Console.WriteLine("the weather, and you are only given $10 to start with");
            Console.WriteLine("so be mindful of how many pitchers you make each moring.");
            Console.WriteLine("");
        }
        public void ExplainStore()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" THE STORE");
            Console.WriteLine("===========");
            Console.ResetColor();
            Console.WriteLine("When visitng the store you can use your money to buy");
            Console.WriteLine("supplies to make great lemonade. If you run out of any");
            Console.WriteLine("important items in the  middle of the day you will have");
            Console.WriteLine("to close up shop for the day, so plan ahead if it's");
            Console.WriteLine("going to be hot out");
            Console.WriteLine("");
        }
        public void ExplainRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" THE RECIPE");
            Console.WriteLine("============");
            Console.ResetColor();
            Console.WriteLine("Every good lemonade is backed by a good recipe. Yours");
            Console.WriteLine("will be made of lemons, sugar, and ice, and you will");
            Console.WriteLine("have to choose what combination your customers will ");
            Console.WriteLine("like the most.");
            Console.WriteLine("");
        }
        public void ExplainWeather()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" THE WEATHER");
            Console.WriteLine("-------------");
            Console.ResetColor();
            Console.WriteLine("Each morning, you will get a forecast of what the ");
            Console.WriteLine("weather should look like that day. Customers will tend");
            Console.WriteLine("to to buy more lemonade when its sunny and hot!");
            Console.WriteLine("");
        }
        public void ExplainGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" THE GAME");
            Console.WriteLine("-----------");
            Console.ResetColor();
            Console.WriteLine("Durning the day, your choices will be played out. If ");
            Console.WriteLine("you make good choices, you will be able to stay open ");
            Console.WriteLine("all day and make more money then you've spent. If not");
            Console.WriteLine("you will be able to stock up on sullpes, alter your ");
            Console.WriteLine("recipe, and adjust the cost of a cup of lemonade at the");
            Console.WriteLine("beginning of each tuen.");
            Console.WriteLine("");
        }
        public void ExplainEnding()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" THE ENDING");
            Console.WriteLine("------------");
            Console.ResetColor();
            Console.WriteLine("At the end of each day, you will be told how your day");
            Console.WriteLine("went, and how many resources you have gained to spend");
            Console.WriteLine("in the store for the next day. At the end of your week,");
            Console.WriteLine("month, or year you will be given the total amount of");
            Console.WriteLine("money you made (hopefully more than you started with).");
            Console.WriteLine("Feel free to play again to see if you beat your own score!");
            Console.WriteLine("");
         
        }
    }
}
