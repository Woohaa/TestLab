using CardsGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ModuleTest
{
    public class Run_ModuleTest
    {
        ModuleTest modTest = new ModuleTest();
        Manager manager = new Manager();

        public void RunModuleTest()
        {

            modTest.ModuleTestMethod(manager.GetList(), manager.GetSuits());

            Console.ReadLine();

        }
    }
}
