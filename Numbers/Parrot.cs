using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Parrot
    {
        public Parrot(Generator subject)
        {
            _subject = subject;
            subject.OnChange += OnNewNumber;
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

        public void OnNewNumber(int number)
        {
            Console.WriteLine("Parrot says: " + number);
        }
    }
}
