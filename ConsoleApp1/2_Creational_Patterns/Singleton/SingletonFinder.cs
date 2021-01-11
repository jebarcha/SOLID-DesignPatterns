using System.Collections.Generic;

namespace ConsoleApp1._2_Creational_Patterns.Singleton
{
    public class SingletonFinder
    {
        private ISingletonContainer _dataContainer;
        public SingletonFinder(ISingletonContainer dataContainer)
        {
            _dataContainer = dataContainer;
        }

        public int GetTotalPopulation(IEnumerable<string> names) 
        {
            int total = 0;
            foreach (var name in names)
            {
                //total += SingletonDataContainer.Instance.GetPopulation(name);
                total += _dataContainer.GetPopulation(name);
            }
            return total;
        }
    }
}
