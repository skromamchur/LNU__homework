using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task1
{
    internal class RunnerCollection
    {
        public List<Runner> runners { get; set; }
        public RunnerCollection() { 
            this.runners = new List<Runner>();
        }

        private void updateFile() {
            RunnerJsonWriter.write("Runners.json", this.runners);
        } 

        public void addRunner(Runner runner) { 
           this.runners.Add(runner);

            updateFile();
        }

        public void removeRunner(int id) {
            this.runners.RemoveAll(item => item.id == id);

            updateFile();
        }

        public void EditById(int id, Runner newRunner)
        {
            int index = this.runners.FindIndex(item => item.id == id);

            this.runners[index] = newRunner;

            updateFile();
        }

        public void SortBy(string nameOfProperty) {
            this.runners = this.runners.OrderBy(runner =>
            {
                var propertyInfo = runner.GetType().GetProperty(nameOfProperty);
                var value = propertyInfo.GetValue(runner, null);
                Console.WriteLine(value);
                return value;
            }).ToList();

            updateFile();
        }

        public List<Runner> filteredListBySearch(string value)
        {
            PropertyInfo[] propInfos = typeof(Runner).GetProperties();
            List<Runner> filteredRunners = new List<Runner>();

            this.runners.ForEach(runner =>
            {
                foreach (PropertyInfo propInfo in propInfos)
                {
                   if(propInfo.PropertyType.ToString() == "System.String")
                   {
                        string propertyValue = propInfo.GetValue(runner)?.ToString();
                        
                        if(propertyValue == null)
                        {
                            continue;
                        }

                        if (propertyValue.Contains(value))
                        {
                            filteredRunners.Add(runner);
                        }
                   }
                }
            });
            
            return filteredRunners;
        }
    }
}
