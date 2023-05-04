using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Parrot : IObserver
    {
        public Parrot(ISubject subject)
        {
            _subject = subject;
            subject.Subscribe(this);
        }

        ~Parrot()
        {
            Unsubscribe();
        }

        ISubject? _subject = null;

        public void Unsubscribe()
        {
            _subject?.Unsubscribe(this);
            _subject = null;
        }

        public void OnNewNumber(int number)
        {
            Console.WriteLine("Parrot says: " + number);
        }
    }
}
