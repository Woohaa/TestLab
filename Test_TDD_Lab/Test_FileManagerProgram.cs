using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Lab;
using System.IO;
using System.Linq;

namespace Test_TDD_Lab
{

    //Mock
    public class TestWriteToFile : IWriteToFile
    {
        public string Input = null;

        public void SaveToFile(string input)
        {
            Input = input;
        }
    }


    [TestClass]
    public class Test_FileManagerProgram
    {

        [TestMethod]
        public void Test_AdditionResult()
        {
            TestWriteToFile fileWriter = new TestWriteToFile();
            FileManager manager = new FileManager(fileWriter);

            manager.WriteAdditionResultToFile(10, 20);

            Assert.AreEqual("Sum = 30", fileWriter.Input);
        }

        [TestMethod]
        public void Test_NameConcatenation()
        {
            TestWriteToFile fileWriter = new TestWriteToFile();
            FileManager manager = new FileManager(fileWriter);

            manager.SaveNameToFile("test1", "test2");

            Assert.AreEqual("Name: test1 Last Name: test2", fileWriter.Input);
        }

        [TestMethod]
        public void Test_SubtractionDifference()
        {
            TestWriteToFile fileWriter = new TestWriteToFile();
            FileManager manager = new FileManager(fileWriter);

            manager.WriteSubtractionDifferenceToFile(20, 10);

            Assert.AreEqual("Difference = 10", fileWriter.Input);
        }

        [TestMethod]
        public void Test_MultiplicationProduct()
        {
            TestWriteToFile fileWriter = new TestWriteToFile();
            FileManager manager = new FileManager(fileWriter);

            manager.WriteMultiplicationProductToFile(2, 5);

            Assert.AreEqual("Product = " + 10, fileWriter.Input);
        }

        [TestMethod]
        public void Test_DivisionQuota()
        {
            TestWriteToFile fileWriter = new TestWriteToFile();
            FileManager manager = new FileManager(fileWriter);

            manager.WriteDivisionQuotaToFile(4, 2);

            Assert.AreEqual("Quota = " + 2, fileWriter.Input);
        }

        [TestMethod]
        public void Test_DivisionWithValidNumbers()
        {
            TestWriteToFile fileWriter = new TestWriteToFile();
            FileManager manager = new FileManager(fileWriter);

            manager.WriteDivisionQuotaToFile(1, 10);

            Assert.AreEqual("Only allowed to divide by a lesser number", fileWriter.Input);
        }

        [TestMethod]
        public void Test_DivisibleByZero()
        {
            TestWriteToFile fileWriter = new TestWriteToFile();
            FileManager manager = new FileManager(fileWriter);

			bool expected = false;

			bool actual =  manager.WriteDivisionQuotaToFile(10, 0);
			bool actual2 = manager.WriteDivisionQuotaToFile(0, 10);

			Assert.AreEqual(expected, actual);
			Assert.AreEqual(expected, actual2);

        }

        [TestMethod]
        public void Test_FileCreation()
        {
            WriteToFile fileWriter = new WriteToFile();

            File.Delete(@"C:\Systemutvecklare Utbildning\Kurs Testning\Test.txt");

            fileWriter.SaveToFile("test");
            fileWriter.SaveToFile("test2");

            string[] actual = File.ReadLines(@"C:\Systemutvecklare Utbildning\Kurs Testning\Test.txt").ToArray();

            Assert.AreEqual("test", actual[0]);
            Assert.AreEqual("test2", actual[1]);
            Assert.AreEqual(actual.Length, 2);

        }
    }
}
