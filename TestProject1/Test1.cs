using System.Runtime.CompilerServices;
using PWR_dotNER_Pr1;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodItem()
        //Sprawdzenie generowanych przemiotów pod kontem poprawności
        {
            Random random = new Random(1);
            Item item = new Item(0, random);
            Assert.IsNotNull(item.Price);
            Assert.IsNotNull(item.Weight);
        }
        [TestMethod]
        public void TestMethodCountElements() 
        // Sprawdzenie czy ilość elementów jest zgodna z podanymi
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int i in sizes)
            {
                Problem problem = new Problem(i, 1);
                Assert.AreEqual(problem.Items.Count, i);
            }
        }
        [TestMethod]
        public void TestMethod1()
        // Sprawdzenie, czy jeśli co najmniej jeden przedmiot spełnia ograniczenia, to zwrócono co najmniej jeden element.
        {
            Problem problem = new Problem();
            problem.ItemAdd(1, 5);
            problem.ItemAdd(10, 6);

            string test = problem.Solver(1);
            string[] lines = test.Split('\n');
            bool hasItem = lines[0] != "Moje przedmioty: ";
            Assert.IsTrue(hasItem);
        }
        [TestMethod]
        public void TestMethod2()
        //Sprawdzenie, czy jeśli żaden przedmiot nie spełnia ograniczeń, to zwrócono puste rozwiązanie.
        {
            Problem problem = new Problem();
            problem.ItemAdd(5, 10);
            problem.ItemAdd(8, 15);
            problem.ItemAdd(12, 20);
            int testCapacity = 3;
            string result = problem.Solver(testCapacity);
            bool isEmpty = (result == "Moje przedmioty: \r\nWaga plecaka: 0\r\nCena plecaka: 0");
            Assert.IsTrue(isEmpty);
        }

        [TestMethod]
        public void TestMethod3()
        //Sprawdzenie poprawności wyniku dla konkretnej instancji.
        {
            Problem problem = new Problem(0, 1);
            problem.ItemAdd(3, 6);
            problem.ItemAdd(2, 8);
            problem.ItemAdd(4, 7);
            problem.ItemAdd(1, 2);
            int testCapacity = 5;
            string result = problem.Solver(testCapacity);
            string expectedOutputStart = "Moje przedmioty: 1 0 ";
            bool isCorrect = result.StartsWith(expectedOutputStart);
            Assert.IsTrue(isCorrect, $"Solver zwrócił niepoprawny wynik: {result}");
        }
    }
}
