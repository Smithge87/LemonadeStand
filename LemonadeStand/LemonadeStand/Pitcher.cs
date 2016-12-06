using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {

        public bool CheckRecipe(List<Lemon> lemons, List<IceCube>iceCubes,List<Sugar>cupsOfSugar, Recipe recipe)
        {
            bool canMake = false;
          
                if ((lemons.Count >= recipe.lemons) && (iceCubes.Count >= recipe.iceCubes) && (cupsOfSugar.Count >= recipe.sugars))
                {
                   
                    canMake = true;
                }
                else
                {
                    canMake = false;
                }
            return canMake;
            }
        }
        




        



}
