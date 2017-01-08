using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TDD_Lab
{
    public class FileManager 
    {

        IWriteToFile fileWriter;

        public FileManager(IWriteToFile write)
        {
            fileWriter = write;
        }

        public string SaveNameToFile(string name, string lastName)
        {
            string fullName = "Name: " + name + " Last Name: " + lastName;
            fileWriter.SaveToFile(fullName);
            return fullName;       
        }

        public void ReadFile()
        {
            string[] fileContainment = File.ReadAllLines(@"C:\Users\Admin\Desktop\Test.txt");

            for (int i = 0; i < fileContainment.Length; i++)
            {
                Console.WriteLine(fileContainment[i]);
            }
                   
        }

        public string WriteAdditionResultToFile(int number1, int number2)
        {
            int result = number1 + number2;
            fileWriter.SaveToFile("Sum = " + result.ToString());
            return result.ToString();
        }

        public string WriteSubtractionDifferenceToFile(int number1, int number2)
        {
            int difference = number1 - number2;
            fileWriter.SaveToFile("Difference = " + difference.ToString());
            return difference.ToString();
        }

        public string WriteMultiplicationProductToFile(int number1, int number2)
        {
            int product = number1 * number2;
            fileWriter.SaveToFile("Product = " + product.ToString());
            return product.ToString();
        }

        public string WriteDivisionQuotaToFile(int number1, int number2)
        {
            try
            {
                int quota = number1 / number2;

                if (number1 < number2)
                {
                    fileWriter.SaveToFile("Only allowed to divide by a lesser number");
                    return quota.ToString("Only allowed to divide by a lesser number");
                }
                if (number2 != 0)
                {
                    fileWriter.SaveToFile("Quota = " + quota.ToString());
                    return quota.ToString();
                }
         
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            return "";
        }

    }
}
//Programmet ska vara objektorienterat skrivet och följa TDD metodik

//Programmet ska kunna:
//Skapa en text fil
//Skriva till textfilen baserat på input(s) till konsolen: 
//Ditt förnamn och efternamn
//En addition summa
//En subtraktion differens
//En multiplikations produkt
//En divisions kvot
//Läsa från textfilen
//Undersöka ifall filen redan existerar
//Skriv minst 3 klasser
//Skriv minst 8 metoder för att hantera funktionaliteterna
//Skriv minst 8 enhets tester
