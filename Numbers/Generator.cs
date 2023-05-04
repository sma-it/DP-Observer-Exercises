using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Generator : ISubject
    {
        public int LastNumber { get; set; }
        private Random random = new Random();

        List<IObserver> observers = new List<IObserver>();

        public void CreateNewNumber()
        {
            LastNumber = random.Next(10);
            Console.WriteLine("Generator creates a " + LastNumber);

            observers.ForEach(x => x.OnNewNumber(LastNumber));
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            if(observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
}
