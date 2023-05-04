using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Memory : IObserver
    {
        

        public Memory(ISubject subject)
        {
            _subject = subject;
            subject.Subscribe(this);
        }
        
        ISubject? _subject = null;

        public void Unsubscribe()
        {
            _subject?.Unsubscribe(this);
            _subject = null;
        }

        ~Memory()
        {
            Unsubscribe();
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
