using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_Through_Strings
{
    class Program
    {

        static void Main(string[] args)
        {
            //function call for the vowel counter
            string testString = "the lazy do jumps over the lazy bear";
            Console.WriteLine("we found {0} vowels in {1}", VowelCounter3000(testString), testString);

            //keep console window with...
            

            Console.WriteLine("the average length of a words in '{0}' is {1}", testString, AverageWordLengthFinder8000(testString ));

            oldTimeyTextPrinter(testString, 100);
            oldTimeyTextPrinter(testString, 40);
            oldTimeyTextPrinter(testString, 5);

            Console.ReadKey();
        }

        //new functions are declared outside of other functions but inside of a class
        /// <summary>
        /// Count the number of vowels in a string
        /// </summary>
        /// <param name="inputText">the sting to analyze</param>
        /// <returns>return the number of vowles found</returns>
        static int VowelCounter3000(string inputText)
        {
            //this is our counter for vowels
            int numberOfVowelsFound = 0;

            //we need to loop through all indexes to compare each letter

            //"hello" is 5 charachers long but the last index is 4. 
            for (int i = 0; i < inputText.Length; i++)
            {
                //pulling out an indivdual letter, converting to the lowercase
                char letter = char.ToLower(inputText[i]);
                //is it a vowel
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    //yes, 'it is a vowel! count it!
                    numberOfVowelsFound = numberOfVowelsFound + 1;
                }

            }
            //loop complete
            return numberOfVowelsFound;

        }


        /// <summary>
        /// finds the average length of a word in a string
        /// </summary>
        /// <param name="inputText">the text</param>
        /// <returns>average length of the word length</returns>
        static double AverageWordLengthFinder8000(string inputText)
        {
            //counters to hold our values to calculate an average
            double totalNumberOfCharacters = 0;
            double totalNumberOfWords = 0;

            //we need to split a sting into words

            //"hello how are you" ---> "hello|how|are|you"
            string[] wordArray = inputText.Split(' ');

            //loop over each word in our word arry
            for(int i = 0; i < wordArray.Length; i++)
            {
                //get the current word
                string currentWord = wordArray[i];
                //let's process the word
                totalNumberOfWords++;
                //totalNumberOfCharacters = totalNumberOfCharacters + currentWord.Length;
                totalNumberOfCharacters += currentWord.Length;
            }

            //return our results
            return totalNumberOfCharacters / totalNumberOfWords;

        }


        /// <summary>
        /// prints text to the screen like the 80s
        /// </summary>
        /// <param name="inputText">text to print</param>
        /// <param name="pauseDuration">character print in miliseconds</param>
        static void oldTimeyTextPrinter(string inputText, int pauseDuration)
        {
            //loop over each character
            for (int i = 0; i < inputText.Length; i++)
            {
                char letter = inputText[i];
                Console.Write(letter);
                //pause
                System.Threading.Thread.Sleep(pauseDuration);
            }
            Console.WriteLine();
        }
    }

}
