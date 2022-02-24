using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Interface
    {
        static public IEnumerable<int> InterfaceGetOperation(string text, int exitKey) {
            while (true)
            {
                Console.WriteLine(text);
                int operation = Convert.ToInt32(Console.ReadLine());
                   
                if (operation == exitKey)
                {
                    break;
                }
                yield return operation;
            }
        }
    }
}
