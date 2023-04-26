using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    internal class FancyAlarm : IAlarm
    {
        private List<IListener> listeners = new List<IListener>();

        public void AddListener(IListener listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            if (listeners.Contains(listener))
            {
                listeners.Remove(listener);
            }
        }

        public void Beep()
        {
            Console.WriteLine("Alarm says B.E.E.P.!");
            listeners.ForEach(listener => listener.OnAlarm());
        }
    }
}
