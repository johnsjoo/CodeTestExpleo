using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTestExpleo
{
    public class Anagram
    {
        //Problem 1 Anagram
        public static bool AnagramChecker(string wordOne, string wordTwo)
        {
            int counter = 0;
            bool anagram = false;

            //if the length is not the same = not a anagram.
            if (wordOne.Length == wordTwo.Length)
            {
                //loops through the first word
                for (int i = 0; i < wordOne.Length; i++)
                {
                    //Converts the words to array of chars.
                    char[] chararrayFirststring = wordOne.ToCharArray();
                    char[] chararraySecondstring = wordTwo.ToCharArray();

                    for (int j = 0; j < wordTwo.Length; j++)
                    {
                        //if the letters in the first loop matches all the letters in the second loop => return true, we have a anagram.
                        if (chararrayFirststring[i].Equals(chararraySecondstring[j]))
                        {
                            counter++;
                            if (counter == wordOne.Length || counter == wordTwo.Length)
                            {
                                anagram = true;
                            }
                        }
                    }
                }
            }
            else
            {
                //if the anagram is not the same number of letters => return false, we don't have a anagram.
                anagram = false;
            }

            return anagram;
        }
    }
}
