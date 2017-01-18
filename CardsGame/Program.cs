using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CardsGame
{
	public class Program
	{
        

        static void Main(string[] args)
        {


            //while (true)
            //{
            Manager manager = new Manager();
            Gfx gfx = new Gfx();
            Test_Modules testMod = new Test_Modules();

            //    gfx.CardValueGFX();
            //    string input2 = Console.ReadLine();
            //    gfx.SuitsMenuGFX();
            //    string input1 = Console.ReadLine();
            //    Suits suits = manager.ChoseSuits(input1);

            //manager.SetCombosToArray(manager.GetList(), manager.GetSuits());


            testMod.ModuleTest(manager.GetList(), manager.GetSuits());

            //    Console.WriteLine(manager.ChoseCard3(input2, suits));

            //    Console.ReadLine();
            //}




        }
    }

}
