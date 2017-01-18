using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    class Test_Modules
    {

        Manager manager = new Manager();

        public void ModuleTest(List<string> cardList, Suits[] suit)
        {
            foreach (var item in cardList)
            {
                foreach (var suitsValue in manager.GetSuits())
                {
                    if (cardList.Any(c => c.Equals(item.ToString()) && suitsValue == Suits.Clubs || suitsValue == Suits.Diamonds || suitsValue == Suits.Hearts || suitsValue == Suits.Spades))
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
