using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    internal class Dog : IListener
    {
        private IAlarm? currentAlarm = null;
        public Dog(IAlarm alarm)
        {
            alarm.AddListener(this);
        }

        public void ListenTo(IAlarm alarm)
        {
            StopListening();
            alarm.AddListener(this);
            currentAlarm = alarm;
        }

        public void StopListening()
        {
            if (currentAlarm != null)
            {
                currentAlarm.RemoveListener(this);
            }
        }

        public void OnAlarm()
        {
            Console.WriteLine("Doggy Says Woof");
        }
    }
}
