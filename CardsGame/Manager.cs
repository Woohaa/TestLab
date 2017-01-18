using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{

	#region made with Dictionary	
	//Dictionary<string, string> cards = new Dictionary<string, string>()
	//{
	//	{"A", "Ace" },
	//	{"2", "2" },
	//	{"3", "3" },
	//	{"4", "4" },
	//	{"5", "5" },
	//	{"6", "6" },
	//	{"7", "7" },
	//	{"8", "8" },
	//	{"9", "9" },
	//	{"10", "10" },
	//	{"J", "J" },
	//	{"Q", "Q" },
	//	{"K", "K" }
	//};

	//public string ChoseCard2(Suits suits, string input)
	//{


	//	foreach (var card in cards.Where(c => c.Value.Contains(input)))
	//	{
	//		string result = string.Format("{0} of {1}", card.Value, suits);
	//		return result;
	//	}

	//	return "";
	//}
	#endregion
	#region made with Enums
	//public enum CardValues
	//{
	//	A = 1,
	//	Two,
	//	Three,
	//	Four,
	//	Five,
	//	Six,
	//	Seven,
	//	Eight,
	//	Nine,
	//	Ten,
	//	J,
	//	Q,
	//	K,
	//	INVALID
	//}

	//public CardValues CardValue(string input)
	//{
	//	bool isRunning = true;

	//	while (isRunning)
	//	{
	//		switch (input)
	//		{
	//			case "1":
	//				return CardValues.A;
	//			case "2":
	//				return CardValues.Two;
	//			case "3":
	//				return CardValues.Three;
	//			case "4":
	//				return CardValues.Four;
	//			case "5":
	//				return CardValues.Five;
	//			case "6":
	//				return CardValues.Six;
	//			case "7":
	//				return CardValues.Seven;
	//			case "8":
	//				return CardValues.Eight;
	//			case "9":
	//				return CardValues.Nine;
	//			case "10":
	//				return CardValues.Ten;
	//			case "J":
	//			case "j":
	//				return CardValues.J;
	//			case "Q":
	//			case "q":
	//				return CardValues.Q;
	//			case "K":
	//			case "k":
	//				return CardValues.K;
	//			default:
	//				Console.WriteLine("Must be a valid value");
	//				isRunning = false;
	//				break;

	//		}
	//	}

	//	return CardValues.INVALID;
	//}

	//public void CardChosen(Suits suits, CardValues values)
	//{
	//	Console.WriteLine(suits + " " + values);
	//}

	#endregion


	public enum Suits
	{
		Hearts = 1,
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

		char[] suitIcons = new char[] { '♦', '♣', '♠', '♥' };
		Suits suits;



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

		public string ChoseCard3(string input, Suits suits)
		{
			
			{
				foreach (var card in cards.Where(c => c.Equals(input.ToUpper())))
				{
					string result = string.Format("{0} of {1}  {2}", card, suits, suitIcons[(int)suits]);
					return result;
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
		//
		public void ModuleTest(List<string> cardList, Suits[] suit)
		{
			foreach (var item in cardList)
			{
				foreach (var suitsValue in GetSuits())
				{
					if (cards.Any(c => c.Equals(item.ToString()) && suitsValue == Suits.Clubs || suitsValue == Suits.Diamonds || suitsValue == Suits.Hearts || suitsValue == Suits.Spades))
					{
						Console.WriteLine(item + " " + suitsValue + " " + "PASS");
					}
					else
					{
						Console.WriteLine();
					}

				}
			    	
			  }
		 }

	}
}


		