using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{

	public enum Suits
	{
		Hearts,
		Spades,
		Diamonds,
		Clubs,
		INVALID

	}

	public class Manager
	{
		List<string> cards = new List<string>()
		{
			"A",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"J",
			"Q",
			"K"
		};

		char[] suitIcons = new char[] { '♥', '♠', '♦', '♣', 'F'};

        public Suits[] GetSuits()
		{
			Suits[] suitsValues = (Suits[])Enum.GetValues(typeof(Suits));
			return suitsValues;
		}

		public List<string> GetList()
		{
			List<string> list = cards;

			return list;
		}

		public string ChoseCard(string input, Suits suits)
		{
			
			{
				foreach (var card in cards.Where(c => c.Equals(input.ToUpper())))
				{
                    if(suits != Suits.INVALID)
                    {
                        string result = string.Format("{0} of {1}", card, suits);
                        return result;
                    }
                    else
                    {
                        return "Must be a valid value!";
                    }
				}
			}

			return "Must be a valid value!";
		}


        	public Suits ChoseSuits(string input)
		{

			bool isRunning = true;

			while (isRunning)
			{

				switch (input)
				{
					case "H":
					case "h":
						return Suits.Hearts;
					case "D":
					case "d":
						return Suits.Diamonds;
					case "C":
					case "c":
						return Suits.Clubs;
					case "S":
					case "s":
						return Suits.Spades;
					default:
						Console.WriteLine("Must be a valid suit");
						isRunning = false;
						break;
				}
			}

            return Suits.INVALID;
		}





    }
}

