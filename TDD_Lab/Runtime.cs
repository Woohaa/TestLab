using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Lab
{
    class Runtime
    {
        public void MainMenu()
        {
            bool isRunning = true;

            Gfx uiGfx = new Gfx();
            WriteToFile write = new WriteToFile();
            FileManager manager = new FileManager(write);

            while (isRunning)
            {
                uiGfx.MainMenuGraphics();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Type in your name");
                        string inputName = Console.ReadLine();
                        Console.WriteLine("Type in your last name");
                        string inputLastName = Console.ReadLine();
                        manager.SaveNameToFile(inputName, inputLastName);
                        Console.WriteLine("Name saved!");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Type in first number");
                        int additionNumber;
                        while (!int.TryParse(Console.ReadLine(), out additionNumber))
                            Console.WriteLine("Must be a number!");
                        Console.WriteLine("Type in second number");
                        int additionNumber2;
                        while (!int.TryParse(Console.ReadLine(), out additionNumber2))
                            Console.WriteLine("Must be a number!");
                        manager.WriteAdditionResultToFile(additionNumber, additionNumber2);
                        Console.WriteLine("Result saved!");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Type in first number");
                        int subtractionNumber;
                        while(!int.TryParse(Console.ReadLine(), out subtractionNumber))
                            Console.WriteLine("Must be a number!");
                        Console.WriteLine("Type in second number");
                        int subtractionNumber2;
                        while(!int.TryParse(Console.ReadLine(), out subtractionNumber2))
                            Console.WriteLine("Must be a number!");
                        manager.WriteSubtractionDifferenceToFile(subtractionNumber, subtractionNumber2);
                        Console.WriteLine("Result saved!");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Type in first number");
                        int multiplicationNumber;
                        while (!int.TryParse(Console.ReadLine(), out multiplicationNumber))
                            Console.WriteLine("Must be a number!");
                        Console.WriteLine("Type in second number");
                        int multiplicationNumber2;
                        while (!int.TryParse(Console.ReadLine(), out multiplicationNumber2))
                            Console.WriteLine("Must be a number!");
                        manager.WriteMultiplicationProductToFile(multiplicationNumber, multiplicationNumber2);
                        Console.WriteLine("Result saved!");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine("Type in first number");
                        int divisionNumber;
                        while (!int.TryParse(Console.ReadLine(), out divisionNumber))
                            Console.WriteLine("Must be a number!");
                        Console.WriteLine("Type in second number");
                        int divisionNumber2;
                        while (!int.TryParse(Console.ReadLine(), out divisionNumber2))
                            Console.WriteLine("Must be a number!");
                        manager.WriteDivisionQuotaToFile(divisionNumber, divisionNumber2);
                        Console.WriteLine("Result saved!");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        manager.ReadFile();
                        Console.WriteLine();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.Escape:
                        isRunning = false;
                        break;

                }
            }
        }
    }
}
