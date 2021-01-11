using ConsoleApp1._2_Creational_Patterns.Singleton;
using Xunit;

namespace XUnitTestDesignPatterns
{
    public class UnitTestSingleton
    {
        [Fact]
        public void TestSingletonFinder()
        {
            var finder = new SingletonFinder(new DummyDatabase());
            var total = finder.GetTotalPopulation(new[] { "Mexico", "Torreon" });

            Assert.Equal(7000 + 222, total);
        }
    }
}
