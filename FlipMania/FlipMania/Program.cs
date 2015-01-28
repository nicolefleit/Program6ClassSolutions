using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        //Step #3
        static Random randomNumberGenerator = new Random ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(FlipCoins (10000));
            Console.WriteLine(FlipForHeads (10000));
            //CallfirstFunction
            //CallSecondFunction
            Console.ReadKey();
        }
        
        /// <summary>
        /// Flips a coin x times
        /// </summary>
        /// <param name="numberOfFlips">how many times coin is flipped</param>
        static void FlipCoins(int numberOfFlips)
        {
   
            //Step #2
            int numberOfTails = 0;
            int numberOfHeads = 0;
            //Step #4
            Random theFlip = new Random();

            for (int i = 0; i < numberOfFlips; i++)
            {
                int FlipResult = theFlip.Next(0, 2);

                if (FlipResult == 0)
                {
                   numberOfHeads += 1;
                }
                else 
                {
                    numberOfTails++;
                }
            }
            Console.WriteLine("We flippeda coin " + numberOfFlips + " times.");
            Console.WriteLine("Nummber of Heads:" + numberOfHeads);
            Console.WriteLine("Number of Tails:" + numberOfTails);
        }
        static void FlipForHeads (int numberOfHeads)
        {
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;

            Random theFlip = new Random();
            
            while(numberOfHeadsFlipped != numberOfHeads)
            {
                int NewFlip = theFlip.Next(0, 2);

                if (theFlip == numberOfHeads) 
                {
                    numberOfHeads++;
                }
                
                totalFlip++;

                    
            }
            Console.WriteLine("We are flipping a coinuntil we find " +numberOfHeads + "heads.");
            Console.WriteLine("It took " +totalFlips + " to find " + numberofHeads + " heads.");
        }


}
}
