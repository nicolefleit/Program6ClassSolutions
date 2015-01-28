using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipping_Coins
{
    class Program
    {
        static Random randomNumberGenerator = new Random();
        //Random = random number generator

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(flipACoin());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(flipForHeads());
            }


                Console.ReadKey();
        }


        /// <summary>
        /// Flips a coin
        /// </summary>
        /// <returns>returns a string of either heads or tails</returns>
        static string flipACoin()
        {
            int theFlip = randomNumberGenerator.Next(0, 2);
            if (theFlip == 0)
            {
                return "Heads";
            }
            return "Tails";
        }

        /// <summary>
        /// Flips a coin till a heads has been flipped
        /// </summary>
        /// <returns>number of tried it took to flip a heads</returns>
        static int flipForHeads()
        {
            bool headsHasNotBeenFlipped = true;
            int howManyFlips = 0;
            while(headsHasNotBeenFlipped)
            {
                string theFlip = flipACoin();
                howManyFlips++;
                if (theFlip == "Heads")
                {
                    headsHasNotBeenFlipped = false;
                }

            }
            return howManyFlips;
        }
    }
}
