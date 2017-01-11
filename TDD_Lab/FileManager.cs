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
			if (File.Exists(@"C:\Systemutvecklare Utbildning\Kurs Testning\Test.txt"))
			{
				string[] fileContainment = File.ReadAllLines(@"C:\Systemutvecklare Utbildning\Kurs Testning\Test.txt");

				for (int i = 0; i < fileContainment.Length; i++)
				{
					Console.WriteLine(fileContainment[i]);
				}
			}
			else
			{
				Console.WriteLine("There is no file available!");
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

        public bool WriteDivisionQuotaToFile(int number1, int number2)
        {
			try
			{
				int quota = number1 / number2;

				if (number1 < number2)
				{
					fileWriter.SaveToFile("Only allowed to divide by a lesser number");
					return false;
				}

				if (number2 != 0)
				{
					fileWriter.SaveToFile("Quota = " + quota.ToString());
					return true;
				}
			}
			catch(DivideByZeroException e)
			{
				Console.WriteLine("ERROR!!! = " + e);
				return false;
			}
			return false;
        }
    }
}

