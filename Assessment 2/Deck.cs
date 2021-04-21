using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
	class Deck
	{
		private Random random = new Random();
		public List<Card> card_list = new List<Card>(52);

		public Deck()
		{

		}
		public Card Deal()
		
		{
			if (IsEmpty())
			{
				return null;
			}
			Card temp = card_list[0];
			card_list.RemoveAt(0);
			return temp;

		}
		public bool IsEmpty() //If all cards have been drawn
		
		{
			if (card_list.Count == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Shuffle() //Shuffles using random
		{
			int n = card_list.Count;
			while (n > 1)
			{
				n--;
				int random_item = random.Next(n + 1);
				Card value = card_list[random_item];
				card_list[random_item] = card_list[n];
				card_list[n] = value;

			}
		}
	}
}