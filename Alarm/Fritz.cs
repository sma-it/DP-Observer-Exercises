using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    internal class Fritz
    {
        private IAlarm? currentAlarm = null;
        public Fritz(IAlarm alarm)
        {
            currentAlarm = alarm;
            currentAlarm.OnBeep += OnAlarm;
        }

        public void ListenTo(IAlarm alarm)
        {
            StopListening();
            currentAlarm = alarm;
            currentAlarm.OnBeep += OnAlarm;
        }

        public void StopListening()
        {
            if (currentAlarm != null)
            {
                currentAlarm.OnBeep -= OnAlarm;
            }
        }

        public void OnAlarm()
        {
            Console.WriteLine("Fritz says NOOOO");
        }
    }
}
