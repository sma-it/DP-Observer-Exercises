using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Memory
    {
        private List<int> _memory = new List<int>();

        public void OnNewNumber(int number)
        {
            _memory.Add(number);

            Console.Write("Numbers so far: ");
            _memory.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}
