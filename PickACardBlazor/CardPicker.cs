using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardBlazor
{
	public class CardPicker
	{
		// Random number generator
		static Random random = new Random();

		public static string [] PickSomeCards(int numberOfCards)
        {
			string[] pickedCards = new string[numberOfCards];
			for (int i =0; i < numberOfCards; i++)
			{
				pickedCards[i] = RandomValue() + " of " + RandomSuit();
			}

			return pickedCards;
		}

        private static string RandomSuit()
        {
			// get a random number from 1 to 4
			int value = random.Next(1, 5);
			// if it's 1 return the string Spades
			if (value == 1) return "Spades";
			// if it's 2 return the string Hearts
			if (value == 2) return "Hearts";
			// if it's 3 return the string Clubs
			if (value == 3) return "Clubs";
			// if we haven't returned yet, return the string Diamonds
			return "Diamonds";
        }

        private static string RandomValue()
        {
			// get a random number from 1 to 13
			int value = random.Next(1, 14);
			// if it's 1 return the string Ace
			if (value == 1) return "Ace";
			// if it's 11 return the string Jack
			if (value == 11) return "Jack";
			// if it's 12 return the string Queen
			if (value == 12) return "Queen";
			// if it's 13 return the string King
			if (value == 13) return "King";
			// if none of the values about it will just return the number for numbered cards
			return value.ToString();
        }
    }
}

