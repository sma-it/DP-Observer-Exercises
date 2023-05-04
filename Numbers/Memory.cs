using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Memory
    {
        

        public Memory(Generator subject)
        {
            _subject = subject;
            _subject.OnChange += OnNewNumber;
        }
        
        Generator? _subject = null;

        public void Unsubscribe()
        {
            if (_subject != null)
            {
                _subject.OnChange -= OnNewNumber;
                _subject = null;
            }
        }

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
