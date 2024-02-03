using LAB_9_Pokemon;
namespace TestPokemon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange - ожидаемое
            Pokemon expected = new Pokemon(17,32,1);
            //Act - что проверяется
            Pokemon actual = new Pokemon();
            //Assert - сравниваем
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange - ожидаемое
            Pokemon expected = new Pokemon(17, 32, 1);
            //Act - что проверяется
            Pokemon actual = new Pokemon(1,1,1);
            //Assert - сравниваем
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange - ожидаемое
            Pokemon expected = new Pokemon(120, 232, 11);
            //Act - что проверяется
            Pokemon actual = new Pokemon(17, 32, 1);
            actual.AddParam(103, 200, 10);
            //Assert - сравниваем
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange - ожидаемое
            Pokemon expected = new Pokemon(20, 42, 13);
            //Act - что проверяется
            Pokemon actual = new Pokemon(20,42,13);
            Pokemon actual2 = new Pokemon(actual);
            //Assert - сравниваем
            Assert.AreEqual(expected,actual2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange - ожидаемое
            Pokemon expected = new Pokemon(40, 57, 23);
            //Act - что проверяется
            Pokemon actual = new Pokemon(30, 47, 13);
            Pokemon.AddParam(actual, 10, 10, 10);
            //Assert - сравниваем
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange - ожидаемое
            int expected = 50;
            //Act - что проверяется
            Pokemon actual = new Pokemon();
            int totalStats = (int)actual;
            //Assert - сравниваем
            Assert.AreEqual(expected, totalStats);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange - ожидаемое
            double expected = 84.66;
            //Act - что проверяется
            Pokemon actual = new Pokemon(20, 20, 56);
            double comPower = ~actual;
            //Assert - сравниваем
            Assert.AreEqual(expected, comPower);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange - ожидаемое
            Pokemon expected = new Pokemon(30, 47, 12);
            //Act - что проверяется
            Pokemon actual = new Pokemon(30, 47, 13);
            --actual;
            //Assert - сравниваем
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange - ожидаемое
            double expected = 16.67;
            //Act - что проверяется
            Pokemon actual = new Pokemon(17, 32, 1);
            double meanStats = actual;
            //Assert - сравниваем
            Assert.AreEqual(expected, meanStats);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange - ожидаемое
            Pokemon expected = new Pokemon(37,37,11);
            //Act - что проверяется
            Pokemon actual = new Pokemon(17, 32, 1);
            actual = actual >> 10;
            actual = actual > 5;
            actual = actual < 20;
            //Assert - сравниваем
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange - ожидаемое
            PokemonArray expected = new PokemonArray(1);
            //Act - что проверяется
            PokemonArray actual = new PokemonArray(expected);
            //Assert - сравниваем
            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i]);
        }
        [TestMethod]
        public void TestGet()
        {
            //Arrange - ожидаемое
            PokemonArray expected = new PokemonArray(3);
            //Assert - сравниваем
            Assert.ThrowsException<Exception>(() => { new Pokemon(expected[5]); }) ;
            Assert.ThrowsException<Exception>(() => { new Pokemon(expected[-1]); });
        }
        [TestMethod]
        public void TestGet3()
        {
            //Arrange - ожидаемое
            PokemonArray expected = new PokemonArray(2);
            Pokemon p = new Pokemon();
            //Act - что проверяется
            expected[1] = new Pokemon();
            Pokemon p1 = expected[1];
            //Assert - сравниваем
            Assert.AreEqual(p, p1);
        }

    }
}