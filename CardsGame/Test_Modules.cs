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
            foreach (var card in cardList)
            {
                foreach (var suitsValue in manager.GetSuits())
                {
                    var expected = string.Format("{0} of {1}", card, suitsValue);

                    if (expected == manager.ChoseCard(card, suitsValue))
                    {
                        Console.WriteLine(expected +  ": " + "PASS");
                    }
                    else
                    {
                        Console.WriteLine(expected + ": " + "FAIL");
                    }

                }

            }
        }
    }
}
//Men i princip så loopar igenom listorna,
//skicka in combo till dom metoderna som skriver ut och testa utskfriften