using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Task1
{
    internal class RunnerJsonWriter
    {
        static public void write(string FileName , List <Runner> runners)
        {
            string fileName = FileName;
            string jsonString = JsonSerializer.Serialize(runners);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
