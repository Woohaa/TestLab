using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    public class Gfx
	{
		public void SuitsMenuGFX()
		{
			Console.Clear();
			Console.WriteLine("Press H/h for Hearts ♥");
			Console.WriteLine("Press S/s for Spades ♠");
			Console.WriteLine("Press C/c for Clubs ♣");
			Console.WriteLine("Press D/d for Diamonds ♦");

		}

		public void CardValueGFX()
		{
			Console.Clear();
			Console.WriteLine("Chose a number between 2 and 10 or J, Q or K to get a card value");
		}
	}
}
