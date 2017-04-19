using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopTrumps
{
    public class DealCards
    {
        List<int> cards = new List<int> { };
        //This randomly generates a list of 20 cards.
        public List<int> GenerateCards()
        {
            Random rnd = new Random(); //Starts by generating a random number
            while (cards.Count < 20) //Then checks the total of the list cards is less than the total to be dealt.
            {
                int list = rnd.Next(1, 21);//This creates a random number between 1 and 21.
                int duplicates = 0;
                foreach (int t in cards)//This just checks to see if the number is already in the cards list.
                {
                    if (t != list)
                    {

                    }
                    else
                    {
                        duplicates = duplicates + 1;
                    }
                }

                if (duplicates == 0)//If its not a duplicate then it adds it to the list
                {
                    cards.Add(list);
                }
                else { }
            }
            return cards;
        }
    }
}
