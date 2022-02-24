using System.Reflection;

namespace Task1 {
    public class Program {
        static void Main(string[] args)
        {
            
            RunnerCollection runnerCollection = new RunnerCollection();

            void addRuner() {
                int id = Convert.ToInt32(Console.ReadLine());

                //random
                runnerCollection.addRunner(new Runner(id));
            }

            void removeRuner() {
                int id = Convert.ToInt32(Console.ReadLine());

                runnerCollection.removeRunner(id);
            }

            void searchRunners() {
                Console.WriteLine(runnerCollection.filteredListBySearch("097"));            
            }

            void sortRunners() {
                runnerCollection.SortBy("PhoneNumber");
            }

            void editRunner()
            {
                int id1 = Convert.ToInt32(Console.ReadLine());
                int id2 = Convert.ToInt32(Console.ReadLine());
                runnerCollection.EditById(id1, new Runner(id2));
            }

            var dictionary = new Dictionary<int, Delegate>()
            {
                { 1, addRuner},
                { 2, removeRuner},
                { 3, searchRunners},
                { 4, sortRunners},
                { 5, editRunner}
            };

            const string text = "1 - add\n2 - remove\n3 - search\n4 - sort\n5 - edit\n0 - exit";
           

            foreach (int operation in Interface.InterfaceGetOperation(text, 0)) {
                dictionary[operation].DynamicInvoke();
            }
        }
    }
}




